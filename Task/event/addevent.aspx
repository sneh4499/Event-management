<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="addevent.aspx.cs" Inherits="Task_event_addevent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="js-wizard-simple block ml-30 mr-30 mt-15">
        <div class="block-header block-header-default">
                <h3 class="block-title">Add Event</h3>
            </div>
        <!-- Form -->

        <!-- Steps Content -->
        <div class="block-content block-content-full tab-content" style="min-height: 267px;">
            <!-- Step 1 -->
            <div class="tab-pane active" id="wizard-simple2-step1" role="tabpanel">
                
                <div class="row">
                    <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txteventname" class="form-control cap" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="<%=txteventname.ClientID %>">Event Name</label>
                            </div>
                        </div>
                    </div>

                      <div class="col-md-3">
                        <div class="form-group row">
                            <label class="col-12" for="example-select">Event Category</label>    
                            <div class="col-md-12">
                                <asp:dropdownlist id="drdeventcategory" AppendDataBoundItems="true"   runat="server" class="js-select2 form-control" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name" >
                                    <asp:ListItem Value="">Select here..</asp:ListItem>
                                     </asp:dropdownlist>                           
                               
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [name] FROM [event_category]"></asp:SqlDataSource>
                               
                        </div>
                            </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                    <label  for="example-select2-multiple">Age Groups</label>
                    <p class="badge badge-primary" id="viewa" runat="server">Last Selected Agegroups is : <%=viewage %> </p>
                    <div class=" pl-0 pr-0 form-group">
                        <div class="form-material pt-0">

                            <select class="js-select2 form-control" required="required"  name="agegroup" id="agegroup" style="width: 100%;" data-placeholder="Choose many.." multiple>
                                <option></option>
                                <!-- Required for data-placeholder attribute to work with Select2 plugin -->
                                <%=ages %>
                            </select>
                        </div>
                    </div>
                </div>


                      <div class="col-md-3 col-sm-3">
                    <label  for="example-select2-multiple">Sessions</label>
                    <p class="badge badge-primary" id="views" runat="server">Last Selected Sessions is : <%=viewsession %> </p>
                    <div class=" pl-0 pr-0 form-group">
                        <div class="form-material pt-0">

                            <select class="js-select2 form-control" required="required"  name="sessions1" id="sessions1" style="width: 100%;" data-placeholder="Choose many.." multiple>
                                <option></option>
                                <!-- Required for data-placeholder attribute to work with Select2 plugin -->
                                <%=sess %>
                            </select>
                        </div>
                    </div>
                </div>

                    

                  

                    </div>
                <br />
                  <div class="row">

                      <div class="col-md-3 col-sm-3">
                    <label  for="example-select2-multiple">Time Slotes</label>
                   
                    <div class=" pl-0 pr-0 form-group">
                        <div class="form-material pt-0">

                            <select class="js-select2 form-control" required="required"  name="timeslot1" id="timeslot1" style="width: 100%;" data-placeholder="Choose many.." multiple>
                                <option></option>
                                <!-- Required for data-placeholder attribute to work with Select2 plugin -->
                                <%=timess %>
                            </select>
                        </div>
                    </div>
                           <p class="badge badge-primary" id="viewt" runat="server">Last Selected TimeSlotes is : <%=viewtimeslote %> </p>
                </div>
                     <div class="col-sm-3 ">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txteventdate" type="date" class="form-control" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">Event Date</label>
                                <%--<p class="badge badge-primary">Last Selected EventDate is : <%=v %> </p>--%>
                            </div>
                        </div>
                    </div>
                  <div class="col-sm-3 ">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txtseat" class="form-control" type="number" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="wizard-simple2-firstname">No Of Seat</label>
                            </div>
                        </div>
                    </div>
                         <div class="col-md-3">
                        <div class="form-group row">
                            <label class="col-12" for="example-select">Content Category</label>    
                            <div class="col-md-12">
                                <asp:dropdownlist id="drdcontentcategory" AppendDataBoundItems="true"  runat="server" class="js-select2 form-control" DataSourceID="SqlDataSource2" DataTextField="type" DataValueField="type" >
                                    <asp:ListItem Value="">Select here..</asp:ListItem>
                                     </asp:dropdownlist>                           
                               
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [type] FROM [content_category]"></asp:SqlDataSource>
                               
                        </div>
                            </div>
                    </div>
                 
                    
                </div>


                <div class="row">
                     <div class="col-md-4" runat="server">
                    <label>Upload Flyer</label>
                    <asp:FileUpload ID="fuvideo" runat="server" CssClass="form-control" />
                    <asp:Label ID="lblupload" runat="server"></asp:Label>
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

                     <asp:button runat="server" text="Submit" OnClick="btnsave_Click" class="btn btn-alt-primary" data-wizard="finish" ID="btnsave" />
                  <asp:button runat="server" OnClick="btnupdate_Click" text="Update" class="btn btn-alt-primary" data-wizard="finish" ID="btnupdate" />

                   
                </div>
            </div>
        </div>
        <!-- END Steps Navigation -->

        <!-- END Form -->
    </div>
</asp:Content>

