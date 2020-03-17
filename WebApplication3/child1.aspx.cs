using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication3
{
    public partial class child1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void txtbutton_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select *from newproject where empid=@un and password=@pw",con);
            adp.SelectCommand.Parameters.AddWithValue("@un", txtusername.Text);
            adp.SelectCommand.Parameters.AddWithValue("@pw", txtpassword.Text);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
            // DataRow R = ds.Tables["L"].NewRow();
            string name = "";
            string type = "";
            if(ds.Tables["L"].Rows.Count==1)
            {
                name = ds.Tables["L"].Rows[0][1].ToString();
                type = ds.Tables["L"].Rows[0][3].ToString();
            }
            if (type == "admin")
            {
                Response.Cookies["username"].Value =name;
                Response.Redirect("child2.aspx");
            }
            else if (type == "assistant")
            {
                Response.Cookies["username"].Value = name;
                Response.Redirect("child3.aspx");
            }
            else
                lblMessage.Text = "Invalid Credentials";
            txtusername.Focus();
        }
    }
}