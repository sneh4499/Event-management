<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="addpresents.aspx.cs" Inherits="Task_attendance_addpresents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="block">
        <div class="block-header block-header-default bg-primary">
                <h3 class="block-title text-white"><i class="fa fa-users"></i> Add Atendance</h3>
            </div>
        <!-- Form -->

        <!-- Steps Content -->
        <div class="block-content block-content-full tab-content">
            <!-- Step 1 -->
            <div class="tab-pane active" id="wizard-simple2-step1" role="tabpanel">
                
                <div class="row">
                      <div class="col-md-4">
                        <div class="form-group row">
                            <label class="col-12" for="example-select">Event</label>    
                            <div class="col-md-12">
                                <asp:dropdownlist id="drdevent" AppendDataBoundItems="True" OnSelectedIndexChanged="drdevent_SelectedIndexChanged" AutoPostBack="true" runat="server" class="js-select2 form-control" DataSourceID="SqlDataSource2" DataTextField="Eventname" DataValueField="Eventname" >
                                    <asp:ListItem >Select here..</asp:ListItem>
                              
                                </asp:dropdownlist>                           
                               
                               
                               
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Eventname] FROM [event]">
                                   
                                </asp:SqlDataSource>
                               
                               
                               
                        </div>
                            </div>
                    </div>
                     <div class="col-md-4">
                        <div class="form-group row">
                            <label class="col-12" for="example-select">Session</label>    
                            <div class="col-md-12">
                                <asp:dropdownlist id="drdsession" AppendDataBoundItems="True" runat="server" class="js-select2 form-control" DataSourceID="SqlDataSource3" DataTextField="Sessions" DataValueField="Sessions" >
                                    <asp:ListItem >Select here..</asp:ListItem>
                              
                                </asp:dropdownlist>                           
                               
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT DISTINCT [Sessions] FROM [event]">
                                   
                                </asp:SqlDataSource>
                               
                        </div>
                            </div>
                    </div>

                    <div class="col-sm-4">
                        <div class="form-group">
                            <label for="">Add Attendance</label>
                            <div class="form-material ">
                              <asp:CheckBoxList ID="chkatten" runat="server" DataSourceID="SqlDataSource1" DataTextField="firstname" DataValueField="id" ></asp:CheckBoxList>
                                
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT firstname,id FROM [event_registration]"></asp:SqlDataSource>
                                
                               
                            </div>
                        </div>
                    </div>

                    </div>
               
            </div>
            <!-- END Step 1 -->

        </div>
        <!-- END Steps Content -->

        <!-- Steps Navigation -->
        <div class="block-content block-content-sm block-content-full bg-body-light">
            <div class="row">

                <div class="col-md-12 text-center">

                     <asp:button runat="server" OnClick="btnsave_Click" text="Submit" class="btn btn-alt-primary" data-wizard="finish" ID="btnsave" />
                    <%--  <asp:button runat="server" OnClick="btnupdate_Click" text="Update" class="btn btn-alt-primary" data-wizard="finish" ID="btnupdate" />--%>
                  <%--  <a href="#myModal" runat="server" data-wizard="finish" class="btn btn-alt-primary" data-toggle="modal" id="update">Update</a>--%>

                   
                </div>
            </div>
        </div>
        <!-- END Steps Navigation -->
              </div>

</asp:Content>

