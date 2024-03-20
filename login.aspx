<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, minimum-scale=1, user-scalable=no, minimal-ui">
    <title>Event Management</title>
    <link href="../../assest_user/css/framework7.css" rel="stylesheet" />
    <link href="../../assest_user/css/style.css" rel="stylesheet" />
    <link href="../../assest_user/css/colors/magenta.css" rel="stylesheet" />
    <link href="../../assest_user/css/swipebox.css" rel="stylesheet" />
    <link href="../../assest_user/css/animations.css" rel="stylesheet" />
    <link href="assest_user/style.css" rel="stylesheet" />
     <style>
        form {
            height: 100%;
        }

        .signup_bottom p{
            color: #fff;
        }
        .page-content{
            background-color: #8a0068;
        }
    </style>
</head>
<body id="mobile_wrap">
    <form id="form1" runat="server">
        <div class="views">

            <div class="view view-main">

                <div class="pages  toolbar-through">

                    <div data-page="index" class="page homepage">
                        <div class="page-content">
                            <div class="popu popup-login">
                                <div class="content-block-login">
                                    <h4>LOGIN</h4>
                                    <div class="form_logo">
                                        <img src="assest_user/images/logo.png" alt="" title="" />
                                    </div>
                                    <div class="loginform">
                                        <asp:TextBox ID="txtemail" runat="server" type="text"  value="" class="form_input required" placeholder="Username" ></asp:TextBox>
                                        <asp:TextBox ID="txtpass" runat="server" type="password" name="Password" value="" class="form_input required" placeholder="Password"></asp:TextBox>
                                        <div class="forgot_pass"><a href="#" data-popup=".popup-forgot" class="open-popup">Forgot Password?</a></div>
                                        <asp:Button id="btnsubmit" runat="server" OnClick="btnsubmit_Click" type="submit" name="submit" class="form_submit" Text="SIGN IN" />
                                        <div class="signup_bottom">
                                            <p>Don't have an account?</p>
                                            <a href="registration.aspx" data-popup=".popup-signup" class="open-popup">SIGN UP</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Bottom Toolbar-->

            </div>
        </div>
    </form>
     <script src="assest_user/js/jquery-1.10.1.min.js"></script>
    <script src="assest_user/js/jquery.validate.min.js"></script>
    <script src="assest_user/js/framework7.js"></script>
    <script src="assest_user/js/classie.js"></script>
    <script src="assest_user/js/selectFx.js"></script>
    <script src="assest_user/js/my-app.js"></script>
    <script src="assest_user/js/jquery.swipebox.js"></script>
    <script src="assest_user/js/email.js"></script>
</body>
</html>
