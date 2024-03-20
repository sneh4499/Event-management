<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="viewcontent.aspx.cs" Inherits="Task_content_viewcontent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div class="block">
        <div class="block-header block-header-default bg-primary">
            <h3 class="block-title text-white"><i class="fa fa-video-camera"></i> View Content</h3>

        </div>
        <div class="block-content">

            <div class="js-filter" data-speed="400">
                        <div class="p-10 bg-white push">
                            <ul class="nav nav-pills">
                                
                                <li class="nav-item">
                            <a class="nav-link active" href="#" data-category-link="all">
                                <i class="fa fa-fw fa-video-camera mr-5"></i>All (<%=totalcount %>)
                            </a>
                        </li>

                        <%=tabs %>
                                
                            </ul>
                        </div>
                        <div class="row">
                           
                               <%=data %>
                           
                           
                        </div>
                    </div>

    </div>
            
    </div>
</asp:Content>

