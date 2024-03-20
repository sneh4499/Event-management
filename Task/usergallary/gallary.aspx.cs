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
public partial class Task_usergallary_gallary : System.Web.UI.Page
{
    public string data = "",data1, email, tabs, totalcount;
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

        try
        {
            email=Request.Cookies["email"].Value;
        }
        catch
        {
            Response.Redirect("/login.aspx");
        }


        cn.Open();
        SqlCommand cmd = new SqlCommand("select type,name,fileurl from content", cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            string videopath = dr["fileurl"].ToString();
            string names = dr["name"].ToString();
            string contenttype = dr["type"].ToString();
          //  data = data + "<div class='col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12'> <div class='video-testimonial-block'> <div class='video'><a href=" + videopath + " target='_blank'><video width='320' height='240'  poster='/play.gif' controls> <iframe src=" + videopath + " allowfullscreen> </iframe></video></a> </div> <a href='#' class='video-play'></a> </div> <div class='video-testimonial-content'> <h6 class='mb10'>Content Name : " + names + "</h6> <h5 class='mb10'>Content Type : " + contenttype + "</h5> </div> </div>";
            int i = 0;
            i++;

            string role = bb.getSingleData("select role from login where email like '"+email+"'");

            if (contenttype == "Free")
            {
                data = data + "<iframe width='320' height='240' src=" + videopath + " frameborder='0' allowfullscreen> </iframe></center></li>";
                //data = data + "<li><center><video width='320' height='240' controls> <source src=" + videopath + " type='video/mp4'> </video></center></li>";
            }
            else
            {
                if (role == "user")
                {
                    data1 = data1 + "<li><center><iframe width='320' height='240' src=" + videopath + " frameborder='0' allowfullscreen> </iframe></center></li>";
                }
                else
                {
                    data1 = "<h3 style='color:red'><center>You Are Not Authorized to See Premium Videos.</center></h3>";
                }
            }
            //data = data + "<div id='tab1p" + i + "' class='tab active'><div class='col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12'>  <div class='video-testimonial-block'> <div class='video'><a href=" + dr["fileurl"].ToString() + " target='_blank'><video width='220' height='140'  poster='/play.gif' controls> <iframe src=" + dr["fileurl"].ToString() + " allowfullscreen> </iframe></video></a> </div> <a href='#' class='video-play'></a> </div> <div class='video-testimonial-content'> <h6 class='mb10'>Content Name : " + dr["name"].ToString() + "</h6> </div></div>  </div>";
            
        }
        dr.Close();
        cn.Close();
    }
}