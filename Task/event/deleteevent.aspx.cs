using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Task_event_deleteevent : System.Web.UI.Page
{
    public string id = "";
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
          
        try
        {
            id = Request.QueryString["id"].ToString();
        }
        catch
        {
            Response.Redirect("viewevent.aspx");
        }
        SqlCommand cnd = new SqlCommand("update event set IsActive='False' where id="+id);
        cmd.ExecuteNonQuery();

        Response.Redirect("viewevent.aspx");
    }
}