﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Task_masterform_addtimeslote : System.Web.UI.Page
{
    public string data = "", id;
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    SqlCommand cmd = new SqlCommand();
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
        data = bb.sqlDisplaytable("select id,name as [Time Slote Name] from [timeslotes]", "addtimeslote.aspx?id=", "Edit");

        btnupdate.Visible = false;

        if (!IsPostBack)
        {

            try
            {

                id = Request.QueryString["id"].ToString();
                con.Open();
                if (Request.QueryString["id"].ToString() != null)
                {
                    cmd = new SqlCommand("select * from [timeslotes] where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    txtname.Text = (dr["name"].ToString());

                    dr.Close();
                    con.Close();
                    btnupdate.Visible = true;
                    btnsave.Visible = false;

                }
                else
                {
                    btnupdate.Visible = false;
                    btnsave.Visible = true;

                }


            }
            catch
            {

            }

            return;
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        bb.insert("timeslotes", txtname.Text);
        txtname.Text = "";
        Response.Redirect(Request.RawUrl);
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            id = Request.QueryString["id"].ToString();
        }
        catch
        {

        }
        con.Open();
        SqlCommand cmd = new SqlCommand("update [timeslotes] set name='" + txtname.Text + "' where id=" + id, con);
        cmd.ExecuteNonQuery();

        con.Close();

        Response.Redirect("addtimeslote.aspx");
    }
}