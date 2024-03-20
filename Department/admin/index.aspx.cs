using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Department_admin_index : System.Web.UI.Page
{
    public string events, video, registrations, approvedregistration;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        try
        {

            string usemasterpage = Request.Cookies["role"].Value.ToString();
            if (usemasterpage != "")
            {
                MasterPageFile = "~/Department/" + usemasterpage + "/" + usemasterpage + ".master";
            }
            else
            {
                Response.Redirect("~/index.aspx");
            }

        }
        catch
        {
            Response.Redirect("~/index.aspx");
        }


       
        
        

        try
        {
            events = bb.getSingleData("select count(*) from event");
        }
        catch
        {
            events = "0";
        }
        try
        {
            video = bb.getSingleData("select count(*) from content");
        }
        catch
        {
            video = "0";
        }
        try
        {
            registrations = bb.getSingleData("select count(*) from event_registration");
        }
        catch
        {
            registrations = "0";
        }
        try
        {
            approvedregistration = bb.getSingleData("select count(*) from event_registration where status like 'Approved'");
        }
        catch
        {
            approvedregistration = "0";
        }
       
    } 
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}