<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">

        <title>Event Management</title>

        <meta name="description" content="Event Management">
        <meta name="author" content="pixelcave">
        <meta name="robots" content="noindex, nofollow">

        <!-- Open Graph Meta -->
        <meta property="og:title" content="Event Management">
        <meta property="og:site_name" content="Event Management">
        <meta property="og:description" content="Event Management">
        <meta property="og:type" content="website">
        <meta property="og:url" content="">
        <meta property="og:image" content="">

        <!-- Icons -->
        <!-- The following icons can be replaced with your own, they are used by desktop and mobile browsers -->
        <link rel="shortcut icon" href="assets/cropped-Fevicon-180x180.png">
    
        <link rel="icon" type="image/png" sizes="192x192" href="assets/cropped-Fevicon-180x180.png">
        <link rel="apple-touch-icon" sizes="180x180" href="assets/cropped-Fevicon-180x180.png">
        <!-- END Icons -->

        <!-- Stylesheets -->

        <!-- Fonts and Codebase framework -->
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Muli:300,400,400i,600,700">
        <link rel="stylesheet"  href="Assets/css/codebase.min.css">
    
        <!-- You can include a specific file from css/themes/ folder to alter the default color theme of the template. eg: -->
        <!-- <link rel="stylesheet" href="Assets/css/themes/flat.min.css"> -->
        <!-- END Stylesheets -->
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <div id="page-container" class="main-content-boxed">

                <!-- Main Container -->
                <main id="main-container">

                <!-- Page Content -->
                <div class="bg-image" style="background-image: url('Assets/media/photos/photo17@2x.jpg');">
                    <div class="row mx-0 bg-black-op">
                        <div class="hero-static col-md-6 col-xl-8 d-none d-md-flex align-items-md-end">
                            <div class="p-30 invisible" data-toggle="appear">
                                <p class="font-size-h3 font-w600 text-white">
                                   Welcome
                                </p>
                                <p class="font-italic text-white-op">
                                    All rigth Reserved <%--<span class="js-year-copy"></span>--%>
                                </p>
                            </div>
                        </div>
                        <div class="hero-static col-md-6 col-xl-4 d-flex align-items-center bg-white invisible" data-toggle="appear" data-class="animated fadeInRight">
                            <div class="content content-full">
                                <!-- Header -->
                                <div class="px-30 py-10">

                                    <h1>Logo</h1>
                                                              
                                    <h1 class="h3 font-w700 mt-30 mb-10">Welcome to Your Dashboard</h1>
                                    <h2 class="h5 font-w400 text-muted mb-0">Please sign in</h2>
                                </div>
                                <!-- END Header -->

                                <!-- Sign In Form -->
                                <!-- jQuery Validation functionality is initialized with .js-validation-signin class in js/pages/op_auth_signin.min.js which was auto compiled from _es6/pages/op_auth_signin.js -->
                                <!-- For more examples you can check out https://github.com/jzaefferer/jquery-validation -->
                                <form class="js-validation-signin px-30" action="be_pages_auth_all.html" method="post">
                                    <div class="form-group row">
                                        <div class="col-12">
                                            <div class="form-material floating">
                                                <asp:TextBox ID="txtemail" runat="server" Cssclass="form-control" required></asp:TextBox>
                                                <label for="login-username">Username</label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group row">
                                        <div class="col-12">
                                            <div class="form-material floating">
                                                <asp:TextBox ID="txtpassword" runat="server" Cssclass="form-control" TextMode="Password" required></asp:TextBox>
                                                <label for="login-password">Password</label>
                                            </div>
                                        </div>
                                    </div>
                                    <%--<div class="form-group row">
                                        <div class="col-12">&nbsp;
                                            
                                                <asp:CheckBox ID="chkRememberMe" runat="server" />
                                                &nbsp;<label>Remember Me</label>
                                           
                                        </div>
                                    </div>--%>
                                    <div class="form-group">
                                        <asp:Button ID="btnsign" runat="server" CssClass="btn btn-primary btn-flat" Text="Sign in" OnClick="btnsign_Click">
                                                        <%--<i class="si si-login mr-10"></i>--%>
                                                    </asp:Button>
                                        <div class="mt-30">
                                           
                                            <a class="link-effect text-muted mr-10 mb-5 d-inline-block" href="forgetpassword.aspx">
                                                <i class="fa fa-warning mr-5"></i> Forgot Password
                                            </a>
                                        </div>
                                    </div>
                                </form>
                                <!-- END Sign In Form -->
                            </div>
                        </div>
                    </div>
                </div>
                <!-- END Page Content -->

            </main>
                <!-- END Main Container -->
            </div>
            <!-- END Page Container -->



        </div>
    </form>


    <!--
            Codebase JS Core

            Vital libraries and plugins used in all pages. You can choose to not include this file if you would like
            to handle those dependencies through webpack. Please check out assets/_es6/main/bootstrap.js for more info.

            If you like, you could also include them separately directly from the assets/js/core folder in the following
            order. That can come in handy if you would like to include a few of them (eg jQuery) from a CDN.

            Assets/js/core/jquery.min.js
            Assets/js/core/bootstrap.bundle.min.js
            Assets/js/core/simplebar.min.js
            Assets/js/core/jquery-scrollLock.min.js
            Assets/js/core/jquery.appear.min.js
            Assets/js/core/jquery.countTo.min.js
            Assets/js/core/js.cookie.min.js
        -->
    <script src="Assets/js/codebase.core.min.js"></script>

    <!--
            Codebase JS

            Custom functionality including Blocks/Layout API as well as other vital and optional helpers
            webpack is putting everything together at assets/_es6/main/app.js
        -->
    <script src="Assets/js/codebase.app.min.js"></script>

    <!-- Page JS Plugins -->
    <script src="Assets/js/plugins/jquery-validation/jquery.validate.min.js"></script>

    <!-- Page JS Code -->
    <script src="Assets/js/pages/op_auth_signup.min.js"></script>


</body>
</html>
