using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class changepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();



        string emails = Request.Cookies["email"].Value.ToString();


        string checkpassword = bb.getSingleData("select password from login where email like '" + emails + "' ");

        if (checkpassword == txtoldpass.Text)
        {
            SqlCommand cmdupdatepas = new SqlCommand("update login set password='" + txtnewpass.Text + "' where email like '" + emails + "'", cn);

           
            cmdupdatepas.ExecuteNonQuery();
           


            ScriptManager.RegisterStartupScript(this, this.GetType(),
    "alert",
    "alert('Password Updated Sucessfully !');window.location ='/Department/admin/index.aspx';",
    true);
        }

        else if (txtoldpass.Text == "")
        {

            Response.Write("<script>alert('Enter You're Old Password !')</script>");
            //         ScriptManager.RegisterStartupScript(this, this.GetType(),
            //"alert",
            //"alert('Enter You're Old Password !');",
            //true);

        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(),
 "alert",
 "alert('Check You're Password !');",
 true);
        }


        cn.Close();
    }
}