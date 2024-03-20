<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="Task_content_view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">


 
  
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div class="block">
        <div class="block-header block-header-default bg-primary">
            <h3 class="block-title text-white"><i class="fa fa-video-camera"></i> View Content</h3>

        </div>
        <div class="block-content">




            </div>

        <div class="space-medium">
        <div class="container">
            <div class="row">
               
               <%=data %>
                  
            </div>
           
           
        </div>
    </div>

         </div>
       <script>

           $(".video-play").on('click', function (e) {
               e.preventDefault();
               var vidWrap = $(this).parent(),
                   iframe = vidWrap.find('.video iframe'),
                   iframeSrc = iframe.attr('src'),
                   iframePlay = iframeSrc += "?autoplay=1";
               vidWrap.children('.video-thumbnail').fadeOut();
               vidWrap.children('.video-play').fadeOut();
               vidWrap.find('.video iframe').attr('src', iframePlay);


           });

    </script>
</asp:Content>

