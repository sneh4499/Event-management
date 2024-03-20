using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task_event_viewevent : System.Web.UI.Page
{
    public string data = "";
    protected void Page_PreInit(object sender, EventArgs e)
    {
        try
        {
            String useMasterPage = Request.Cookies["role"].Value.ToString();
            if (useMasterPage != "")
                MasterPageFile = "~/Department/" + useMasterPage + "/" + useMasterPage + ".Master";
            else
            {

                Response.Redirect("~/index.aspx");
            }
        }
        catch
        {
            Response.Redirect("~/index.aspx");

        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        data = bb.sqlDisplaytable("select id,Eventname,Eventdate,Eventcategory,Agegroup,Seats,Status from event where IsActive like 'True'","eventdetail.aspx?id=","View", "addevent.aspx?id=", "Edit", "deleteevent.aspx?id=","Delete");
    }
}