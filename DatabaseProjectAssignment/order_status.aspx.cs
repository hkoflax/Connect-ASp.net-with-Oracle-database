using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class order_status : System.Web.UI.Page
{
    private static String connectionString = ConfigurationManager.ConnectionStrings["DatabaseAssignment"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void oarderStatus_Click(object sender, EventArgs e)
    {
        int a = 0;
        bool answer=int.TryParse(basketIdTxt.Text, out a);
        OracleConnection conn = new OracleConnection(connectionString);
        if (answer==true)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "STATUS_SP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_BASKETID", OracleType.Number).Value = a;
                cmd.Parameters.Add("p_status", OracleType.NChar).Direction = ParameterDirection.Output;
                cmd.Parameters["p_status"].Size = 50;

                cmd.ExecuteNonQuery();
                var Result = Convert.ToString(cmd.Parameters["p_status"].Value);
                StatusLbl.Text = Result;

            }
            finally
            {
                conn.Dispose();
            }
            StatusLbl.Visible = true;
        }else
        {
            StatusLbl.Visible = false;
        }
    }
}