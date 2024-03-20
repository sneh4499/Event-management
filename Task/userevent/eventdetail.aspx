<%@ Page Title="" Language="C#" MasterPageFile="~/Department/visitor/visitor.master" AutoEventWireup="true" CodeFile="eventdetail.aspx.cs" Inherits="Task_userevent_eventdetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="pages">
        <div data-page="projects" class="page ">
            <div class="page-content">

                <%-- <div class="navbarpages">
                    <div class="nav_left_logo"><a href="index.html">
                        <img src="../../assest_user/images/logo.png" alt="" title="" /></a></div>
                    <div class="nav_right_button"><a href="menu.html">
                        <img src="../../assest_user/images/icons/white/menu.png" alt="" title="" /></a></div>
                </div>--%>
                <div id="pages_maincontent">
                  

                    <div class="post_single">                        
                         <blockquote>
                                   &nbsp&nbsp&nbsp Event Detail
                                </blockquote>

                        <div class="page_content">

                            <div class="row">

                                <div class="col-md-4">

                                    <div class="entry">
                                <p>
                                  <strong>Event Name : <%=eventname %></strong>
                                </p>
                                <p>
                                    <strong>Event Category : <%=eventcategory %></strong>
                                </p>
                                  <p>
                                    <strong>Age Group : <%=agegroups %></strong>
                                </p>
                                <p>
                                    <strong>Session : <%=sessionss %></strong>
                                </p>
                                  <p>
                                    <strong>Session : <%=timeslots %></strong>
                                </p>
                                  <p>
                                    <strong>Seat : <%=seat %></strong>
                                </p>

                              
                               
                            </div>
                                </div>

                                <div class="col-md-8">

                                    
                            <img src="<%=flyerimg %>" height="300px" width="300px" alt="image" />
                                   
                                </div>



                            </div>
                             <blockquote>
                                   
                                </blockquote>
                            
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

