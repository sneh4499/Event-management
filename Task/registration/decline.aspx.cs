using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Task_registration_decline : System.Web.UI.Page
{
    public string id;
    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            id = Request.QueryString["id"].ToString();
            // approvedby = Request.Cookies["email"].Value.ToString();
        }
        catch
        {
            Response.Redirect("/Task/registration/viewregistration.aspx");
        }

        string emails = bb.getSingleData("select email from event_registration where id=" + id);

        // Response.Write("<script>alert('"+emails+"')</script>");
        cn.Open();
        SqlCommand cmd = new SqlCommand("update event_registration set status='Declined' where id=" + id, cn);
        cmd.ExecuteNonQuery();

        string loginemail = bb.getSingleData("select email from login where email like '"+emails+"'");
        SqlCommand cmd1 = new SqlCommand("update login set status='InActive' where email like '"+loginemail+"'", cn);
        cmd1.ExecuteNonQuery();


        bb.mail(emails, "Rangeela Raas Rock Registration", "Oppsss !! , Sorry You're Application is Declined");


        cn.Close();
        Response.Redirect("/Task/registration/viewregistration.aspx");
    }
}