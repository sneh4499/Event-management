<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="detail.aspx.cs" Inherits="Task_registration_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div class="ml-15 mr-15">

        <div class="block-header block-header-default ml-15 mr-15 mt-15">
            <h3 class="block-title">Registration Detail</h3>

            <asp:Button ID="btnactive" runat="server" OnClick="btnactive_Click" CssClass="btn btn-success" Text="Active" /> &nbsp&nbsp

            <asp:Button ID="btninactive" runat="server" OnClick="btninactive_Click" CssClass="btn btn-danger" Text="InActive" />
        </div>
                    <div class="table-responsive">
        <%=data%>

</div>
       
    </div>

</asp:Content>

