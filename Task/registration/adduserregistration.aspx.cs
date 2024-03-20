using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Task_registration_adduserregistration : System.Web.UI.Page
{
    public string agegropss, sessionss, timeslotss, id;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    public string viewage, viewsession, viewtimeslote, vieweventdate, timess, ages, sess;
    public string events = "", eventview, viewevent;

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
        viewa.Visible = false;
        views.Visible = false;
        viewt.Visible = false;
      
       
        con.Open();
        string str1 = "select id,Eventname from event";
        SqlCommand cmdev = new SqlCommand(str1, con);
        eventview = "";
        SqlDataReader drevent;
        drevent = cmdev.ExecuteReader();
        while (drevent.Read())
        {
            Session["Eventname"] = drevent["Eventname"].ToString();


            eventview = eventview + " <option value='" + drevent["id"].ToString() + "'>" + drevent["Eventname"].ToString() + "</option>";
        }

        drevent.Close();
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

        
       

        btnupdate.Visible = false;

        if (!IsPostBack)
        {

            try
            {

                id = Request.QueryString["id"].ToString();
                con.Open();
                if (Request.QueryString["id"].ToString() != null)
                {
                    cmd = new SqlCommand("select * from event_registration where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    
                    txtfname.Text = (dr["firstname"].ToString());
                    txtlname.Text = dr["lastname"].ToString();

                    string eventnames = bb.getSingleData("select Eventname from event where eventid=" + dr["eventid"].ToString());
                    viewevent = eventnames;

                    txtemail.Text=dr["email"].ToString();
                    txtcontactnumber.Text = dr["contactnumber"].ToString();

                    rdobtn.SelectedItem.Text = dr["gender"].ToString();
                    txtdob.Text=dr["dob"].ToString();
                    drdagegroup.SelectedItem.Text = dr["agegroup"].ToString();

                    viewtimeslote = dr["timeslote"].ToString();
                    viewsession = dr["session"].ToString();

                    txthearaboutus.Text = dr["hearaboutus"].ToString();
                    drdstate.SelectedItem.Text = dr["city"].ToString();

                    //chkpreffcontact.SelectedItem.Text = dr["Preferredwaytocontact"].ToString();
                    txtcommentifany.Text = dr["commentsifany"].ToString();





                    dr.Close();
                    con.Close();
                    btnupdate.Visible = true;
                    btnsave.Visible = false;


                    views.Visible = true;
                    viewt.Visible = true;
                   
                    viewa.Visible = true;
                }
                else
                {
                    btnupdate.Visible = false;
                    btnsave.Visible = true;
                    views.Visible = false;
                    viewt.Visible = false;
                   
                    viewa.Visible = false;
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
            events = Page.Request.Form["eventfor"].ToString();
            sessionss = Page.Request.Form["sessions1"].ToString();
            timeslotss = Page.Request.Form["timeslot1"].ToString();
        }
        catch
        {
            events= "0";
            sessionss = "0";
            timeslotss = "0";

        }

        bb.insert("event_registration", events, txtfname.Text, txtlname.Text, txtemail.Text, txtcontactnumber.Text, rdobtn.SelectedItem.Text, txtdob.Text.ToString(), drdagegroup.SelectedItem.Text, timeslotss, sessionss, txthearaboutus.Text, drdstate.SelectedItem.Text, chkpreffcontact.SelectedItem.Text, txtcommentifany.Text, "Registered", DateTime.Now.ToString(), Request.Cookies["email"].Value.ToString());


        bb.insert("login", txtfname.Text + " " + txtlname.Text, "0", "user", txtemail.Text, txtcontactnumber.Text, txtpassword.Text, "", "","InActive");

       //we need to discuss about fro mail one to many event select then getby name ma problem thase
        //string eventnames = bb.getSingleData("select event name from Eventname where id="+events);

        bb.mail(txtemail.Text,"Rangeela Raas Rock Registration","Your Username is : '"+txtemail.Text+"' And Your Password is : '"+txtpassword+"',</ br> Please Login For Further Details.");

    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {

        try
        {
            id = Request.QueryString["id"].ToString();
        }
        catch
        {
            Response.Redirect("viewregistration.aspx");
        }

        try
        {
            events = Page.Request.Form["eventfor"].ToString();
            sessionss = Page.Request.Form["sessions1"].ToString();
            timeslotss = Page.Request.Form["timeslot1"].ToString();
        }
        catch
        {
            events = "0";
            sessionss = "0";
            timeslotss = "0";

        }
        con.Open();
        SqlCommand cmd = new SqlCommand("update event_registration set eventid='"+events+"',firstname='" + txtfname.Text + "',lastname='" + txtlname.Text + "',email='" + txtemail.Text + "',contactnumber='" + txtcontactnumber.Text + "',gender='" + rdobtn.SelectedItem.Text + "',dob='" + txtdob.Text + "',agegroup='" + drdagegroup.SelectedItem.Text + "',timeslote='" + timeslotss + "',session='" + sessionss + "',hearaboutus='" + txthearaboutus.Text + "',city='" + drdstate.SelectedItem.Text + "',Preferredwaytocontact='" + chkpreffcontact.SelectedItem.Text + "',commentsifany='"+txtcommentifany.Text+"' where id="+id,con);
        cmd.ExecuteNonQuery();


       

        con.Close();
        Response.Redirect("viewregistration.aspx");
    }
}