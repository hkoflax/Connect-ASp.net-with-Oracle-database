using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calculateTax : System.Web.UI.Page
{
    private static String connectionString = ConfigurationManager.ConnectionStrings["DatabaseAssignment"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindStates();
            BindTaxtable();
            taxLabel.Visible = false;
        }
    }

    private void BindTaxtable()
    {
        OracleConnection conn = new OracleConnection(connectionString);
        try
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT STATE,TAXRATE from BB_TAX";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            tax_Table.DataSource = dr;
            tax_Table.DataBind();
        }
        finally
        {
            conn.Dispose();
        }
    }

    private void BindStates()
    {
        OracleConnection conn = new OracleConnection(connectionString);
        try
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select STATE from BB_TAX";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            cityList.DataSource = dr;
            cityList.DataTextField = "STATE";
            cityList.DataBind();
        }
        finally
        {
            conn.Dispose();
        }
    }

    protected void taxBtn_Click(object sender, EventArgs e)
    {
        double a = 0;
        bool answer = double.TryParse(subtotalTxt.Text, out a);
        OracleConnection conn = new OracleConnection(connectionString);
        if (answer == true)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "TAX_COST_SP ";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("P_STATE", cityList.SelectedItem.Text);
                cmd.Parameters.Add("P_SUBTOTAL", a);

                cmd.Parameters.Add("Result", OracleType.Number);
                cmd.Parameters["Result"].Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();
                var Result = Convert.ToString(cmd.Parameters["Result"].Value);
                taxLabel.Text = Result;

            }
            finally
            {
                conn.Dispose();
            }
            taxLabel.Visible = true;
        }
        else
        {
            taxLabel.Visible = false;
        }
    }
}