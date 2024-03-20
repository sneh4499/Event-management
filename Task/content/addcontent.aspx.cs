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
public partial class Task_content_addcontent : System.Web.UI.Page
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
        fileupload.Visible = false;
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
         string link = "";
        string check;

        if (rdobtn.SelectedItem.Text == "Link")
        {
            Uri myUri = new Uri(txtlink.Text);
            string param1 = HttpUtility.ParseQueryString(myUri.Query).Get("v");


            link = String.Concat("https://www.youtube.com/embed/",param1);

            check = bb.getSingleData("select * from content where fileurl='" + txtlink.Text + "'");

            if (check == "No Data Found")
            {
                bb.insert("content", txtname.Text, link, ddltype.SelectedItem.Text, DateTime.Now.ToString(), Request.Cookies["email"].Value.ToString());
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblmsg.Text = "<span style='color:red;'>This Link Already Exist in the system.Please Add New One.</span>";
            }
        }
        else
        {
            try
            {

                string file = fuvideo.FileName.Replace(".", System.DateTime.Now.ToString("ddMMyyhhmmss."));

                string Document_Path = Server.MapPath("/media/video/" + Path.GetFileName(file));

                fuvideo.SaveAs(Document_Path);
                if (fuvideo.HasFile)
                {
                    link = "/media/video/" + Path.GetFileName(file);
                    bb.insert("content", txtname.Text, link, ddltype.SelectedItem.Text, DateTime.Now.ToString("dd"), Request.Cookies["email"].Value.ToString());
                    Response.Redirect(Request.RawUrl);
                    
                }
                else { }
            }
            catch
            {
                fileupload.Visible = true;
                lblupload.Text = "<span style='color:red'>Please Upload a Video.</span>";
            }
    }
}
    protected void rdobtn_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rdobtn.SelectedItem.Text == "Link")
        {
            textbox.Visible = true;
            fileupload.Visible = false;
        }
        else
        {
            textbox.Visible = false;
            fileupload.Visible = true;
        }
    }
}
