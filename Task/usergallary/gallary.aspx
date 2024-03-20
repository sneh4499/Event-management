<%@ Page Title="" Language="C#" MasterPageFile="~/Department/visitor/visitor.master" AutoEventWireup="true" CodeFile="gallary.aspx.cs" Inherits="Task_usergallary_gallary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .gallery_switch
        {
            display:none;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div class="pages">
        <div data-page="projects" class="page ">
            <div class="page-content">

               <%-- <div class="navbarpages">
                    <div class="nav_left_logo"><a href="index.html">
                        <img src="../assest_user/images/logo.png" alt="" title="" /></a></div>
                    <div class="nav_right_button"><a href="menu.html">
                        <img src="../assest_user/images/icons/white/menu.png" alt="" title="" /></a></div>
                </div>--%>
                <div id="pages_maincontent">
                  
                   
                    <div class="page_title_photos">
                        <h2>Photo Gallery</h2>
                        <div class="gallery_switch">
                            <a href="#" id="view13" class="switcher active">
                                <img src="../../assest_user/images/switch_13_active.png" alt="Grid"></a>
                            <a href="#" id="view12" class="switcher">
                                <img src="../../assest_user/images/switch_12.png" alt="Grid"></a>
                            <a href="#" id="view11" class="switcher">
                                <img src="../../assest_user/images/switch_11.png" alt="List"></a>
                        </div>
                    </div>



                    <div class="photo-categories">
                        <a href="#tab1p" class="tab-link active category-link">Free</a>
                        <a href="#tab2p" class="tab-link category-link">Premium</a>
                    </div>


                    <div class="tabs-animated-wrap photos_tabs">
                        <div class="tabs">
                            <div id="tab1p" class="tab active">
                                <ul id="photoslist" class="photo_gallery_11">
                                   
                                    <li>
                                        <object data="http://www.youtube.com/v/W7qWa52k-nE&amp;fs=1"
   width="320" height="240"><param name="allowFullScreen" value="true" />
    <param name="src" value="http://www.youtube.com/v/W7qWa52k-nE&amp;fs=1" /></object>
                                    </li>
                                   <%=data %>
                                    
                                    <div class="clearleft"></div>
                                </ul>
                            </div>

                            <div id="tab2p" class="tab">
                                <ul id="photoslist" class="photo_gallery_11">
                                    
                                    <%=data1 %>
                                    
                                    <div class="clearleft"></div>
                                </ul>
                            </div>


                        </div>
                    </div>





                    <div class="clearleft"></div>
                </div>


            </div>
        </div>
    </div>



</asp:Content>

