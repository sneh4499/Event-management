<%@ Page Title="" Language="C#" MasterPageFile="~/Department/visitor/visitor.master" AutoEventWireup="true" CodeFile="events.aspx.cs" Inherits="Task_userevent_events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pages">
        <div data-page="projects" class="page ">
            <div class="page-content">

                <div id="pages_maincontent">

                    <h2 class="page_title">Events</h2>

                    <div class="page_content">

                        <div class="list-block">

                            <%=data %>
                            <%--<ul class="posts">
                                <li class="swipeout">
                                    <div class="swipeout-content item-content">
                                        <div class="post_entry">
                                            <div class="post_date">
                                                <span class="day">23</span>
                                                <span class="month">march</span>
                                            </div>
                                            <div class="post_title">
                                                <h2><a href="blog-single.html">Design is not just what it looks like and feels like.</a></h2>
                                            </div>
                                            <div class="post_swipe">
                                                <img src="../../assest_user/images//swipe_more.png" alt="" title="" /></div>
                                        </div>
                                    </div>
                                    <div class="swipeout-actions-right">
                                                      <a href="eventdetail.aspx" class="action1">
                                            <img src="../../assest_user/images//icons/white/menu.png" alt="" title="" /></a>
                                        <a href="../../Task/event_registration.aspx" class="action1">
                                            <img src="../../assest_user/images//icons/white/user.png" alt="" title="" /></a>
                                    </div>
                                </li>
                            </ul>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

