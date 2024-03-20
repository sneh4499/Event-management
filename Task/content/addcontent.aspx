<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="addcontent.aspx.cs" Inherits="Task_content_addcontent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    
     <div class="block">
        <div class="block-header block-header-default bg-primary">
            <h3 class="block-title text-white"><i class="fa fa-video-camera"></i> Add Content</h3>

        </div>
        <div class="block-content">
           
            <div class="form-group row">
                 <div class="col-md-4">
                    <label>Content Name</label>
                    <asp:TextBox ID="txtname" runat="server" CssClass="form-control" required></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <label>Content Type</label>
                    <asp:DropDownList ID="ddltype" AppendDataBoundItems="true" runat="server" CssClass="form-control" required DataSourceID="SqlDataSource1" DataTextField="type" DataValueField="type">
                        <asp:ListItem Value="">Please Select</asp:ListItem>
                      
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [type] FROM [content_category]"></asp:SqlDataSource>
                </div>

                  <div class="col-md-2">
                    <label>Please Select</label>
                    <asp:RadioButtonList ID="rdobtn" runat="server" OnSelectedIndexChanged="rdobtn_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Selected>Link</asp:ListItem>
                        <asp:ListItem>Upload A Video</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                  <div class="col-md-4" id="textbox" runat="server">
                    <label>Enter Link Here</label>
                    <asp:TextBox ID="txtlink" runat="server" CssClass="form-control" required></asp:TextBox>
                </div>
                   <div class="col-md-4" id="fileupload" runat="server">
                    <label>Upload A Video</label>
                    <asp:FileUpload ID="fuvideo" runat="server" CssClass="form-control" />
                    <asp:Label ID="lblupload" runat="server"></asp:Label>
                </div>
               
            </div>

            

            

            <div class="form-group row">
                <div class="col-md-12">
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" CssClass="btn btn-primary" />

                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </div>
            </div>

        </div>
    </div>



    
</asp:Content>

