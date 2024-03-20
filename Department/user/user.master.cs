using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Department_user_user : System.Web.UI.MasterPage
{
    public string username = "", name, img, email = "", eventstotal;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            email = Request.Cookies["email"].Value.ToString();
        }
        catch
        {
            Response.Redirect("/login.aspx");
        }

        try
        {
            eventstotal = bb.getSingleData("select count(*) from event");
        }
        catch
        {
            eventstotal = "0";
        }

        try
        {
            name = bb.getSingleData("select username from login where email like '" + Request.Cookies["email"].Value.ToString() + "'");
            img = bb.getSingleData("select photo from login where email like '" + Request.Cookies["email"].Value.ToString() + "'");

            if (img == "0")
            {
                img = "/assest_user/images/profile.jpg";

            }
        }
        catch
        {
            img = "/assest_user/images/profile.jpg";
            name = "Name Not Found";
        }
    }
}
