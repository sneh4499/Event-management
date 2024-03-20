using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Task_attendance_addpresents : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        //for (int i = 0; i < chkatten.Items.Count; i++)
        //{
        //    if (!chkatten.Items[i].Selected)
        //    {
        //        chkatten.Items[i].Selected = true;
        //        break;
        //    }
        //}
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string k = "";
        for (int i = 0; i < chkatten.Items.Count; i++)
        {
            if (chkatten.Items[i].Selected)
            {

                k = k + chkatten.Items[i].Text + ",";

               
            }

        }
     
        //con.Open();
        //SqlCommand cmd = new SqlCommand("update event_registration set status='Present' where eventid='" + drdevent.SelectedValue + "' and attnedusers like '" + k + "'");
        //cmd.ExecuteNonQuery();
        //con.Close();

        bb.insert("attendance",drdevent.SelectedValue,drdsession.SelectedValue,k,DateTime.Now.ToString(),Request.Cookies["email"].Value.ToString());



        //lbmsg.Text = k;
        //lbmsg.ForeColor = System.Drawing.Color.ForestGreen; 
    }
    protected void drdevent_SelectedIndexChanged(object sender, EventArgs e)
    {
        drdsession.SelectedItem.Text = bb.getSingleData("select Sessions from event where Eventname like '"+drdevent.SelectedItem.Text+"'");

        string eid = bb.getSingleData("select Id from event where Eventname like '" + drdevent.SelectedItem.Text + "'");

      //  Response.Write();
       // chkatten.SelectedItem.Text = bb.getSingleData("select firstname from event_registration where eventid like '"+eid+"'");
    }
}