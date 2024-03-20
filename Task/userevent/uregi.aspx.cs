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
public partial class Task_userevent_uregi : System.Web.UI.Page
{

    public string email = "", name, id, countseat;

    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
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
       // lblseats.Visible = false;
        try
        {
            email = Request.Cookies["email"].Value.ToString();
        }
        catch
        {

        }
        try
        {
             id=Request.QueryString["id"].ToString();
        }
        catch
        {

        }


        //txtusername.Text = bb.getSingleData("select username from login where email like '" + email + "'");
        //txtemail.Text = email;
        //txtphone.Text = bb.getSingleData("select number from login where email like '" + email + "'");


    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {


        //countseat = bb.getSingleData("select Seats from event where id=" + id);

        //string maxcount = bb.getSingleData("select count(*) from event_registration where eventid=" + id);


        //int i;
        //int co;
        //int maxs;
        //int.TryParse(maxcount, out maxs);
        //int.TryParse(countseat, out co);

        //if (maxs < co)
        //{

        //    bb.insert("event_registration", id, txtusername.Text, "", txtemail.Text, txtphone.Text, rdbtngender.SelectedItem.Text, txtdob.Text.ToString(), drdagegroup.SelectedItem.Text, drdtimeslote.SelectedItem.Text, drdsession.SelectedItem.Text, txthearaboutyou.Text, drdstate.SelectedItem.Text, chkpreffer.SelectedItem.Text, txtcommentifany.Text, "Registered", DateTime.Now.ToString(), email);

        //}
        //else
        //{
        //    lblseats.Visible = true;
        //}

        //cn.Open();
        //SqlCommand cmd = new SqlCommand("update login set role='user' where email like '" + email + "'");
        //cmd.ExecuteNonQuery();
        //cn.Close();
    }
}