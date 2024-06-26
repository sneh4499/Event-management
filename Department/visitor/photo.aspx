﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="photo.aspx.cs" Inherits="Department_visitor_photo" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>--%>

<div class="pages">
  <div data-page="projects" class="page no-toolbar no-navbar">
    <div class="page-content">
    
     <div class="navbarpages">
       <div class="nav_left_logo"><a href="index.html"><img src="images/logo.png" alt="" title="" /></a></div>
       <div class="nav_right_button"><a href="menu.html"><img src="images/icons/white/menu.png" alt="" title="" /></a></div>
     </div>
     <div id="pages_maincontent">
      
      <div class="page_title_photos">
               <h2>Photo Gallery</h2>
               <div class="gallery_switch">        
                <a href="#" id="view13" class="switcher active"><img src="images/switch_13_active.png" alt="Grid"></a>
                <a href="#" id="view12" class="switcher"><img src="images/switch_12.png" alt="Grid"></a>
                <a href="#" id="view11" class="switcher"><img src="images/switch_11.png" alt="List"></a>
              </div>
      </div>
      

      
              <div class="photo-categories">
                    <a href="#tab1p" class="tab-link active category-link">Lanscapes</a>
                    <a href="#tab2p" class="tab-link category-link">People</a>
                    <a href="#tab3p" class="tab-link category-link">Flowers</a>
              </div>

              
              <div class="tabs-animated-wrap photos_tabs">
                    <div class="tabs">
                          <div id="tab1p" class="tab active">
                             <ul id="photoslist" class="photo_gallery_13">
                                <li><a rel="gallery-3" href="images/photos/photo1.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo1.jpg" alt="image"/></a></li>
                                <li><a rel="gallery-3" href="images/photos/photo2.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo2.jpg" alt="image"/></a></li>
                                <li><a rel="gallery-3" href="images/photos/photo3.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo3.jpg" alt="image"/></a></li>
                                <li><a rel="gallery-3" href="images/photos/photo4.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo4.jpg" alt="image"/></a></li>
                                <li><a rel="gallery-3" href="images/photos/photo5.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo5.jpg" alt="image"/></a></li>
                                <li><a rel="gallery-3" href="images/photos/photo6.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo6.jpg" alt="image"/></a></li>
                                <li><a rel="gallery-3" href="images/photos/photo7.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo7.jpg" alt="image"/></a></li>
                                <li><a rel="gallery-3" href="images/photos/photo8.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo8.jpg" alt="image"/></a></li>
                                <li><a rel="gallery-3" href="images/photos/photo9.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo9.jpg" alt="image"/></a></li>
                               <div class="clearleft"></div>
                              </ul>   
                          </div>
    
                          <div id="tab2p" class="tab">
                             <ul id="photoslist" class="photo_gallery_13">
                                    <li><a rel="gallery-3" href="images/photos/photo10.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo10.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo11.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo11.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo12.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo12.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo13.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo13.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo7.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo7.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo14.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo14.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo3.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo3.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo15.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo15.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo8.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo8.jpg" alt="image"/></a></li>
                               <div class="clearleft"></div>
                              </ul> 
                          </div> 
                          
                          <div id="tab3p" class="tab">
                             <ul id="photoslist" class="photo_gallery_13">
                                    <li><a rel="gallery-3" href="images/photos/photo10.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo10.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo11.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo11.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo12.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo12.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo13.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo13.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo7.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo7.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo14.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo14.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo3.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo3.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo15.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo15.jpg" alt="image"/></a></li>
                                    <li><a rel="gallery-3" href="images/photos/photo8.jpg" title="Photo title" class="swipebox"><img src="images/photos/photo8.jpg" alt="image"/></a></li>
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
