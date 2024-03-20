using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
public partial class Task_event_addevent : System.Web.UI.Page
{
    public string agegropss,sessionss,timeslotss,id,flyer;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string viewage, viewsession, viewtimeslote, vieweventdate, timess, ages, sess;
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
        con.Open();
        string str20 = "select name from agegroup";
        SqlCommand cmdage = new SqlCommand(str20, con);
         ages = "";
        SqlDataReader drage;
        drage = cmdage.ExecuteReader();
        while (drage.Read())
        {
            Session["name"] = drage["name"].ToString();


            ages = ages + " <option value='" + drage["name"].ToString() + "'>" + drage["name"].ToString() + "</option>";
        }
        drage.Close();
        con.Close();

        con.Open();
        string str21 = "select name from sessionss";
        SqlCommand cmdsession = new SqlCommand(str21, con);
         sess = "";
        SqlDataReader drs;
        drs = cmdsession.ExecuteReader();
        while (drs.Read())
        {
            Session["name"] = drs["name"].ToString();


            sess = sess + " <option value='" + drs["name"].ToString() + "'>" + drs["name"].ToString() + "</option>";
        }
        drs.Close();
        con.Close();



        con.Open();
        string str22 = "select name from timeslotes";
        SqlCommand cmdtime = new SqlCommand(str22, con);
         timess = "";
        SqlDataReader drtime;
        drtime = cmdtime.ExecuteReader();
        while (drtime.Read())
        {
            Session["name"] = drtime["name"].ToString();


            timess = timess + " <option value='" + drtime["name"].ToString() + "'>" + drtime["name"].ToString() + "</option>";
        }
        drtime.Close();
        con.Close();



        viewa.Visible = false;
        views.Visible = false;
        viewt.Visible = false;
        btnupdate.Visible = false;

     
      


        if (!IsPostBack)
        {

            try
            {

                id = Request.QueryString["id"].ToString();
                con.Open();
                if (Request.QueryString["id"].ToString() != null)
                {
                    cmd = new SqlCommand("select * from event where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    txteventname.Text = (dr["Eventname"].ToString());
                    txteventdate.Text = dr["Eventdate"].ToString();
                    vieweventdate = dr["Eventdate"].ToString();
                    drdeventcategory.SelectedItem.Text = dr["Eventcategory"].ToString();
                    viewage = dr["Agegroup"].ToString();
                    viewsession = dr["Sessions"].ToString();
                    viewtimeslote = dr["Timeslots"].ToString();
                    drdcontentcategory.SelectedItem.Text = dr["Contetcategory"].ToString();

                    txtseat.Text = dr["Seats"].ToString();



                    dr.Close();
                    con.Close();
                    btnupdate.Visible = true;
                    btnsave.Visible = false;

                    viewa.Visible = true;
                    views.Visible = true;
                    viewt.Visible = true;

                }
                else
                {
                    btnupdate.Visible = false;
                    btnsave.Visible = true;
                    viewa.Visible = false;
                    views.Visible = false;
                    viewt.Visible = false;
        
                }


            }
            catch
            {

            }

            return;
        }



    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
         try
        {
            agegropss = Page.Request.Form["agegroup"].ToString();
            sessionss = Page.Request.Form["sessions1"].ToString();
            timeslotss = Page.Request.Form["timeslot1"].ToString();
         
        }
        catch
        {
            agegropss = "0";
            sessionss = "0";
            timeslotss = "0";
           

        }


         string file = fuvideo.FileName.Replace(".", System.DateTime.Now.ToString("ddMMyyhhmmss."));

         string Document_Path = Server.MapPath("/media/flyerimg/" + Path.GetFileName(file));

         fuvideo.SaveAs(Document_Path);
         if (fuvideo.HasFile)
         {
             flyer = "/media/flyerimg/" + Path.GetFileName(file);
            
         }
         else { }

         bb.insert("event", DateTime.Now.ToString(), txteventname.Text, drdeventcategory.SelectedItem.Text, agegropss, sessionss, timeslotss, txteventdate.Text.ToString(), "", txtseat.Text, drdcontentcategory.SelectedItem.Text, "Created", "True", Request.Cookies["email"].ToString(), flyer);

        Response.Redirect("viewevent.aspx");


    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
          try
        {
            agegropss = Page.Request.Form["agegroup"].ToString();
            sessionss = Page.Request.Form["sessions1"].ToString();
            timeslotss = Page.Request.Form["timeslot1"].ToString();
         
        }
        catch
        {
            agegropss = "0";
            sessionss = "0";
            timeslotss = "0";
           

        }
        try
        {
            id = Request.QueryString["id"].ToString();
        }
        catch
        {

        }
        con.Open();
        SqlCommand cmd = new SqlCommand("update event set Eventname='" + txteventname.Text + "',Eventcategory='" + drdeventcategory.SelectedItem.Text + "',Agegroup='" + agegropss + "',Sessions='" + sessionss + "',Timeslots='" + timeslotss + "',Eventdate='" + txteventdate.Text.ToString() + "',Seats='" + txtseat.Text + "',Contetcategory='"+drdcontentcategory.SelectedItem.Text+"' where id=" + id, con);
        cmd.ExecuteNonQuery();

        con.Close();

        Response.Redirect("viewevent.aspx");
    }
}