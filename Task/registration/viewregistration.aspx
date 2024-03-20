<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="viewregistration.aspx.cs" Inherits="Task_registration_viewregistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div class="block">
        <div class="block-header block-header-default bg-primary">
            <h3 class="block-title text-white"><i class="fa fa-list"></i> View Registration</h3>

         
        </div>
        <div class="block-content">

                <div class="table-responsive">
            <%=data %>
                    </div>
        </div>
    </div>

     


</asp:Content>

