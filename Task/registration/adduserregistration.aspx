<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="adduserregistration.aspx.cs" Inherits="Task_registration_adduserregistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="block">
        <div class="block-header block-header-default bg-primary">
                <h3 class="block-title text-white"><i class="fa fa-plus"></i> Add User Registration</h3>
            </div>
        <!-- Form -->

        <!-- Steps Content -->
        <div class="block-content block-content-full tab-content" >
            <!-- Step 1 -->
            <div class="tab-pane active" id="wizard-simple2-step1" role="tabpanel">
                
                <div class="row">
                    <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txtfname" class="form-control cap" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="<%=txtfname.ClientID %>">First Name</label>
                            </div>
                        </div>
                    </div>

                     <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txtlname" class="form-control cap" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="<%=txtlname.ClientID %>">Last Name</label>
                            </div>
                        </div>
                    </div>

                     <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txtemail" class="form-control" TextMode="Email" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="">Email</label>
                            </div>
                        </div>
                    </div>

                      <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txtcontactnumber" type="number" class="form-control" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="">Contact Number</label>
                            </div>
                        </div>
                    </div>


                    

                    </div>


                    <div class="row">
                           <div class="col-md-3">
                    <label>Please Select</label>
                    <asp:RadioButtonList ID="rdobtn" runat="server">
                        <asp:ListItem Selected>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                         <asp:ListItem>Other</asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                         <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txtdob" class="form-control" type="date" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="dob">Date Of Birth</label>
                            </div>
                        </div>
                    </div>

                           <div class="col-md-3">
                        <div class="form-group row">
                            <label class="col-12" for="example-select">Age Group</label>    
                            <div class="col-md-12">
                                <asp:dropdownlist id="drdagegroup" AppendDataBoundItems="True" runat="server" class="js-select2 form-control" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name" >
                                    <asp:ListItem >Select here..</asp:ListItem>
                              
                                </asp:dropdownlist>                           
                               
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [name] FROM [agegroup]"></asp:SqlDataSource>
                               
                        </div>
                            </div>
                    </div>
                        
                           <div class="col-md-3 col-sm-3">
                    <label  for="example-select2-multiple">Time Slotes</label>
                    <p class="badge badge-primary" id="viewt" runat="server"><br />Last Selected TimeSlotes is : <%=viewtimeslote %> </p>
                    <div class=" pl-0 pr-0 form-group">
                        <div class="form-material pt-0">

                            <select class="js-select2 form-control" required="required"  name="timeslot1" id="timeslot1" style="width: 100%;" data-placeholder="Choose many.." multiple>
                                <option></option>
                                <!-- Required for data-placeholder attribute to work with Select2 plugin -->
                                <%=timess %>
                            </select>
                        </div>
                    </div>
                          
                </div>


                        </div>



                    <div class="row">

                        
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



                          <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txthearaboutus"  class="form-control"  runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="">How did you hear about us *</label>
                            </div>
                        </div>
                    </div>
                         

                        
                          <div class="col-md-3">
                        <div class="form-group row">
                            <label class="col-12" for="example-select">Which City you are contacting us from *</label>    
                            <div class="col-md-12">
                                <asp:DropDownList ID="drdstate"  class="js-select2 form-control" runat="server">
	<asp:ListItem >Alabama</asp:ListItem>
	<asp:ListItem >Alaska</asp:ListItem>
	<asp:ListItem >Arizona</asp:ListItem>
	<asp:ListItem >Arkansas</asp:ListItem>
	<asp:ListItem>California</asp:ListItem>
	<asp:ListItem>Colorado</asp:ListItem>
	<asp:ListItem >Connecticut</asp:ListItem>
	<asp:ListItem >District of Columbia</asp:ListItem>
	<asp:ListItem >Delaware</asp:ListItem>
	<asp:ListItem >Florida</asp:ListItem>
	<asp:ListItem >Georgia</asp:ListItem>
	<asp:ListItem >Hawaii</asp:ListItem>
	<asp:ListItem >Idaho</asp:ListItem>
	<asp:ListItem >Illinois</asp:ListItem>
	<asp:ListItem >Indiana</asp:ListItem>
	<asp:ListItem >Iowa</asp:ListItem>
	<asp:ListItem >Kansas</asp:ListItem>
	<asp:ListItem >Kentucky</asp:ListItem>
	<asp:ListItem >Louisiana</asp:ListItem>
	<asp:ListItem >Maine</asp:ListItem>
	<asp:ListItem >Maryland</asp:ListItem>
	<asp:ListItem >Massachusetts</asp:ListItem>
	<asp:ListItem >Michigan</asp:ListItem>
	<asp:ListItem >Minnesota</asp:ListItem>
	<asp:ListItem >Mississippi</asp:ListItem>
	<asp:ListItem >Missouri</asp:ListItem>
	<asp:ListItem >Montana</asp:ListItem>
	<asp:ListItem >Nebraska</asp:ListItem>
	<asp:ListItem >Nevada</asp:ListItem>
	<asp:ListItem >New Hampshire</asp:ListItem>
	<asp:ListItem >New Jersey</asp:ListItem>
	<asp:ListItem >New Mexico</asp:ListItem>
	<asp:ListItem >New York</asp:ListItem>
	<asp:ListItem >North Carolina</asp:ListItem>
	<asp:ListItem >North Dakota</asp:ListItem>
	<asp:ListItem >Ohio</asp:ListItem>
	<asp:ListItem >Oklahoma</asp:ListItem>
	<asp:ListItem >Oregon</asp:ListItem>
	<asp:ListItem >Pennsylvania</asp:ListItem>
	<asp:ListItem >Rhode Island</asp:ListItem>
	<asp:ListItem >South Carolina</asp:ListItem>
	<asp:ListItem >South Dakota</asp:ListItem>
	<asp:ListItem >Tennessee</asp:ListItem>
	<asp:ListItem >Texas</asp:ListItem>
	<asp:ListItem >Utah</asp:ListItem>
	<asp:ListItem >Vermont</asp:ListItem>
	<asp:ListItem >Virginia</asp:ListItem>
	<asp:ListItem >Washington</asp:ListItem>
	<asp:ListItem >West Virginia</asp:ListItem>
	<asp:ListItem >Wisconsin</asp:ListItem>
	<asp:ListItem >Wyoming</asp:ListItem>
</asp:DropDownList>                          
                               
                        </div>
                            </div>
                    </div>




                        
                          <div class="col-sm-3">
                        <div class="form-group">
                             <label for="">Preferred way to contact *</label>
                            <div class="form-material">
                                <asp:CheckBoxList  class="css-checkbox" ID="chkpreffcontact" runat="server">
                                    <asp:ListItem Text="Phone"></asp:ListItem>
                                    <asp:ListItem Text="Email"></asp:ListItem>
                                </asp:CheckBoxList>
                               
                            </div>
                        </div>
                    </div>



                        </div>
               

                 <div class="row">

                      <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txtcommentifany"  class="form-control" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="">Comment If Any</label>
                            </div>
                        </div>
                    </div>



                      <div class="col-md-3 col-sm-3">
                    <label  for="example-select2-multiple">Select Event</label>
                    <p class="badge badge-primary" id="viewa" runat="server">Last Selected Events is : <%=viewevent %> </p>
                    <div class=" pl-0 pr-0 form-group">
                        <div class="form-material pt-0">

                            <select class="js-select2 form-control" required="required"  name="eventfor" id="eventfor" style="width: 100%;" data-placeholder="Choose many.." multiple>
                                <option></option>
                                <!-- Required for data-placeholder attribute to work with Select2 plugin -->
                                <%=eventview %>
                            </select>
                        </div>
                    </div>
                </div>
                     <div class="col-sm-3">
                        <div class="form-group">
                            <div class="form-material">
                                <asp:TextBox ID="txtpassword" TextMode="Password"  class="form-control" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="">Password</label>
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
                      <asp:button runat="server" OnClick="btnupdate_Click" text="Update" class="btn btn-alt-primary" data-wizard="finish" ID="btnupdate" />
                  <%--  <a href="#myModal" runat="server" data-wizard="finish" class="btn btn-alt-primary" data-toggle="modal" id="update">Update</a>--%>

                   
                </div>
            </div>
        </div>
        <!-- END Steps Navigation -->
              </div>


   
</asp:Content>

