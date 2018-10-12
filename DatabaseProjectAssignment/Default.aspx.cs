using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    private static String connectionString = ConfigurationManager.ConnectionStrings["DatabaseAssignment"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }
    }
    private void BindGrid()
    {
        OracleConnection conn = new OracleConnection(connectionString);
        try
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT IDPRODUCT,PRODUCTNAME,DESCRIPTION,PRODUCTIMAGE,PRICE,ACTIVE FROM bb_product";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }
        finally
        {
            conn.Dispose();
        }
    }
}