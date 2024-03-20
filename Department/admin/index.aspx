<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Department_admin_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="content">
                    <%--<div class="row gutters-tiny">
                        <!-- Row #4 -->
                        <div class="col-md-6 col-xl-4">
                            <a class="block block-link-pop" href="javascript:void(0)">
                                <div class="block-content block-content-full d-flex align-items-center justify-content-between">
                                    <div class="p-20">
                                        <i class="fa fa-2x fa-calendar text-primary"></i>
                                    </div>
                                    <div class="ml-5 text-right">
                                        <p class="font-size-lg font-w600 mb-0">
                                            <%=events %> Total Events
                                        </p>
                                        
                                    </div>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-6 col-xl-4">
                            <a class="block block-link-pop" href="javascript:void(0)">
                                <div class="block-content block-content-full d-flex align-items-center justify-content-between">
                                    <div class="p-20">
                                        <i class="fa fa-2x fa-film text-primary"></i>
                                    </div>
                                    <div class="ml-5 text-right">
                                        <p class="font-size-lg font-w600 mb-0">
                                            <%=video %> Content
                                        </p>
                                        
                                    </div>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-6 col-xl-4">
                            <a class="block block-link-pop" href="javascript:void(0)">
                                <div class="block-content block-content-full d-flex align-items-center justify-content-between">
                                    <div class="p-20">
                                        <i class="fa fa-2x fa-user text-primary"></i>
                                    </div>
                                    <div class="ml-5 text-right">
                                        <p class="font-size-lg font-w600 mb-0">
                                            <%=registrations %> Total Registration
                                        </p>
                                        
                                    </div>
                                </div>
                            </a>
                        </div>
                        <!-- END Row #4 -->
                    </div>--%>




              <div class="row invisible" data-toggle="appear">
                        <!-- Row #4 -->
                        <div class="col-md-6">
                            <a class="block block-link-shadow overflow-hidden" href="javascript:void(0)">
                                <div class="block-content block-content-full">
                                    <i class="si si-calendar fa-2x text-body-bg-dark"></i>
                                    <div class="row py-20">
                                        <div class="col-6 text-right border-r">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInLeft">
                                                <div class="font-size-h3 font-w600"><%=events %></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Total Events</div>
                                            </div>
                                        </div>
                                        <div class="col-6">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInRight">
                                                <div class="font-size-h3 font-w600"><%=video %></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Total Content</div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-6">
                            <a class="block block-link-shadow overflow-hidden" href="javascript:void(0)">
                                <div class="block-content block-content-full">
                                    <div class="text-right">
                                        <i class="si si-users fa-2x text-body-bg-dark"></i>
                                    </div>
                                    <div class="row py-20">
                                        <div class="col-6 text-right border-r">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInLeft">
                                                <div class="font-size-h3 font-w600 text-info"><%=registrations%></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Total Ragistration</div>
                                            </div>
                                        </div>
                                        <div class="col-6">
                                            <div class="invisible" data-toggle="appear" data-class="animated fadeInRight">
                                                <div class="font-size-h3 font-w600 text-success"><%=approvedregistration%></div>
                                                <div class="font-size-sm font-w600 text-uppercase text-muted">Total Approved</div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </div>
                        <!-- END Row #4 -->
                    </div>
                  
                </div>



    
</asp:Content>

