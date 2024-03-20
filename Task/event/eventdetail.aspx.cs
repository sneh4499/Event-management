using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task_event_eventdetail : System.Web.UI.Page
{
    public string eventname, flyerimg, eventcategory, agegroups, sessionss, timeslots, evantedate, registarationclosed, seat, contentcategory, status, flyer,id;
    protected void Page_Load(object sender, EventArgs e)
    { 
        try
    {
            id=Request.QueryString["id"].ToString();
    }
        catch
        {
            Response.Redirect("viewevent.aspx");
        }

       eventname= bb.getSingleData("select eventname from event where id="+id);

     
       flyerimg = bb.getSingleData("select flyer from event where id=" + id);

       eventcategory = bb.getSingleData("select Eventcategory from event where id=" + id);
       agegroups = bb.getSingleData("select Agegroup from event where id=" + id);

       sessionss = bb.getSingleData("select Sessions from event where id=" + id);
       registarationclosed = bb.getSingleData("select Registrationclosedate from event where id" + id);

       timeslots = bb.getSingleData("select Timeslots from event where id=" + id);
       evantedate = bb.getSingleData("select Eventdate from event where id=" + id);
      
       seat = bb.getSingleData("select Seats from event where id=" + id);
       contentcategory = bb.getSingleData("select Contetcategory from event where id=" + id);

       status = bb.getSingleData("select Status from event where id=" + id);
      
    }
}