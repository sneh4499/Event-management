using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Task_registration_viewregistration : System.Web.UI.Page
{
    public string data = "";
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
        //data = bb.sqlDisplaytable("select firstname,");



        cn.Open();

        SqlCommand cmd = new SqlCommand("select * from event_registration", cn);
        SqlDataReader dr;

        dr = cmd.ExecuteReader();
        data = "<table class='table table-bordered table-striped table-vcenter js-dataTable-full'>";
        //genrating Tabel Headers
        data = data + " <thead > <tr >";
        data = data + "<Th>Id</Th><th>Event Name</th><th>Name</th><th>Email</th><th>Number</th><th>City</th><th>Gender</th><th>View</th><th>Edit</th><th>Action</th><th></th></tr></thead><tbody>";
        int i = 0;
        while (dr.Read())
        {
            //i++;

            string eventnames = bb.getSingleData("select Eventname from event where id="+dr["eventid"].ToString());

            string rid=dr["Id"].ToString();
          //  string selectloginid=bb.getSingleData("select id from login where email like '"+dr["email"].ToString()+"'");

           string loginstatus=bb.getSingleData("select status from login where email like '"+dr["email"].ToString()+"'");

            //if(loginstatus=="Active")
            //{
            //    data = data + "<tr><td>" + rid + "</td><td>" + eventnames + "</td><td>" + dr["firstname"].ToString() + " " + dr["lastname"].ToString() + "</td><td>" + dr["email"].ToString() + "</td><td>" + dr["contactnumber"].ToString() + "</td><td>" + dr["city"].ToString() + "</td><td>" + dr["gender"].ToString() + "</td><td><a href='detail.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-eye'></i> View</a></td><td><a href='detail.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-pencil'></i> Edit</a></td><td><a href='deactiveuser.aspx?id=" + dr["id"].ToString() + "' class='btn btn-danger'> Deactive</a></td></tr>";
            //}
            //else if(loginstatus=="InActive")
            //{
            //    data = data + "<tr><td>" + rid + "</td><td>" + eventnames + "</td><td>" + dr["firstname"].ToString() + " " + dr["lastname"].ToString() + "</td><td>" + dr["email"].ToString() + "</td><td>" + dr["contactnumber"].ToString() + "</td><td>" + dr["city"].ToString() + "</td><td>" + dr["gender"].ToString() + "</td><td><a href='detail.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-eye'></i> View</a></td><td><a href='detail.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-pencil'></i> Edit</a></td><td><a href='activeuser.aspx?id=" + dr["id"].ToString() + "' class='btn btn-success'> Active</a></td></tr>";

            //}


          if(dr["status"].ToString()=="Registered")
          {

              data = data + "<tr><td>" + rid + "</td><td>" + eventnames + "</td><td>" + dr["firstname"].ToString() + " " + dr["lastname"].ToString() + "</td><td>" + dr["email"].ToString() + "</td><td>" + dr["contactnumber"].ToString() + "</td><td>" + dr["city"].ToString() + "</td><td>" + dr["gender"].ToString() + "</td><td><a href='detail.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-eye'></i> View</a></td><td><a href='adduserregistration.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-pencil'></i> Edit</a></td><td><a href='approve.aspx?id=" + dr["id"].ToString() + "' class='btn btn-success'> Approve</a> </td><td><a href='decline.aspx?id=" + dr["id"].ToString() + "' class='btn btn-danger'>Decline</a></td></tr>";
          }
            else if(dr["status"].ToString()=="Approved")
          {
              data = data + "<tr><td>" + rid + "</td><td>" + eventnames + "</td><td>" + dr["firstname"].ToString() + " " + dr["lastname"].ToString() + "</td><td>" + dr["email"].ToString() + "</td><td>" + dr["contactnumber"].ToString() + "</td><td>" + dr["city"].ToString() + "</td><td>" + dr["gender"].ToString() + "</td><td><a href='detail.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-eye'></i> View</a></td><td><a href='adduserregistration.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-pencil'></i> Edit</a></td><td><a href='decline.aspx?id=" + dr["id"].ToString() + "' class='btn btn-danger'> Decline</a></td></tr>";
          }
            else if(dr["status"].ToString()=="Declined")
          {
              data = data + "<tr><td>" + rid + "</td><td>" + eventnames + "</td><td>" + dr["firstname"].ToString() + " " + dr["lastname"].ToString() + "</td><td>" + dr["email"].ToString() + "</td><td>" + dr["contactnumber"].ToString() + "</td><td>" + dr["city"].ToString() + "</td><td>" + dr["gender"].ToString() + "</td><td><a href='detail.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-eye'></i> View</a></td><td><a href='adduserregistration.aspx?id=" + dr["id"].ToString() + "' class='btn btn-primary'><i class='fa fa-pencil'></i> Edit</a></td><td><a href='approve.aspx?id=" + dr["id"].ToString() + "' class='btn btn-success'> Approve</a></td></tr>";
          }

           
        }
        data = data + "</tbody></table>";
        dr.Close();
        cn.Close();

    }
}   