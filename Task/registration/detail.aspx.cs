using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Task_registration_detail : System.Web.UI.Page
{
    public string data = "",id;
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

            id = Request.QueryString["id"].ToString();

            if (Request.QueryString["id"].ToString() != null)
            {

                String role = Request.Cookies["role"].Value.ToString();

                cn.Open();

                SqlCommand cmd = new SqlCommand("select * from event_registration where id=@id", cn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

               

                while (dr.Read())
                {
                    string loginstatus = bb.getSingleData("select status from login where email like '" + dr["email"].ToString() + "'");
                    string eventnames = bb.getSingleData("select Eventname from event where id=" + dr["eventid"].ToString());
                    //   string birtcon = "";
                    // birtcon = Convert.ToDateTime(birth).ToString("dd-MM-yyyy");
                    //emp = emp + "<div class='row items-push js-gallery'> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgmedical + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgmedical + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgtradevali + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgtradevali + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgadharcard + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgadharcard + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgpass + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgpass + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgpan + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgpan + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgjoin + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgjoin + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> </div> <div class='row items-push js-gallery'> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgsupv + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgsupv + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> <div class='col-md-3 col-lg-3 col-xl-2 animated fadeIn'> <div class='options-container fx-item-zoom-in fx-overlay-slide-down'> <img class='img-fluid options-item' src=" + imgmemo + " alt='image not found'> <div class='options-overlay bg-black-op-75'> <div class='options-overlay-content'> <h3 class='h4 text-white mb-5'>Image</h3> <h4 class='h6 text-white-op mb-15'>More Details</h4> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-primary min-width-75 img-lightbox' href=" + imgmemo + "> <i class='fa fa-search-plus'></i> View </a> <a class='btn btn-sm btn-rounded btn-noborder btn-alt-success min-width-75' href='javascript:void(0)'><i class='fa fa-pencil'></i> Edit</a> </div> </div> </div> </div> </div>";
                    data = data + "<div class='bg-image bg-image-bottom mt-15 mr-15 ml-15' style='background-image:linear-gradient(135deg,#d262e3 0,#3f9ce8 100%);'> <div class='content content-full text-center pb-1'> <div class='mb-15'> <div class='img-link'> <img class='img-avatar img-avatar96 img-avatar-thumb' src='/assets/media/avatars/avatar15.jpg' alt=''> </div> </div> <h1 class='h3 text-white font-w700 mb-10'>" + dr["firstname"].ToString() + " " + dr["lastname"].ToString() + "<small class=' text-white'> (" + dr["gender"].ToString() + ") </small></h1> <div class='row'> <div class='col-md-4 col-sm-6'> <h2 class='h5 text-white-op'>DATE OF BIRTH : " + dr["dob"].ToString() + "</h2> </div> <div class='col-md-4 col-sm-6'> <h2 class='h5 text-white-op'>" + dr["city"].ToString() + " <br> Event For : " + eventnames + "</h2> </div> <div class='col-md-4 col-sm-6'> <h2 class='h5 text-white-op'> Status : " + dr["status"].ToString() + "</h2> </div> </div> </div> </div> <div class='row ml-0 mr-0 mt-15 detail_page'> <div class='col-md-6 col-sm-6'> <div class='block block-rounded'> <div class='block-header block-header-default'> <h3 class='block-title'>Personal Info</h3> </div> <div class='block-content'> <p><strong> Email:</strong> " + dr["email"].ToString() + "</br><strong> Contact Number :</strong> " + dr["contactnumber"].ToString() + "</br><strong> Age Group:</strong> " + dr["agegroup"].ToString() + "</br><strong> Time Slots :</strong> " + dr["timeslote"].ToString() + "</br><strong> Session :</strong> " + dr["session"].ToString() + "<br> <strong>How did you hear about us :</strong> " + dr["hearaboutus"].ToString() + "<br> <strong >Which City you are contacting us from : <span class='font-weight-normal'>" + dr["Preferredwaytocontact"].ToString() + "</span></strong> <br> <strong>Comment If Any :</strong> " + dr["commentsifany"].ToString() + "<br><strong >Date Of Registration : <span class='font-weight-normal'>" + dr["date"].ToString() + "</span></strong> <br> <strong>Registred By :</strong> " + dr["Registredby"].ToString() + "</p>  </div> </div> </div> </div> </div>";
                }
                dr.Close();
                cn.Close();
            }
        }
        catch
        {
            Response.Redirect("viewregistration.aspx");

        }
    }
    protected void btnactive_Click(object sender, EventArgs e)
    {
        try
        {
            id = Request.QueryString["id"].ToString();
        }
        catch
        {
            Response.Redirect("viewregistration.aspx");
        }


        cn.Open();
        string emails = bb.getSingleData("select email from event_registration where id=" + id);
        string loginemails = bb.getSingleData("select email from login where email like '" + emails + "'");

        SqlCommand cmd1 = new SqlCommand("update login set status='Active' where email like '" + loginemails + "'", cn);
        cmd1.ExecuteNonQuery();
        cn.Close();
        string name = bb.getSingleData("select firstname+' '+lastname from event_registration where id=" + id);
        Response.Write("<script>alert('" + name + " is Successfully Activated')</script>");
    }
    protected void btninactive_Click(object sender, EventArgs e)
    {
        try
        {
            id = Request.QueryString["id"].ToString();
        }
        catch
        {
            Response.Redirect("viewregistration.aspx");
        }
        cn.Open();

        string emails = bb.getSingleData("select email from event_registration where id=" + id);
        string loginemails = bb.getSingleData("select email from login where email like '" + emails + "'");
        SqlCommand cmd = new SqlCommand("update login set status='InActive' where email like '" + loginemails + "'", cn);
        cmd.ExecuteNonQuery();

        cn.Close();
        string name = bb.getSingleData("select firstname+' '+lastname from event_registration where id=" + id);
        Response.Write("<script>alert('"+name+" is Successfully InActivated')</script>");
    }
}