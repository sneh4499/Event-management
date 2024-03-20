using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for bb
/// </summary>
public class bb
{
    public static string role = "", wicon = "";
    public static int checklist = 0;
    public static String[] checklistid = new String[100];
    public static string basepath = "http://localhost:57844/";
    public bb()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string passgen(int length)
    {
        string allowedChars = "1234567890";
        char[] chars = new char[length];
        Random rd = new Random();
        String pass = "";
        for (int i = 0; i < length; i++)
        {
            chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            pass = pass + chars[i];
        }
        return pass;

    }
    public static Boolean checkEmail(string email)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();

        SqlCommand cmd2 = new SqlCommand("select count(*) from login where Email like '" + email + "'", cn);

        int s = int.Parse(cmd2.ExecuteScalar().ToString());
        cn.Close();
        if (s == 0)
        {
            return true;
        }
        else
        {

            return false;
        }

    }
    public static Boolean createUser(string username, string type, string name, string img, string pass = "")
    {
        bool state;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        if (pass == "")
            pass = bb.passgen(5);
        SqlCommand cmd2 = new SqlCommand("select count(*) from login where Username like '" + username + "'", cn);
        int s = int.Parse(cmd2.ExecuteScalar().ToString());
        if (s == 0)
        {
            SqlCommand cmd1 = new SqlCommand("insert into login values('" + name + "','" + username + "','" + pass + "','" + type + "','" + DateTime.Now.ToString() + "','','Online','" + img + "')", cn);
            cmd1.ExecuteNonQuery();
            cn.Close();
            // mail(username, "Thank,you For your Registration On SD ", "We Will Contact You Shortly");
            mail(username, "Thank,you For your Registration On Stream Express Inc. ", "Your username is " + username + "<br>your Password is " + pass + "<br>You can Login by clicking <a href='" + basepath + "log-in.aspx'>HERE</a>");
            state = true;
        }
        else
        {
            state = false;
        }
        return state;
    }
    public static void mail(string mailto, string subject, string msg)
    {
        string mailup = "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8' /> <meta name='viewport' content='width=device-width; initial-scale=1.0; maximum-scale=1.0;'> <title>Email</title> <style type='text/css'> div, p, a, li, td { -webkit-text-size-adjust:none; } *{ -webkit-font-smoothing: antialiased; -moz-osx-font-smoothing: grayscale; } .ReadMsgBody {width: 100%; background-color: #ffffff;} .ExternalClass {width: 100%; background-color: #ffffff;} body{width: 100%; height: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased;} html{width: 100%; background-color: #ffffff;} @font-face {font-family: 'proxima_novalight';src: url('http://rocketway.net/themebuilder/products/font/proximanova-light-webfont.eot');src: url('http://rocketway.net/themebuilder/products/font/proximanova-light-webfont.eot?#iefix') format('embedded-opentype'),url('http://rocketway.net/themebuilder/products/font/proximanova-light-webfont.woff') format('woff'),url('http://rocketway.net/themebuilder/products/font/proximanova-light-webfont.ttf') format('truetype');font-weight: normal;font-style: normal;} @font-face {font-family: 'proxima_nova_rgregular'; src: url('http://rocketway.net/themebuilder/products/font/proximanova-regular-webfont.eot');src: url('http://rocketway.net/themebuilder/products/font/proximanova-regular-webfont.eot?#iefix') format('embedded-opentype'),url('http://rocketway.net/themebuilder/products/font/proximanova-regular-webfont.woff') format('woff'),url('http://rocketway.net/themebuilder/products/font/proximanova-regular-webfont.ttf') format('truetype');font-weight: normal;font-style: normal;} @font-face {font-family: 'proxima_novasemibold';src: url('http://rocketway.net/themebuilder/products/font/proximanova-semibold-webfont.eot');src: url('http://rocketway.net/themebuilder/products/font/proximanova-semibold-webfont.eot?#iefix') format('embedded-opentype'),url('http://rocketway.net/themebuilder/products/font/proximanova-semibold-webfont.woff') format('woff'),url('http://rocketway.net/themebuilder/products/font/proximanova-semibold-webfont.ttf') format('truetype');font-weight: normal;font-style: normal;} @font-face {font-family: 'proxima_nova_rgbold';src: url('http://rocketway.net/themebuilder/products/font/proximanova-bold-webfont.eot');src: url('http://rocketway.net/themebuilder/products/font/proximanova-bold-webfont.eot?#iefix') format('embedded-opentype'),url('http://rocketway.net/themebuilder/products/font/proximanova-bold-webfont.woff') format('woff'),url('http://rocketway.net/themebuilder/products/font/proximanova-bold-webfont.ttf') format('truetype');font-weight: normal;font-style: normal;} @font-face {font-family: 'proxima_novathin';src: url('http://rocketway.net/themebuilder/products/font/proximanova-thin-webfont.eot');src: url('http://rocketway.net/themebuilder/products/font/proximanova-thin-webfont.eot?#iefix') format('embedded-opentype'),url('http://rocketway.net/themebuilder/products/font/proximanova-thin-webfont.woff') format('woff'),url('http://rocketway.net/themebuilder/products/font/proximanova-thin-webfont.ttf') format('truetype');font-weight: normal;font-style: normal;} @font-face {font-family: 'proxima_novaextrabold';src: url('http://rocketway.net/themebuilder/products/font/proximanova-extrabold-webfont.eot');src: url('http://rocketway.net/themebuilder/products/font/proximanova-extrabold-webfont.eot?#iefix') format('embedded-opentype'),url('http://rocketway.net/themebuilder/products/font/proximanova-extrabold-webfont.woff2') format('woff2'),url('http://rocketway.net/themebuilder/products/font/proximanova-extrabold-webfont.woff') format('woff'),url('http://rocketway.net/themebuilder/products/font/proximanova-extrabold-webfont.ttf') format('truetype');font-weight: normal;font-style: normal;} p {padding: 0!important; margin-top: 0!important; margin-right: 0!important; margin-bottom: 0!important; margin-left: 0!important; } .hover:hover {opacity:0.85;filter:alpha(opacity=85);} .image73 img {width: 73px; height: auto;} .image42 img {width: 42px; height: auto;} .image400 img {width: 400px; height: auto;} .icon49 img {width: 49px; height: auto;} .image113 img {width: 113px; height: auto;} .image70 img {width: 70px; height: auto;} .image67 img {width: 67px; height: auto;} .image80 img {width: 80px; height: auto;} .image35 img {width: 35px; height: auto;} .icon49 img {width: 49px; height: auto;} a { color: rgb(255, 255, 255); text-decoration: none; width: 100%;border-top-left-radius: 5px; border-top-right-radius: 5px; border-bottom-right-radius: 5px; border-bottom-left-radius: 5px; padding-left: 25px; padding-right: 25px; font-family: 'Open Sans', Helvetica, Arial, sans-serif; color: rgb(255, 255, 255); font-size: 15px; font-weight: 700; line-height: 1px; background-color: rgb(61, 133, 184);} </style> <style type='text/css'> @media only screen and (max-width: 479px){ body{width:auto!important;} table[class=full] {width: 100%!important; clear: both; } table[class=mobile] {width: 100%!important; padding-left: 30px; padding-right: 30px; clear: both; } table[class=fullCenter] {width: 100%!important; text-align: center!important; clear: both; } td[class=fullCenter] {width: 100%!important; text-align: center!important; clear: both; } *[class=erase] {display: none;} *[class=buttonScale] {float: none!important; text-align: center!important; display: inline-block!important; clear: both;} .image400 img {width: 100%!important; height: auto;} } } </style> </head> <body leftmargin='0' topmargin='0' marginwidth='0' marginheight='0' yahoo='fix'> <div class='ui-sortable' id='sort_them'> <!-- Notification 1 --> <div style='display: none;' id='element_08090038786176592'></div><!-- End Notification 1 --> <!-- Notification 2 --> <div style='display: none;' id='element_09100676192902029'></div><!-- End Notification 2 --> <!-- Notification 3 --> <div style='display: none;' id='element_012434233748354018'></div><!-- End Notification 3 --> <!-- Notification 4 --> <table width='100%' border='0' cellpadding='0' cellspacing='0' align='center' class='full' bgcolor='#69b8f1'style='background-color: rgb(242, 244, 249);'> <tr> <td align='center' style='background-image: url('http://solardoctor.in/email/images/not4_bg_image.jpg'); -webkit-background-size: cover; background-size: cover; background-color: rgb(242, 244, 249); background-position: center center; background-repeat: no-repeat;' id='not4ChangeBG'> <!-- Mobile Wrapper --> <table width='100%' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile'> <tr> <td width='100%' align='center'> <!-- SORTABLE --> <div class='sortable_inner ui-sortable'> <!-- Space --> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='full' object='drag-module-small'> <tr> <td width='100%' height='50'></td> </tr> </table><!-- End Space --> <!-- Space --> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='full' object='drag-module-small'> <tr> <td width='100%' height='50'></td> </tr> </table><!-- End Space --> <!-- Main --> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='full' style='-webkit-border-radius: 6px; -moz-border-radius: 6px; border-radius: 6px;'> <tr> <td width='100%' style='border-top-left-radius: 6px; border-top-right-radius: 6px; border-bottom-right-radius: 6px; border-bottom-left-radius: 6px; background-color: rgb(255, 255, 255);' bgcolor='#ffffff'> <!-- Start Top --> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile' bgcolor='#3d85b8'object='drag-module-small' style='border-top-right-radius: 6px; border-top-left-radius: 6px; background-color: rgb(61, 133, 184);'> <tr> <td width='100%' valign='middle' align='center'> </td> </tr> </table> <!-- Image 113px --> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile' bgcolor='#3d85b8' style='background-color: rgb(61, 133, 184); background-position: 50% 100%; background-repeat: repeat no-repeat;'object='drag-module-small'> <tr> <td width='400' height='15' style='font-size: 1px; line-height: 1px;'>&nbsp;</td> </tr> <tr> <td width='400' valign='middle' style='text-align: center; line-height: 1px;' align='center'> <table width='100' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile'> <tr> <td width='113' height='35' align='center' class='image113'> <p href='#'> </p><p href='#' style='text-decoration: none;'><img src='../../logo.jpg' width='113' alt='Image Not Available' border='0' ></p> </td> </tr> </table> </td> </tr> </table><!-- End Image 113px --> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile' bgcolor='#ffffff'object='drag-module-small' style='background-color: rgb(255, 255, 255);'> <tr> <td width='100%' valign='middle' align='center'> <table width='300' border='0' cellpadding='0' cellspacing='0' align='center' style='text-align: center; border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;' class='fullCenter'> <tr> <td width='400' height='30' style='font-size: 1px; line-height: 1px;'>&nbsp;</td> </tr> <tr> <td valign='middle' width='100%' style='text-align: center; font-family: 'Open Sans', Helvetica, Arial, sans-serif; font-size: 34px; color: rgb(61, 133, 184); line-height: 40px; font-weight: 100;' class='fullCenter' > </td> </tr> </table> </td> </tr> </table> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile' bgcolor='#ffffff'object='drag-module-small' style='background-color: rgb(255, 255, 255);'> <tr> <td width='100%' valign='middle' align='center'> <table width='300' border='0' cellpadding='0' cellspacing='0' align='center' style='text-align: center; border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;' class='fullCenter'> <tr> <td width='100%' height='30' style='font-size: 1px; line-height: 1px;'>&nbsp;</td> </tr> <tr> <td valign='middle' width='100%' style='text-align: center; font-family: 'Open Sans', Helvetica, Arial, sans-serif; font-size: 13px; color: rgb(95, 106, 116); line-height: 24px; font-weight: 400;' class='fullCenter' >";
        string maildown = "</td> </tr> </table> </td> </tr> </table> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile' bgcolor='#ffffff'object='drag-module-small' style='background-color: rgb(255, 255, 255);'> <tr> <td width='100%' valign='middle' align='center'> <table width='300' border='0' cellpadding='0' cellspacing='0' align='center' style='text-align: center; border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;' class='fullCenter'> <tr> <td width='100%' height='35' style='font-size: 1px; line-height: 1px;'>&nbsp;</td> </tr> </table> </td> </tr> </table> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile' bgcolor='#ffffff'object='drag-module-small' style='background-color: rgb(255, 255, 255);'> <tr> <td width='100%' valign='middle' align='center'> <table width='300' border='0' cellpadding='0' cellspacing='0' align='center' style='text-align: center; border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;' class='fullCenter'> <tr> <td width='100%' align='center'> <table border='0' cellpadding='0' cellspacing='0' align='center' class='buttonScale'> <tr> </tr> </table> </td> </tr> </table> </td> </tr> </table> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile' bgcolor='#ffffff'object='drag-module-small' style='background-color: rgb(255, 255, 255);'> <tr> <td width='100%' valign='middle' align='center'> <table width='300' border='0' cellpadding='0' cellspacing='0' align='center' style='text-align: center; border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;' class='fullCenter'> <tr> <td width='100%' height='20' style='font-size: 1px; line-height: 1px;'>&nbsp;</td> </tr> <tr> <td valign='middle' width='100%' style='text-align: center; font-family: 'Open Sans', Helvetica, Arial, sans-serif; font-size: 13px; color: rgb(95, 106, 116); line-height: 24px; font-weight: 400;' class='fullCenter' > <br> For More Info Visit <a href='https://www.streamexpress.ca/' style=''>https://www.streamexpress.ca/</a> <br>Or Call Us On <a href='tel:905-824-5733' style=''>905-824-5733</a> </td> </tr> </table> </td> </tr> </table> <table width='400' border='0' cellpadding='0' cellspacing='0' align='center' class='mobile' bgcolor='#ffffff'object='drag-module-small' style='border-bottom-right-radius: 6px; border-bottom-left-radius: 6px; background-color: rgb(255, 255, 255);'> <tr> <td width='100%' valign='middle' align='center'> <table width='300' border='0' cellpadding='0' cellspacing='0' align='center' style='text-align: center; border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;' class='fullCenter'> <tr> <td width='100%' height='40'></td> </tr> </table> </td> </tr> </table> </td> </tr> </table><!-- End Main --> <!-- CopyRight --> <table width='352' border='0' cellpadding='0' cellspacing='0' align='center' class='full' object='drag-module-small'> <tr> <td width='100%' height='25'></td> </tr> <tr> <td valign='middle' width='100%' style='text-align: center; font-family: 'Open Sans', Helvetica, Arial, sans-serif; color: rgb(255, 255, 255); font-size: 12px; font-weight: 400; line-height: 18px;' class='fullCenter' > <i>Copyright Stream Express Inc. All rights Reversed 2020.</i><br> </td> </tr> </table> <table width='352' border='0' cellpadding='0' cellspacing='0' align='center' class='full' object='drag-module-small'> <tr> <td width='100%' height='20' style='font-size: 1px; line-height: 1px;'>&nbsp;</td> </tr> <tr> <td valign='middle' width='100%' style='text-align: center; font-family: 'Open Sans', Helvetica, Arial, sans-serif; color: rgb(255, 255, 255); font-size: 12px; font-weight: 400; line-height: 18px;' class='fullCenter'> <!--subscribe--><a href='#' style='color: rgb(255, 255, 255);'>Unsubscribe</a><!--unsub--> </td> </tr> </table> <table width='352' border='0' cellpadding='0' cellspacing='0' align='center' class='full' object='drag-module-small'> <tr> <td width='100%' height='60' style='font-size: 1px; line-height: 1px;'>&nbsp;</td> </tr> <tr> <td width='100%' height='1' style='font-size: 1px; line-height: 1px;'>&nbsp;</td> </tr> </table><!-- End CopyRight --> </div> </td> </tr> </table> </div> </td> </tr> </table><!-- End Notification 4 --> <!-- Notification 5 --> <div style='display: none' id='element_0510475987335667'></div><!-- End Notification 5 --> <!-- Notification 6 --> <div style='display: none' id='element_05366499796509743'></div><!-- End Notification 6 --> </div> </body> <style>body{ background: none !important; } </style> <script async src='https://www.googletagmanager.com/gtag/js?id=UA-139142456-1'></script> <script> window.dataLayer = window.dataLayer || []; function gtag(){dataLayer.push(arguments);} gtag('js', new Date()); gtag('config', 'UA-139142456-1'); </script>";
        string email = mailto;
        MailMessage mailObj = new MailMessage("admin@admin.com", email, subject, mailup + msg + maildown);
        SmtpClient SMTPServer = new SmtpClient("smtp.zoho.com");
        SMTPServer.DeliveryMethod = SmtpDeliveryMethod.Network;
        SMTPServer.EnableSsl = true;

        SMTPServer.Port = 587;

        SMTPServer.UseDefaultCredentials = false;

        mailObj.IsBodyHtml = true;
        SMTPServer.Credentials = new System.Net.NetworkCredential("admin@admin.com", "Password");

        SMTPServer.Send(mailObj);
    }
    public static string sqlDisplaytable(string query, string link = "", string btntext = "View More", string link2 = "", string btn2txt = "", string link3 = "", string btn3txt = "")
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        int c = 0;
        if (1 == 1)
        {

            //tabel start
            data = "<table class='table table-bordered table-striped table-vcenter js-dataTable-full'>";
            //genrating Tabel Headers
            data = data + " <thead > <tr >";
            for (int i = 0; i < dr.FieldCount; i++)
            {
                data = data + "<th>" + dr.GetName(i) + "</th>";
            }
            if (link != "")
                data = data + "<th>" + btntext + "</th>";
            if (link2 != "")
                data = data + "<th>" + btn2txt + "</th>";
            if (link3 != "")
                data = data + "<th>" + btn3txt + "</th>";

            data = data + "</tr></thead>";
            //Genrating Data
            data = data + "<tbody>";
            string sold = "", snew = "default";
            while (dr.Read())
            {
                c++;
                if (sold != "")
                {
                    data = data + "<tr class='" + sold + "'>";
                }
                else
                    data = data + "<tr>";
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    string s = "";
                    if (dr.GetName(i).ToString() == "status")
                    {


                        if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Pending")
                            s = "warning";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "In Progress" || dr[dr.GetName(i).ToString()].ToString().Trim() == "In Process")
                            s = "primary";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Completed")
                            s = "success";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Assigned")
                            s = "info";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "On The Way")
                            s = "warning";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Decline")
                            s = "danger";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Finished")
                            s = "success";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Active" || dr[dr.GetName(i).ToString()].ToString().Trim() == "Approved")
                            s = "success";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Inactive" || dr[dr.GetName(i).ToString()].ToString().Trim() == "Declined")
                            s = "default";


                        data = data + "<td> <span class='badge badge-" + s + "'>" + dr[dr.GetName(i).ToString()].ToString() + "</span></td>";
                        //     sold = snew;
                        //   snew = s;
                    }
                    else if (dr.GetName(i).ToString() == "Filepath")
                    {
                        if (dr[dr.GetName(i).ToString()].ToString().Length > 2)
                        {
                            data = data + "<td><a href='" + dr[dr.GetName(i).ToString()].ToString() + "'><i class='fa fa-download'></i> </a></td>";
                        }
                        else
                        {
                            data = data + "<td></td>";
                        }
                    }
                    else if (dr.GetName(i).ToString() == "assignedemps")
                    {
                        data = data + "<td>" + genrateemployeenames(dr[dr.GetName(i).ToString()].ToString()) + "</td>";
                    }
                    else if (dr.GetName(i).ToString() == "Cost")
                    {
                        data = data + "<td> ₹ " + dr[dr.GetName(i).ToString()].ToString() + "</td>";
                    }
                    else
                    {
                        data = data + "<td>" + dr[dr.GetName(i).ToString()].ToString() + "</td>";
                    }
                }
                if (link != "")
                    data = data + "<td><a class='btn btn-alt-primary' href='" + link + "" + dr[dr.GetName(0).ToString()].ToString() + "'> " + btntext + "</a></td>";
                if (link2 != "")
                    data = data + "<td><a class='btn btn-alt-success' href='" + link2 + "" + dr[dr.GetName(0).ToString()].ToString() + "'> " + btn2txt + "</a></td>";
                if (link3 != "")
                    data = data + "<td><a class='btn btn-alt-danger' href='" + link3 + "" + dr[dr.GetName(0).ToString()].ToString() + "'> " + btn3txt + "</a></td> ";
                data = data + "</tr>";
            }
            data = data + "</tbody>";
            //tabel end
            data = data + " </table>";
            dr.Close();


        }
        if (c == 0)
        {
            data = "<br/><h4 style='text-align: center;'>No Data Found !</h4>";
        }

        cn.Close();


        return data;
    }
    public static void sms(string mobno, string msg)
    {
        HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("");

        HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();

        System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());

        string responseString = respStreamReader.ReadToEnd();

        respStreamReader.Close();

        myResp.Close();
    }
    public static Boolean forgetpass(string email)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string pass = bb.passgen(8);
        SqlCommand cmd2 = new SqlCommand("select * from login where email like '" + email + "'", cn);
        SqlCommand cmdupdatepas = new SqlCommand("update login set password='" + pass + "' where email like '" + email + "'", cn);
        //SqlCommand cmdupdatepas1 = new SqlCommand("update registrations set password='" + pass + "' where email like '" + email + "'", cn);

        try
        {
            cmdupdatepas.ExecuteNonQuery();
            //cmdupdatepas1.ExecuteNonQuery();
            mail(email, "Your Password Has been Updated.", "Your new Password is " + pass);
        }
        catch
        {

            return false;
        }

        cn.Close();
        return true;
    }
    public static string search(string keyword)
    {
        string results = "";
        results = results + "<h1>'" + keyword + "' in Users</h1></br>" + sqlDisplaytable("select * from login where username like '%" + keyword + "%'");
        results = results + "<h1>'" + keyword + "' In Check In Check Out</h1></br>" + sqlDisplaytable("select * from checkinout where checkin+checkout+description+lat+long+eid+sid like '%" + keyword + "%'");
        results = results + "<h1>'" + keyword + "' In Employee</h1></br>" + sqlDisplaytable("select * from employee where fname+lname+department+designation+address+city+state+email+mobileno+emergencyno+bloodgroup+gender like '%" + keyword + "%'");
        results = results + "<h1>'" + keyword + "' In Schedule</h1></br>" + sqlDisplaytable("select * from schedule where Jobcode+sitename+workname+location+assignedemps+teamleader+remark+uploadby+status like '%" + keyword + "%'");
        results = results + "<h1>'" + keyword + "' In Customer</h1></br>" + sqlDisplaytable("select * from site where sitename+location+contactperson+mobileno+longitude+latitude like '%" + keyword + "%'");
        results = results + "<h1>'" + keyword + "' in Job Master</h1></br>" + sqlDisplaytable("select * from work where workname+sitename+worklocation+workpriority+assignemp+description+Status like '%" + keyword + "%'");

        return results;

    }
    public static Boolean insert(params string[] args)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string qry = "insert into " + args[0] + " values('" + args[1] + "'";
        for (int i = 2; i <= args.Length - 1; i++)
        {
            qry = qry + ",'" + args[i] + "'";
        }
        qry = qry + ");";
        SqlCommand cmd = new SqlCommand(qry, cn);
        cmd.ExecuteNonQuery();
        cn.Close();
        cn.Dispose();
        return true;
    }

    private static String ones(String Number)
    {
        int _Number = Convert.ToInt32(Number);
        String name = "";
        switch (_Number)
        {

            case 1:
                name = "One";
                break;
            case 2:
                name = "Two";
                break;
            case 3:
                name = "Three";
                break;
            case 4:
                name = "Four";
                break;
            case 5:
                name = "Five";
                break;
            case 6:
                name = "Six";
                break;
            case 7:
                name = "Seven";
                break;
            case 8:
                name = "Eight";
                break;
            case 9:
                name = "Nine";
                break;
        }
        return name;
    }
    private static String tens(String Number)
    {
        int _Number = Convert.ToInt32(Number);
        String name = null;
        switch (_Number)
        {
            case 10:
                name = "Ten";
                break;
            case 11:
                name = "Eleven";
                break;
            case 12:
                name = "Twelve";
                break;
            case 13:
                name = "Thirteen";
                break;
            case 14:
                name = "Fourteen";
                break;
            case 15:
                name = "Fifteen";
                break;
            case 16:
                name = "Sixteen";
                break;
            case 17:
                name = "Seventeen";
                break;
            case 18:
                name = "Eighteen";
                break;
            case 19:
                name = "Nineteen";
                break;
            case 20:
                name = "Twenty";
                break;
            case 30:
                name = "Thirty";
                break;
            case 40:
                name = "Fourty";
                break;
            case 50:
                name = "Fifty";
                break;
            case 60:
                name = "Sixty";
                break;
            case 70:
                name = "Seventy";
                break;
            case 80:
                name = "Eighty";
                break;
            case 90:
                name = "Ninety";
                break;
            default:
                if (_Number > 0)
                {
                    name = tens(Number.Substring(0, 1) + "0") + " " + ones(Number.Substring(1));
                }
                break;
        }
        return name;
    }

    private static String ConvertWholeNumber(String Number)
    {
        string word = "";
        try
        {
            bool beginsZero = false;//tests for 0XX  
            bool isDone = false;//test if already translated  
            double dblAmt = (Convert.ToDouble(Number));
            //if ((dblAmt > 0) && number.StartsWith("0"))  
            if (dblAmt > 0)
            {//test for zero or digit zero in a nuemric  
                beginsZero = Number.StartsWith("0");

                int numDigits = Number.Length;
                int pos = 0;//store digit grouping  
                String place = "";//digit grouping name:hundres,thousand,etc...  
                switch (numDigits)
                {
                    case 1://ones' range  

                        word = ones(Number);
                        isDone = true;
                        break;
                    case 2://tens' range  
                        word = tens(Number);
                        isDone = true;
                        break;
                    case 3://hundreds' range  
                        pos = (numDigits % 3) + 1;
                        place = " Hundred ";
                        break;
                    case 4://thousands' range  
                    case 5:
                    case 6:
                        pos = (numDigits % 4) + 1;
                        place = " Thousand ";
                        break;
                    case 7://millions' range  
                    case 8:
                    case 9:
                        pos = (numDigits % 7) + 1;
                        place = " Million ";
                        break;
                    case 10://Billions's range  
                    case 11:
                    case 12:

                        pos = (numDigits % 10) + 1;
                        place = " Billion ";
                        break;
                    //add extra case options for anything above Billion...  
                    default:
                        isDone = true;
                        break;
                }
                if (!isDone)
                {//if transalation is not done, continue...(Recursion comes in now!!)  
                    if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                    {
                        try
                        {
                            word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));
                        }
                        catch { }
                    }
                    else
                    {
                        word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));
                    }

                    //check for trailing zeros  
                    //if (beginsZero) word = " and " + word.Trim();  
                }
                //ignore digit grouping names  
                if (word.Trim().Equals(place.Trim())) word = "";
            }
        }
        catch { }
        return word.Trim();
    }

    public static String ConvertToWords(String numb)
    {
        String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";
        String endStr = "Only";
        try
        {
            int decimalPlace = numb.IndexOf(".");
            if (decimalPlace > 0)
            {
                wholeNo = numb.Substring(0, decimalPlace);
                points = numb.Substring(decimalPlace + 1);
                if (Convert.ToInt32(points) > 0)
                {
                    andStr = "and";// just to separate whole numbers from points/cents  
                    endStr = "Paisa " + endStr;//Cents  
                    pointStr = ConvertDecimals(points);
                }
            }
            val = String.Format("{0} {1}{2} {3}", ConvertWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);
        }
        catch { }
        return val;
    }

    private static String ConvertDecimals(String number)
    {
        String cd = "", digit = "", engOne = "";
        for (int i = 0; i < number.Length; i++)
        {
            digit = number[i].ToString();
            if (digit.Equals("0"))
            {
                engOne = "Zero";
            }
            else
            {
                engOne = ones(digit);
            }
            cd += " " + engOne;
        }
        return cd;
    }

    public static Boolean autheticateUser(string id, string pass)
    {
        Boolean f;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string r = "";
        SqlCommand cmd = new SqlCommand("select role from login where email like '" + id + "' AND Password like '" + pass + "';", cn);
        //SqlCommand cmd1 = new SqlCommand("Update login set Lastlogin='" + DateTime.Now.ToString() + "', status='Online' where Username like '" + id + "'", cn);

        //            SqlCommand cmd2 = new SqlCommand("select User_Image from Employee where Email like '" + txtlusername.Text + "' AND Password like '" + txtlpassword.Text + "';", cn);
        //          SqlCommand cmd3 = new SqlCommand("select City from Employee where Email like '" + txtlusername.Text + "' AND Password like '" + txtlpassword.Text + "';", cn);

        //  SqlDataReader dr;
        // dr = cmd.ExecuteReader();
        try
        {
            r = cmd.ExecuteScalar().ToString();
        }
        catch
        {
            r = "";
        }
        //    if(dr.Read())
        //    {
        //        string script = "<script type = 'text/javascript'>alert('Login Sucessfully');</script>";

        //    }
        //else
        //    {
        //        string script = "<script type = 'text/javascript'>alert('Username Or Password Incorrect');</script>";
        //    }
        //    dr.Close();



        if (r == "")
        {
            f = false;
        }
        else
        {
            f = true;
            role = r;
            //cmd1.ExecuteNonQuery();

        }

        try
        {

        }
        catch (Exception ex)
        {
            f = false;
        }

        cn.Close();
        cn.Dispose();

        return f;

    }
    public static string sqlDisplayDetails(string query, string link = "", string btntext = "View More")
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        int c = -1, r = 0;
        if (1 == 1)
        {

            //Data start
            data = "<div class='row'>";

            //Genrating Data

            while (dr.Read())
            {
                //counter for 6 data

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    if (r == 3)
                    {
                        data = data + "</div><div class='row'>";
                        r = 0;
                    }
                    if (c == 7 || c == -1)
                    {
                        data = data + "<div class='col-md-4'>";
                        c = 0;
                        r++;
                    }

                    string s = "";
                    if (dr.GetName(i).ToString() == "status")
                    {


                        if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Pending" || dr[dr.GetName(i).ToString()].ToString().Trim() == "Assigned")
                            s = "default";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "In Process")
                            s = "primary";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Completed")
                            s = "info";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Revison")
                            s = "warning";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Decline")
                            s = "danger";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Finished")
                            s = "success";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Active")
                            s = "success";
                        else if (dr[dr.GetName(i).ToString()].ToString().Trim() == "Inactive")
                            s = "default";


                        data = data + "<strong>" + dr.GetName(i).ToString() + " : </strong><span class='label label-" + s + "'>" + dr[dr.GetName(i).ToString()].ToString() + "</span><br/><br/>";
                        //     sold = snew;
                        //   snew = s;
                    }
                    else
                    {
                        data = data + "<strong>" + dr.GetName(i).ToString() + " : </strong>" + dr[dr.GetName(i).ToString()].ToString() + "<br/><br/>";
                    }
                    if (c == 6)
                    {
                        data = data + "</div>";
                    }
                    c++;
                }
                if (link != "")
                    data = data + "<a class='btn btn-primary' href='" + link + "" + dr[dr.GetName(0).ToString()].ToString() + "'> " + btntext + "</a><br/><br/>";



            }

            //tabel end
            data = data + " </div></div>";
            dr.Close();

            cn.Close();

            return data;
        }
        else
        {
            data = "<h2>No Data Found</h2>";
            return data;
        }
    }
    public static void update(string tabelname, string columnname, string value, string id, string idvalue)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "Update " + tabelname + " set " + columnname + "='" + value + "' where " + id + "=" + idvalue;

        SqlCommand cmd = new SqlCommand(data, cn);
        cmd.ExecuteNonQuery();
        cn.Close();
        cn.Dispose();
    }
    public static string timelinegen(string query)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";
        SqlCommand cmd = new SqlCommand(query, cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        data = "<div class='activity-block'><ul class='tmtimeline'>";
        while (dr.Read())
        {

            data = data + "<li><time class='tmtime' datetime='" + dr["Completeddatetime"].ToString() + "'><span>" + DateTime.Parse(dr["Completeddatetime"].ToString()).ToShortDateString() + "</span><span>" + DateTime.Parse(dr["Completeddatetime"].ToString()).ToShortTimeString() + "</span></time>";
            if (dr["Status"].ToString() == "Completed")
            {
                data = data + "<div class='tmicon bg-green fa-check'></div>";
            }
            else if (dr["Status"].ToString() == "Ongoing")
            {
                data = data + "<div class='tmicon bg-yellow fa-gear'></div>";
            }
            else
            {
                data = data + "<div class='tmicon bg-red fa-times'></div>";
            }
            data = data + " <div class='tmlabel'> <h2>" + dr["Taskname"].ToString() + "</h2><p>" + dr["Remarks"].ToString() + "</p></div></li>";
        }
        data = data + "</ul></div>";
        dr.Close();
        cn.Close();
        return data;
    }

    public static string RelativeDate(DateTime theDate)
    {
        Dictionary<long, string> thresholds = new Dictionary<long, string>();
        int minute = 60;
        int hour = 60 * minute;
        int day = 24 * hour;
        thresholds.Add(60, "{0} seconds ago");
        thresholds.Add(minute * 2, "a minute ago");
        thresholds.Add(45 * minute, "{0} minutes ago");
        thresholds.Add(120 * minute, "an hour ago");
        thresholds.Add(day, "{0} hours ago");
        thresholds.Add(day * 2, "yesterday");
        thresholds.Add(day * 30, "{0} days ago");
        thresholds.Add(day * 365, "{0} months ago");
        thresholds.Add(long.MaxValue, "{0} years ago");
        long since = (DateTime.Now.Ticks - theDate.Ticks) / 10000000;
        foreach (long threshold in thresholds.Keys)
        {
            if (since < threshold)
            {
                TimeSpan t = new TimeSpan((DateTime.Now.Ticks - theDate.Ticks));
                return string.Format(thresholds[threshold], (t.Days > 365 ? t.Days / 365 : (t.Days > 0 ? t.Days : (t.Hours > 0 ? t.Hours : (t.Minutes > 0 ? t.Minutes : (t.Seconds > 0 ? t.Seconds : 0))))).ToString());
            }
        }
        return "";
    }
    public static String fetchConversion(string senderid, string receiverid, string senderimg)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";

        SqlCommand cmd = new SqlCommand("select * from messages where (Senderid like '" + senderid + "' AND Receivedid like '" + receiverid + "') OR (Senderid like '" + receiverid + "' AND Receivedid like '" + senderid + "') order by date desc", cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        data = "<div class='chat-messages chat-messages-with-sidebar'><ul>";
        while (dr.Read())
        {
            //sender's messages
            if (dr["Senderid"].ToString() == senderid)
            {
                data = data + " <li class='right clearfix'><span class='user-img pull-right'> <img src='" + senderimg + "' alt='User Avatar' class='img-circle' /> </span>  <div class='chat-body clearfix'> <div class='header'> <span class='name'>" + senderid + "</span> <span class='badge'><i class='fa fa-clock-o'></i>" + RelativeDate(DateTime.Parse(dr["Date"].ToString())) + "</span> </div><p>" + dr["message"].ToString() + "  </p>  </div> </li>";

            }
            //recivers message
            else
            {
                data = data + " <li class='left clearfix'><span class='user-img pull-left'> <img src='/assest/images.png' alt='User Avatar' class='img-circle' /> </span>  <div class='chat-body clearfix'> <div class='header'> <span class='name'>" + receiverid + "</span> <span class='badge'><i class='fa fa-clock-o'></i>" + RelativeDate(DateTime.Parse(dr["Date"].ToString())) + "</span> </div><p>" + dr["message"].ToString() + "  </p>  </div> </li>";

            }
            //recivers messages
        }
        data = data + "</ul></div>";
        dr.Close();
        cn.Close();
        return data;
    }
    public static string onlineusers(string senderid)
    {
        string data = "";
        data = "<nav class='chat-users-menu'> <div class='nano'> <div class='nano-content'> <div class='menu-header'><a class='btn btn-default chat-toggler'><i class='fa fa-user'></i> <i class='fa fa-arrow-down'></i></a></div> <ul>";
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();


        SqlCommand cmd = new SqlCommand("select * from login l inner join(select DISTINCT Receivedid from messages m where Senderid like '" + senderid + "') m on m.Receivedid like l.Username ", cn);

        SqlCommand cmd1 = new SqlCommand("select * from messages m,login l where m.Senderid like '" + senderid + "' AND m.Receivedid like l.Username group by l.Username group by l.Username order by date desc ", cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        // data=data+"<div class='chat-messages chat-messages-with-sidebar'><ul class='inbox-dropdown'>";
        while (dr.Read())
        {
            data = data + "<li><a href='message.aspx?recipent=" + dr["Receivedid"].ToString() + "'><span class='chat-name'>" + dr["Name"].ToString() + "</span><span class='user-img'><img src='" + dr["img"].ToString() + "' alt='User'/></span><span class='label label-success'>" + dr["status"].ToString() + "</span></a></li>";

        }
        dr.Close();
        cn.Close();
        data = data + "</ul></div> </div> </nav>";
        return data;

    }
    public static void sendmsg(string senderid, string reciverid, string msg)
    {

        bb.insert("messages", DateTime.Now.ToString(), msg, senderid, reciverid, "1", "0");

    }
    public static string getUserimg(string username)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();

        cn.Open();
        string data = "";

        SqlCommand cmd = new SqlCommand("select photo from login where Username like '" + username + "'", cn);
        data = cmd.ExecuteScalar().ToString();
        cn.Close();

        return data;
    }
    public static string getUsername(string username)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";

        SqlCommand cmd = new SqlCommand("select Name from login where Username like '" + username + "'", cn);
        data = cmd.ExecuteScalar().ToString();
        cn.Close();

        return data;
    }
    public static string getUseronlinestatus(string username)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";

        SqlCommand cmd = new SqlCommand("select status from login where Username like '" + username + "'", cn);
        data = cmd.ExecuteScalar().ToString();
        cn.Close();

        return data;
    }
    public static string getUserlastlogin(string username)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";

        SqlCommand cmd = new SqlCommand("select Lastlogin from login where Username like '" + username + "'", cn);
        data = cmd.ExecuteScalar().ToString();
        cn.Close();

        return data;
    }
    public static string getUsertype(string username)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        string data = "";

        SqlCommand cmd = new SqlCommand("select img from login where Username like '" + username + "'", cn);
        data = cmd.ExecuteScalar().ToString();
        cn.Close();

        return data;
    }
    public static string getSingleData(string query)
    {
        string data = "";

        try
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Open();

            SqlCommand cmd = new SqlCommand(query, cn);
            data = cmd.ExecuteScalar().ToString();
            cn.Close();
            cn.Dispose();
        }
        catch
        {
            data = "No Data Found";
        }

        return data;
    }
    public static string GenrateCalenderEvents(string userid)
    {
        string data = "", date = "";
        int i = 0;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        if (cn.State == ConnectionState.Open)
            cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("select * from calenders where userid like '" + userid + "'", cn);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            date = dr["date"].ToString();
            DateTime d, e;
            d = DateTime.Parse(date);
            try
            {
                e = DateTime.Parse(dr["enddate"].ToString());
            }
            catch
            {
                e = d;
            }
            string status, color;
            try
            {
                status = bb.getSingleData("select status from orders where id=" + dr["taskid"].ToString());

                if (status == "Pending")
                    color = "#ffca28";
                else if (status == "Ongoing" || status == "In Process")
                    color = "#3f9ce8";
                else if (status == "Completed")
                    color = "#9ccc65";
                else
                {
                    color = "#ffca28";
                }

            }
            catch
            {
                color = "#ffca28";
            }

            //, url:'"+ basepath+"/Task/"+dr["taskname"].ToString()+dr["taskid"].ToString()+"'
            if (i == 0)
            {

                data = "{title:'" + dr["text"].ToString() + "',start:'" + d.ToString("yyyy-MM-ddTHH:mm:sszzz") + "',end:'" + e.ToString("yyyy-MM-ddTHH:mm:sszzz") + "',color:'" + color + "',backgroundColor:'" + color + "', url:'" + basepath + "/Task/superadmintasks/orderdetail.aspx?id=" + dr["taskid"].ToString() + "'}";
            }
            else
            {
                data = data + ",{title:'" + dr["text"].ToString() + "',start:'" + d.ToString("yyyy-MM-ddTHH:mm:sszzz") + "',end:'" + e.ToString("yyyy-MM-ddTHH:mm:sszzz") + "',color:'" + color + "',backgroundColor:'" + color + "',url:'" + basepath + "/Task/superadmintasks/orderdetail.aspx?id=" + dr["taskid"].ToString() + "'}";
            }
            i++;
        }
        cn.Close();

        return data;

    }
    public static void AddCalenderEvent(string text, string task, string date, string userid, string taskid)
    {
        insert("calenders", text, task, date, userid, taskid);
    }
    public static string GetWeatherInfo(String city)
    {
        string temp;
        string appId = "7cfc75e36129d47d7edb2e0833c96042";
        //string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", city, appId);
        string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=anand&APPID=7cfc75e36129d47d7edb2e0833c96042", city);

        using (WebClient client = new WebClient())
        {
            string json = client.DownloadString(url);

            WeatherInfo weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);
            //    lblCity_Country.Text = weatherInfo.city.name + "," + weatherInfo.city.country;
            //  imgCountryFlag.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.city.country.ToLower());
            //lblDescription.Text = weatherInfo.list[0].weather[0].description;
            wicon = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.weather[0].icon);
            //lblTempMin.Text = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.min, 1));
            //lblTempMax.Text = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.max, 1));
            temp = (weatherInfo.main.temp - 273.15).ToString();
            //lblTempNight.Text = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.night, 1));
            //lblHumidity.Text = weatherInfo.list[0].humidity.ToString();
            //tblWeather.Visible = true;

        }
        return temp;
    }
    public static string genratemap(string query)
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        if (cn.State == ConnectionState.Open)
            cn.Close();
        SqlCommand cmd = new SqlCommand(query, cn);

        cn.Open();
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        int i = 0;
        string locationheader = "", locationdetials = "";
        string map = "";
        while (dr.Read())
        {
            locationheader = locationheader + "var emp" + i.ToString() + " = { lat: " + dr["lat"].ToString() + ", lng:" + dr["long"].ToString() + " };";
            locationdetials = locationdetials + "var marker = new google.maps.Marker({ position: emp" + i.ToString() + ", map: map, title: '" + dr["eid"].ToString() + " " + dr["date"].ToString() + "' });";
            i++;
        }
        cn.Close();
        map = "<script> function initMap() { \n var emp = { lat: 22.297671, lng: 73.138989 };" + locationheader + " \n var map = new google.maps.Map( document.getElementById('map'), { zoom: 4, center: emp }); \n" + locationdetials + "\n } </script><script async defer src='https://maps.googleapis.com/maps/api/js?key=AIzaSyB414ZpLHZ99emQaQUrharVRj26uWBqlqA&callback=initMap'> </script>";
        return map;

    }
    public static string genratemapwithpath(String query)
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        if (cn.State == ConnectionState.Open)
            cn.Close();
        SqlCommand cmd = new SqlCommand(query, cn);
        cn.Open();
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        int i = 0;
        string locationheader = "";
        string map = "";
        while (dr.Read())
        {
            locationheader = locationheader + "{ lat: " + dr["lat"].ToString() + ", lng:" + dr["long"].ToString() + " },";
            i++;
        }
        try
        {
            locationheader = locationheader.Substring(0, locationheader.Length - 1);
        }
        catch
        {

        }
        cn.Close();
        map = "<script> function initMap() {\n var emp = { lat: 22.297671, lng: 73.138989 }; \n var map = new google.maps.Map(document.getElementById('map'), { zoom: 4, center: emp });var flightPlanCoordinates = [" + locationheader + " ];\n var flightPath = new google.maps.Polyline({ path: flightPlanCoordinates, geodesic: true, strokeColor: '#FF0000', strokeOpacity: 1.0, strokeWeight: 2 }); flightPath.setMap(map); } </script><script async defer src='https://maps.googleapis.com/maps/api/js?key=AIzaSyB414ZpLHZ99emQaQUrharVRj26uWBqlqA&callback=initMap'> </script>";

        return map;
    }
    public static string genrateemployeelist(string jobs, string sid = "")
    {
        string seduleempname;
        if (sid != "")
            seduleempname = bb.getSingleData("select assignedemps from schedule where id=" + sid);

        else
            seduleempname = bb.getSingleData("select assignedemps from schedule where jobcode like '" + jobs + "'");

        string name = seduleempname;
        string[] emp = new string[100];
        int i = 0;
        string cname = "";

        int n;
        try
        {
            if (sid != "")
                n = Int32.Parse(bb.getSingleData("select (LEN(assignedemps)- LEN(REPLACE(assignedemps, ',', '')))+1 from schedule where id=" + sid));

            else
                n = Int32.Parse(bb.getSingleData("select (LEN(assignedemps)- LEN(REPLACE(assignedemps, ',', '')))+1 from schedule where jobcode like '" + jobs + "'"));
        }
        catch
        {
            n = 0;
        }

        while (i < n)
        {

            try
            {
                emp[i] = seduleempname.Substring(0, seduleempname.IndexOf(","));
                seduleempname = seduleempname.Substring(seduleempname.IndexOf(",") + 1);
                emp[i] = bb.getSingleData("select fname+' '+lname from employee where id=" + emp[i]);
            }
            catch
            {
                emp[i] = seduleempname;
                emp[i] = bb.getSingleData("select fname+' '+lname from employee where id=" + emp[i]);
            }
            cname = cname + emp[i] + ",";
            i++;
        }
        try
        {
            cname = cname.Substring(0, cname.Length - 1);
        }
        catch
        {
            cname = "";
        }

        return cname;
    }
    public static string genrateemployeenames(string seduleempname)
    {

        string name = seduleempname;
        string[] emp = new string[100];
        int i = 0;
        string cname = "";
        string data = "";
        int n;
        try
        {
            n = seduleempname.Split(',').Length + 1;
        }
        catch
        {
            n = 1;
        }
        while (i < n)
        {
            try
            {
                emp[i] = seduleempname.Substring(0, seduleempname.IndexOf(","));
                seduleempname = seduleempname.Substring(seduleempname.IndexOf(",") + 1);
                emp[i] = bb.getSingleData("select fname+' '+lname from employee where id=" + emp[i]);


            }
            catch
            {
                emp[i] = seduleempname;
                seduleempname = seduleempname.Substring(seduleempname.IndexOf(",") + 1);
                emp[i] = bb.getSingleData("select fname+' '+lname from employee where id=" + emp[i]);

            }
            cname = cname + emp[i] + ",";
            i++;
        }
        return cname + " " + n;

    }
    public static string genratedata(string seduleempname, string tablename, string colunmname)
    {

        string name = seduleempname;
        string[] emp = new string[100];
        int i = 0;
        string cname = "";
        string data = "";
        int n;
        try
        {
            n = seduleempname.Split(',').Length + 1;
        }
        catch
        {
            n = 1;
        }
        while (i < n - 1)
        {
            try
            {
                emp[i] = seduleempname.Substring(0, seduleempname.IndexOf(","));
                emp[i] = bb.getSingleData("select " + colunmname + " from " + tablename + " where id=" + emp[i]);
                seduleempname = seduleempname.Substring(seduleempname.IndexOf(",") + 1);

            }
            catch
            {
                emp[i] = seduleempname;
                emp[i] = bb.getSingleData("select " + colunmname + " from " + tablename + " where id=" + emp[i]);

            }
            cname = cname + emp[i] + ",";

            i++;
        }
        cname = cname.Substring(0, cname.Length - 1);
        return cname;

    }
    public static string genrateemployeethumb(string jobs)
    {

        string seduleempname = bb.getSingleData("select assignedemps from schedule where id=" + jobs);
        string name = seduleempname;
        string[] emp = new string[100];
        int i = 0;
        string cname = "";
        string data = "";
        data = "<ul class='nav-users push'>";
        string team = bb.getSingleData("select teamleader from schedule where id=" + jobs);
        data = data + "<li><a href='" + basepath + "task/employee/details.aspx?id=" + bb.getSingleData("select teamleader from schedule where id=" + jobs) + "'> <img class='img-avatar img-avatar-thumb' src='" + bb.getSingleData("select photo from employee where id=" + team) + "' alt=''>" + bb.getSingleData("select fname+' '+lname from employee where id=" + team) + " &nbsp &nbsp <span class='badge badge-pill badge-danger'>Team Leader</span></a> </li>";
        int n;
        try
        {
            n = Int32.Parse(bb.getSingleData("select (LEN(assignedemps)- LEN(REPLACE(assignedemps, ',', '')))+1 from schedule where id=" + jobs));
        }
        catch
        {
            n = 0;
        }

        while (i < n)
        {
            string img = "", id = "";
            try
            {
                emp[i] = seduleempname.Substring(0, seduleempname.IndexOf(","));
                seduleempname = seduleempname.Substring(seduleempname.IndexOf(",") + 1);
                img = bb.getSingleData("select photo from employee where id=" + emp[i]);
                id = emp[i];
                emp[i] = bb.getSingleData("select fname+' '+lname from employee where id=" + emp[i]);

            }
            catch
            {
                emp[i] = seduleempname;
                img = bb.getSingleData("select photo from employee where id=" + emp[i]);
                id = emp[i];
                emp[i] = bb.getSingleData("select fname+' '+lname from employee where id=" + emp[i]);

            }
            if (id != team)
            {
                data = data + "<li><a href='" + basepath + "task/employee/details.aspx?id=" + id + "'> <img class='img-avatar img-avatar-thumb' src='" + img + "' alt=''>" + emp[i] + "</a> </li> ";
            }
            cname = cname + emp[i] + ",";
            i++;
        }
        data = data + "</ul>";
        try
        {
            cname = cname.Substring(0, cname.Length - 1);
        }
        catch
        {
            cname = "";
        }

        return data;
    }



    public static string browsernotification(string heading, string text, string img = "https://i.pinimg.com/originals/a6/0a/bc/a60abcad4488f05309e4d5b2405d8ec9.gif", string link = "https://www.google.com", String count = "")
    {
        string data = "";

        //string script = "window.onload = function() { notifyMe(); };";

        data = "function notifyMe" + count + "() { if (!('Notification' in window)) { alert('This browser does not support desktop notification'); } else if (Notification.permission === 'granted') { var options = { body: '" + text + "', icon:'" + img + "', dir:'" + link + "' };playSound(); var notification = new Notification('" + heading + "', options); } else if (Notification.permission !== 'denied') { Notification.requestPermission(function (permission) { if (!('permission' in Notification)) { Notification.permission = permission; } if (permission === 'granted') { var options = { body: '" + text + "', icon: '" + img + "', dir: '" + link + "' };playSound(); var notification = new Notification('" + heading + "', options); } }); }  notification.onclick = function() { window.open('" + link + "'); }; } ";

        return data;
    }

}
public class Coord
{
    public double lon { get; set; }
    public double lat { get; set; }
}

public class Weather
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}

public class Main
{
    public double temp { get; set; }
    public float pressure { get; set; }
    public float humidity { get; set; }
    public float temp_min { get; set; }
    public float temp_max { get; set; }
}

public class Wind
{
    public double speed { get; set; }
    public float deg { get; set; }
}

public class Clouds
{
    public float all { get; set; }
}

public class Sys
{
    public int type { get; set; }
    public int id { get; set; }
    public double message { get; set; }
    public string country { get; set; }
    public float sunrise { get; set; }
    public float sunset { get; set; }
}

public class WeatherInfo
{
    public Coord coord { get; set; }
    public List<Weather> weather { get; set; }
    public string @base { get; set; }
    public Main main { get; set; }
    public int visibility { get; set; }
    public Wind wind { get; set; }
    public Clouds clouds { get; set; }
    public int dt { get; set; }
    public Sys sys { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public int cod { get; set; }
}


