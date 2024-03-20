using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Task_attendance_viewattendance : System.Web.UI.Page
{
    public string data = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        data = bb.sqlDisplaytable("select * from attendance");
    }
}