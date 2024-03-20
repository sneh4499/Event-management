<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="eventdetail.aspx.cs" Inherits="Task_event_eventdetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


      <div class="bg-primary">
                    <div class="bg-pattern bg-black-op-25" style="background-image: url('assets/media/various/bg-pattern.png');">
                        <div class="content content-top text-center">
                            <div class="py-50">
                                <h1 class="font-w700 text-white mb-10"><%=eventname %></h1>
                                <h2 class="h4 font-w400 text-white-op"><%=eventcategory %></h2>
                                <h2 class="h4 font-w400 text-white-op"><%=evantedate %></h2>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- END Hero -->

                <!-- Page Content -->
                <div class="content content-full">
                    <!-- Team -->
                    <div class="row gutters-tiny py-20">
                        <div class="col-md-6 col-xl-4">
                            <div class="block text-center">
                                <div class="block-content">
                                  <%--  <img class="img-avatar img-avatar96" src="assets/media/avatars/avatar1.jpg" alt="">--%>
                                </div>
                                <div class="block-content block-content-full">
                                    <div class="font-size-h4 font-w600 mb-0">Age Group :<%=agegroups %></div>
                                    <div class="font-size-h5 text-muted">Session : <%=sessionss %></div>
                                    <div class="font-size-h5 text-muted">Time Slot :<%=timeslots %></div>
                                    <div class="font-size-h5 text-muted">Seat :<%=seat %></div>
                                    <div class="font-size-h5 text-muted">Content Type :<%=contentcategory %></div>
                                    <div class="font-size-h5 text-muted">Status :<%=status %></div>
                                </div>
                                <div class="block-content block-content-full bg-body-light">
                                   
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-xl-6">
                            <div class="block text-center">
                                <div class="block-content">
                                     <div class="row js-gallery img-fluid-100 gutters-tiny">
                                        <div class="col-6 col-lg-6 animated fadeIn">
                                            <a class="img-link img-link-zoom-in img-thumb img-lightbox" href="<%=flyerimg %>">
                                                <img class="img-fluid" src="<%=flyerimg %>" alt="">
                                            </a>
                                        </div>
                                         </div>
                                </div>
                             
                                <div class="block-content block-content-full bg-body-light">
                                   
                                </div>
                            </div>
                        </div>
                        
                       
                    </div>
                   
                </div>
</asp:Content>

