using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class add_product : System.Web.UI.Page
{
    private static String connectionString = ConfigurationManager.ConnectionStrings["DatabaseAssignment"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void save_Click(object sender, EventArgs e)
    {
        OracleConnection conn = new OracleConnection(connectionString);
        try
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "PROD_ADD_SP";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("p_productName", OracleType.NVarChar).Value = productNameTxt.Text;
            cmd.Parameters.Add("p_description", OracleType.NVarChar).Value = descriptionTxt.Text;
            cmd.Parameters.Add("p_productImage", OracleType.NVarChar).Value = image.Text;
            cmd.Parameters.Add("p_price", OracleType.Number).Value = Convert.ToInt32(priceTxt.Text);
            cmd.Parameters.Add("p_active", OracleType.Number).Value = StatusList.SelectedItem.Value;

            cmd.ExecuteNonQuery();
        }
        finally
        {
            conn.Dispose();
        }
        Response.Redirect("Default.aspx");
    }
}