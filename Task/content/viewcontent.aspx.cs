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
public partial class Task_content_viewcontent : System.Web.UI.Page
{
    public string data = "", email, tabs, totalcount;
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
        try
        {
            email = Request.Cookies["email"].Value;
        }
        catch
        {
           // Response.Redirect("index.aspx");
        }



        try
        {
            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from content where uploadby like '" + email + "'", cn);
            SqlDataReader dr;

            dr = cmd.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                i++;
                string date = Convert.ToDateTime(dr["datetime"]).ToString("MM");
                string d = DateTime.Now.ToString("MM");

                string name = bb.getSingleData("select username from login where email like '" + dr["uploadby"].ToString() + "'");
                string id = bb.getSingleData("select id from login where email like '" + dr["uploadby"].ToString() + "'");


                if (Int32.Parse(date) == Int32.Parse(d))
                {
                    data += "<div class='col-md-4 col-xl-3' data-category='current0'>Content Type-<a href=#>" + dr["type"].ToString() + "</a><a href='" + dr["fileurl"].ToString() + "' target='_blank'><img width='200' height='150' src='/play.gif'></a> <br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>" + dr["name"].ToString() + "</a><button type='button' class='btn btn-alt-'  data-toggle='popover' title=" + dr["name"].ToString() + "&nbsp " + dr["type"].ToString() + "</button></div>";
                }
                else if (Int32.Parse(date) == Int32.Parse(d) - 01)
                {
                    data += "<div class='col-md-4 col-xl-3' data-category='current1'>Content Type-<a href=#>" + dr["type"].ToString() + "</a><a href='" + dr["fileurl"].ToString() + "' target='_blank'><img width='200' height='150' src='/play.gif'></a><br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>" + dr["name"].ToString() + "</a><button type='button' class='btn btn-alt-'  data-toggle='popover' title=" + dr["name"].ToString() + "&nbsp " + dr["type"].ToString() + "</button></div>";
                }
                else if (Int32.Parse(date) == Int32.Parse(d) - 02)
                {
                    data += "<div class='col-md-4 col-xl-3' data-category='current2'>Content Type-<a href=#>" + dr["type"].ToString() + "</a><a href='" + dr["fileurl"].ToString() + "' target='_blank'><img width='200' height='150' src='/play.gif'></a> <br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>" + dr["name"].ToString() + "</a><button type='button' class='btn btn-alt-'  data-toggle='popover' title=" + dr["name"].ToString() + "&nbsp " + dr["type"].ToString() + "</button></div>";
                }
                else if (Int32.Parse(date) == Int32.Parse(d) - 03)
                {
                    data += "<div class='col-md-4 col-xl-3' data-category='current3'>Content Type-<a href=#>" + dr["type"].ToString() + "</a><a href='" + dr["fileurl"].ToString() + "' target='_blank'><img width='200' height='150' src='/play.gif'></a> <br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>" + dr["name"].ToString() + "</a><button type='button' class='btn btn-alt-'  data-toggle='popover' title=" + dr["name"].ToString() + "&nbsp " + dr["type"].ToString() + "</button></div>";
                }
                else if (Int32.Parse(date) == Int32.Parse(d) - 04)
                {
                    data += "<div class='col-md-4 col-xl-3' data-category='current4'>Content Type-<a href=#>" + dr["type"].ToString() + "</a><a href='" + dr["fileurl"].ToString() + "' target='_blank'><img width='200' height='150' src='/play.gif'></a> <br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>" + dr["name"].ToString() + "</a><button type='button' class='btn btn-alt-'  data-toggle='popover' title=" + dr["name"].ToString() + "&nbsp " + dr["type"].ToString() + "</button></div>";
                }
                else if (Int32.Parse(date) == Int32.Parse(d) - 05)
                {
                    data += "<div class='col-md-4 col-xl-3' data-category='current5'>Content Type-<a href=#>" + dr["type"].ToString() + "</a><a href='" + dr["fileurl"].ToString() + "' target='_blank'><img width='200' height='150' src='/play.gif'></a><br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>" + dr["name"].ToString() + "</a><button type='button' class='btn btn-alt-'  data-toggle='popover' title=" + dr["name"].ToString() + "&nbsp " + dr["type"].ToString() + "</button></div>";
                }
                else if (Int32.Parse(date) == Int32.Parse(d) - 06)
                {
                    data += "<div class='col-md-4 col-xl-3' data-category='current6'>Content Type-<a href=#>" + dr["type"].ToString() +"</a><a href='" + dr["fileurl"].ToString() + "' target='_blank'><img width='200' height='150' src='/play.gif'></a> <br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>" + dr["name"].ToString() + "</a><button type='button' class='btn btn-alt-'  data-toggle='popover' title=" + dr["name"].ToString() + "&nbsp " + dr["type"].ToString() + "</div>";
                }
                else
                {
                    //data = data + "<div class='col-md-6 col-xl-3'> <iframe width='200' height='200' src=" + dr["fileurl"].ToString() + "></iframe> <br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>Go to This Link</a> </div>";
                    data += "<div class='col-md-6 col-xl-3' data-category='all'><iframe width='200' height='200' src=" + dr["fileurl"].ToString() + "></iframe> <br/> <a href=" + dr["fileurl"].ToString() + " target='_blank'>" + dr["name"].ToString() + "</a><button type='button' class='btn btn-alt-'  data-toggle='popover' title=" + dr["name"].ToString() + " &nbsp " + dr["type"].ToString() + "</button></div>";
                }

               // bb.insert("content_track",Request.Cookies["email"].Value.ToString(),);


            }

            dr.Close();
            cn.Close();
        }
        catch
        {

        }

       
        //<video width='250' height='300' controls> <source src=" + dr["fileurl"].ToString() + " type='video/mp4'> <source src=" + dr["fileurl"].ToString() + " type='video/webm'> <source src=" + dr["fileurl"].ToString() + " type='video/ogg'> Your browser does not support HTML video. </video> 



        try
        {

            totalcount = bb.getSingleData("select count(*) from content");

            string firstmonth = bb.getSingleData("select datetime from content");

            DateTime oDate = Convert.ToDateTime(firstmonth);
            string ddd = oDate.Month.ToString();
            int ad = Int32.Parse(ddd);

            string da = DateTime.Now.ToString("MM");
            int ad1 = Int32.Parse(da);

            int f = (ad1 - ad);


            for (int q = 0; q <= f; q++)
            {
                string o = (ad1 - q).ToString();
                string bac = getmonth(o);
                string total = bb.getSingleData("select count(*) from content where datetime like '%%/0" + o + "/%%'");
                tabs += "<li class='nav-item'> <a class='nav-link' href='#' data-category-link='current" + q + "'> <i class='fa fa-fw fa-calendar mr-5'></i> " + bac + " (" + total + ") </a> </li>";
                //Response.Write("<script>alert('"+bac+"')</script>");
            }
        }
        catch
        {

        }
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