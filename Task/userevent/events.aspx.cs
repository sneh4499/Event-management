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
public partial class Task_userevent_events : System.Web.UI.Page
{
    public string data = "", data1, email;
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

                Response.Redirect("~/login.aspx");
            }
        }
        catch
        {
            Response.Redirect("~/login.aspx");

        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = new SqlCommand("select * from event", cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
           
            string names = dr["Eventname"].ToString();
            string date = Convert.ToDateTime(dr["Eventdate"]).ToString("MM");
            string d = DateTime.Now.ToString("MM");

            string dayss = Convert.ToDateTime(dr["Eventdate"]).ToString("dd");

          string edate=getmonth(d);

            string id=dr["id"].ToString();

           // data = data + "<div class='post_date'> <span class='day'>23</span> <span class='month'>" + edate + "</span> </div> ";
           // data = data + "<div class='post_title'> <h2><a href='blog-single.html'>"+names+"</a></h2> </div>";


            data = data + "<ul class='posts'> <li class='swipeout'> <div class='swipeout-content item-content'> <div class='post_entry'> <div class='post_date'> <span class='day'>" + dayss + "</span> <span class='month'>" + edate + "</span>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp </div> <div class='post_title'> <h2><a href='blog-single.html'>" + names + "</a></h2> </div> <div class='post_swipe'> <img src='../../assest_user/images/swipe_more.png' alt='' title='' /></div> </div> </div> <div class='swipeout-actions-right'> <a href='/Task/userevent/eventdetail.aspx?id=" + id + "' class='action1'> <img src='../../assest_user/images/icons/white/menu.png' alt='' title='' /></a> <a href='/Task/userevent/uregi.aspx?id=" + id + "'' class=''> <img src='../../assest_user/images/icons/white/user.png' alt='' title='' /></a> </div> </li> </ul>";
        }
        dr.Close();
        cn.Close();
    }
    public string getmonth(string month)
    {
        string day = "";
        int a = Int32.Parse(month);
        switch (a)
        {
            case 01:
                day = "January";
                break;
            case 02:
                day = "February";
                break;
            case 03:
                day = "March";
                break;
            case 04:
                day = "April";
                break;
            case 05:
                day = "May";
                break;
            case 06:
                day = "June";
                break;
            case 07:
                day = "July";
                break;
            case 08:
                day = "August";
                break;
            case 09:
                day = "September";
                break;
            case 10:
                day = "October";
                break;
            case 11:
                day = "November";
                break;
            case 12:
                day = "December";
                break;

        }
        return day + DateTime.Now.ToString("yy");

    }
}