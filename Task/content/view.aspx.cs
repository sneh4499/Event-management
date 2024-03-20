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
public partial class Task_content_view : System.Web.UI.Page
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
    protected void Application_BeginRequest(object sender, EventArgs e)
    {
        HttpContext.Current.Response.AddHeader("X-Frame-Options", "DENY");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = new SqlCommand("select * from content",cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();

        while(dr.Read())
        {
            string videopath = dr["fileurl"].ToString();
            string names=dr["name"].ToString();
            string contenttype = dr["type"].ToString();
            data = data + "<div class='col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12'> <div class='video-testimonial-block'> <div class='video'><a href=" + videopath + " target='_blank'><video width='320' height='240'  poster='/play.gif' controls> <iframe src=" + videopath + " allowfullscreen> </iframe></video></a> </div> <a href='#' class='video-play'></a> </div> <div class='video-testimonial-content'> <h6 class='mb10'>Content Name : " + names + "</h6> <h5 class='mb10'>Content Type : " + contenttype + "</h5> </div> </div>";
        }
        dr.Close();
        cn.Close();

        
       
    }
}