using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class updateProduct : System.Web.UI.Page
{
    private static String connectionString = ConfigurationManager.ConnectionStrings["DatabaseAssignment"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindNames();
        }
    }

    private void BindNames()
    {
        OracleConnection conn = new OracleConnection(connectionString);
        try
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT IDPRODUCT,PRODUCTNAME FROM bb_product";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            NameList.DataSource = dr;
            NameList.DataTextField = "PRODUCTNAME";
            NameList.DataValueField = "IDPRODUCT";
            NameList.DataBind();
        }
        finally
        {
            conn.Dispose();
        }
    }

    protected void update_Click(object sender, EventArgs e)
    {
        OracleConnection conn = new OracleConnection(connectionString);
        try
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "change_product_name";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("product_id", OracleType.Number).Value = NameList.SelectedItem.Value;
            cmd.Parameters.Add("product_desc", OracleType.VarChar).Value = productNameTxt.Text;

            cmd.ExecuteNonQuery();
        }
        finally
        {
            conn.Dispose();
        }
        Response.Redirect("Default.aspx");
    }
}