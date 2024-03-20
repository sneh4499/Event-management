﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="visitorlogin.aspx.cs" Inherits="visitorlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="assest_user/style.css" rel="stylesheet" />
  
     
    <link href="assest_user/css/framework7.css" rel="stylesheet" />
    <link href="assest_user/css/style.css" rel="stylesheet" />
    <link href="assest_user/css/colors/magenta.css" rel="stylesheet" />
    <link href="assest_user/css/swipebox.css" rel="stylesheet" />
    <link href="assest_user/css/animations.css" rel="stylesheet" />
</head>
<body id="mobile_wrap">
    <form id="form1" runat="server">
        <div class="statusbar-overlay"></div>

        <div class="panel-overlay"></div>

        <div class="panel panel-left panel-cover">
            <div class="user_login_info">
              
                <div class="user_thumb">
                    <img src="../../assest_user/Ravi.jpg" height="100px" width="auto" alt="" title="" />
                    <div class="user_details">
                        <p>Hi, <span>Wel come To Event Management</span></p>
                    </div>
                 <%--   <div class="user_social">
                        <a href="#" data-popup=".popup-social" class="open-popup">
                            <img src="../../assest_user/images/icons/white/twitter.png" alt="" title="" /></a>
                    </div>--%>
                </div>

                <nav class="user-nav">
                    <ul>
                        <li><a href="features.html" class="close-panel">
                            <img src="../../assest_user/images/icons/white/settings.png" alt="" title="" /><span>Login</span></a></li>
                        <%--<li><a href="features.html" class="close-panel">
                            <img src="../../assest_user/images/icons/white/briefcase.png" alt="" title="" /><span>Account</span></a></li>
                        <li><a href="features.html" class="close-panel">
                            <img src="../../assest_user/images/icons/white/message.png" alt="" title="" /><span>Messages</span><strong class="green">12</strong></a></li>
                        <li><a href="features.html" class="close-panel">
                            <img src="../../assest_user/images/icons/white/download.png" alt="" title="" /><span>Downloads</span><strong class="blue">5</strong></a></li>
                        <li><a href="index.html" class="close-panel">
                            <img src="../../assest_user/images/icons/white/lock.png" alt="" title="" /><span>Logout</span></a></li>--%>
                    </ul>
                </nav>
            </div>
        </div>

        <div class="panel panel-center panel-cover">
            <div class="pages">
                <div data-page="projects" class="page no-toolbar no-navbar">
                    <div class="page-content">

                        <div class="page_content_menu">
                            <nav class="main-nav">
                                <ul>
                                    <li><a href="index.html">
                                        <img src="../../assest_user/images/icons/white/home.png" alt="" title="" /><span>Home</span></a></li>
                                    <li><a href="about.html">
                                        <img src="../../assest_user/images/icons/white/user.png" alt="" title="" /><span>About</span></a></li>
                                    <li><a href="features.html">
                                        <img src="../../assest_user/images/icons/white/settings.png" alt="" title="" /><span>Features</span></a></li>
                                    <li><a href="photos.html">
                                        <img src="../../assest_user/images/icons/white/photos.png" alt="" title="" /><span>Gallery</span></a></li>
                                    <li><a href="videos.html">
                                        <img src="../../assest_user/images/icons/white/video.png" alt="" title="" /><span>Videos</span></a></li>
                                    <li><a href="blog.html">
                                        <img src="../../assest_user/images/icons/white/blog.png" alt="" title="" /><span>Blog</span></a></li>
                                    <li><a href="tables.html">
                                        <img src="../../assest_user/images/icons/white/tables.png" alt="" title="" /><span>Tables</span></a></li>
                                    <li><a href="form.html">
                                        <img src="../../assest_user/images/icons/white/form.png" alt="" title="" /><span>Inputs</span></a></li>
                                    <li><a href="slider.html">
                                        <img src="../../assest_user/images/icons/white/slider.png" alt="" title="" /><span>Slider</span></a></li>
                                    <li><a href="toggle.html">
                                        <img src="../../assest_user/images/icons/white/toogle.png" alt="" title="" /><span>Toggle</span></a></li>
                                    <li><a href="tabs.html">
                                        <img src="../../assest_user/images/icons/white/docs.png" alt="" title="" /><span>Tabs</span></a></li>
                                    <li><a href="#" data-popup=".popup-social" class="open-popup">
                                        <img src="../../assest_user/images/icons/white/heart.png" alt="" title="" /><span>Social</span></a></li>
                                    <li><a href="#" data-popup=".popup-login" class="open-popup">
                                        <img src="../../assest_user/images/icons/white/lock.png" alt="" title="" /><span>Login</span></a></li>
                                    <li><a href="tel:1234 5678" class="external">
                                        <img src="../../assest_user/images/icons/white/phone.png" alt="" title="" /><span>Call Now</span></a></li>
                                    <li><a href="contact.html">
                                        <img src="../../assest_user/images/icons/white/contact.png" alt="" title="" /><span>Contact</span></a></li>
                                </ul>
                            </nav>
                            <div class="close_popup_button"><a href="#" class="backbutton">
                                <img src="../../assest_user/images/icons/white/menu_close.png" alt="" title="" /></a></div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <div class="panel panel-right panel-cover">

            <h2>Search</h2>
            <div class="search_form">
                <div id="SearchForm">
                    <input type="text" name="keyword" value="" class="search_input" placeholder="keyword" />
                    <input type="image" name="submit" class="search_submit" id="submit" src="../../assest_user/images/icons/white/search.png" />
                </div>
            </div>
            <div class="clear"></div>
            <h3>POPULAR POSTS</h3>
            <ul class="popular_posts">
                <li>
                    <a href="blog-single.html" class="close-panel">
                        <img src="../../assest_user/images/photos/photo1.jpg" alt="" title="" /></a>
                    <span><a href="blog-single.html" class="close-panel">Design is not just what it looks like and feels like.</a></span>        </li>
                <li>
                    <a href="blog-single.html" class="close-panel">
                        <img src="../../assest_user/images/photos/photo2.jpg" alt="" title="" /></a>
                    <span><a href="blog-single.html" class="close-panel">Fashion fades, only style remains the same.</a></span>        </li>
                <li>
                    <a href="blog-single.html" class="close-panel">
                        <img src="../../assest_user/images/photos/photo3.jpg" alt="" title="" /></a>
                    <span><a href="blog-single.html" class="close-panel">Sed ut perspiciatis unde omnis iste accusantium.</a></span>        </li>
                <li>
                    <a href="blog-single.html" class="close-panel">
                        <img src="../../assest_user/images/photos/photo4.jpg" alt="" title="" /></a>
                    <span><a href="blog-single.html" class="close-panel">Nemo enim ipsam voluptatem quia voluptas.</a></span>        </li>
                <li>
                    <a href="blog-single.html" class="close-panel">
                        <img src="../../assest_user/images/photos/photo5.jpg" alt="" title="" /></a>
                    <span><a href="blog-single.html" class="close-panel">Totam rem aperiam, eaque ipsa quae ab illo inventore veritatis.</a></span>        </li>
            </ul>
        </div>

        <div class="views">

            <div class="view view-main">
                 <div class="pages  toolbar-through">

          <div data-page="index" class="page homepage">
            <div class="page-content">
					
                <h1>login</h1>



            </div>
          </div>
        
          
        </div>

                <!-- Bottom Toolbar-->
                <div class="toolbar">
                    <div class="toolbar-inner">
                        <ul class="toolbar_icons">
                            <li><a href="#" data-panel="left" class="open-panel">
                                <img src="../../assest_user/images/icons/white/user.png" alt="" title="" /></a></li>
                            <li><a href="photos.html">
                                <img src="../../assest_user/images/icons/white/photos.png" alt="" title="" /></a></li>
                           <%-- <li class="menuicon"><a href="#" data-panel="center" class="open-panel">
                                <img src="../../assest_user/images/icons/white/menu.png" alt="" title="" /></a></li>--%>
                            <li class="menuicon"><a href="menu.html">
                                <img src="../../assest_user/images/icons/white/menu.png" alt="" title="" /></a></li>
                            <li><a href="blog.html">
                                <img src="../../assest_user/images/icons/white/blog.png" alt="" title="" /></a></li>
                            <li><a href="contact.html">
                                <img src="../../assest_user/images/icons/white/contact.png" alt="" title="" /></a></li>
                        </ul>
                    </div>
                </div>
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
