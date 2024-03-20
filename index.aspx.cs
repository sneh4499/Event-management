using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class index : System.Web.UI.Page
{
    public string id = "";
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Request.Cookies["role"].Value != null && Request.Cookies["email"].Value != null)
            {
                Response.Redirect("/Department/" + Request.Cookies["role"].Value + "/index.aspx");

            }

        }
        catch
        {
            // Response.Redirect("~/index.aspx");
            //do nothing

        }


    }
    protected void btnsign_Click(object sender, EventArgs e)
    {
        string status = bb.getSingleData("select status from login where status like 'Active'");

        if(status=="Active")
        {

            Boolean f;
            f = bb.autheticateUser(ReplaceSpecialCharacters(txtemail.Text), ReplaceSpecialCharacters(txtpassword.Text));
            if (f == true)
            {
                string role;
                role = bb.getSingleData("select role from login where email like '" + txtemail.Text + "'");
                Response.Cookies["role"].Value = role;
                Response.Cookies["email"].Value = txtemail.Text;

                Response.Redirect("/Department/" + role + "/index.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid UserName and Password....!')", true);
            }
        }
        else{
            Response.Write("<script>alert('Please Contact Rangeela Raas Rock')</script>");
        }


    }
    public static string ReplaceSpecialCharacters(string strInput)
    {
        strInput = strInput.Replace("--", "++");
        strInput = strInput.Replace('&', ',');
        strInput = strInput.Replace("%", "[%]");
        strInput = strInput.Replace('+', ',');
        //  strInput = strInput.Replace("_", "[_]");
        strInput = strInput.Replace("[", "[[]");
        strInput = strInput.Replace("]", "[]]");
        strInput = strInput.Replace("'", "''");
        return strInput;
    }
}