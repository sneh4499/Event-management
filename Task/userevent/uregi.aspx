<%@ Page Title="" Language="C#" MasterPageFile="~/Department/visitor/visitor.master" AutoEventWireup="true" CodeFile="uregi.aspx.cs" Inherits="Task_userevent_uregi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

     <style>
        .contactform input.form_input {
            padding: 10px;
        }

        .contactform select {
            width: 100%;
            margin: 0 0 5px 0;
            border: 1px solid #ddd;
            padding: 10px;
            width: 97%;
        }

        .selector_overlay {
            border: 0;
        }
        .contactform input.form_submit{
            padding: 12px 0 12px 0;
        }
        .page_content{
            margin: 10px 0 12% 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <%--<div class="pages">
        <div data-page="projects" class="page ">
            <div class="page-content">

                <div id="pages_maincontent">

                    <h2 class="page_title">Events</h2>

                    <div class="page_content">
                           <div class="loginform">
                        <div class="row">

                            <div class="col-md-3">
                                <asp:TextBox ID="txtusername" runat="server" type="text" name="Username" value="" class="form_input required" placeholder="username" ></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                <asp:TextBox ID="txtemail" runat="server" type="text"  value="" class="form_input required" placeholder="email" ></asp:TextBox>
                            </div>
                            <div class="col-md-3">
                                  <asp:TextBox ID="txtphone" runat="server" type="number"  value="" class="form_input required" placeholder="number" ></asp:TextBox>
                            </div>
                            <div class="col-md-3"></div>
                                <asp:RadioButtonList ID="rdbtngender" runat="server">
                                   <asp:ListItem Text="Male" Selected></asp:ListItem>
                                   <asp:ListItem Text="Female"></asp:ListItem>
                               </asp:RadioButtonList>
                        </div>
     
                                        
                                   <div class="row">

                                       <div class="col-md-3">
                                             <asp:TextBox ID="txtdob" runat="server" type="date"  class="form_input required" placeholder="Date Of Birth"></asp:TextBox>
                                       </div>
                                       <div class="col-md-3">
                                          
                                            <asp:DropDownList ID="drdagegroup" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name" ></asp:DropDownList>
     
                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [name] FROM [agegroup]"></asp:SqlDataSource>
     
                                       </div>
                                       <div class="col-md-3">
                                            <asp:DropDownList ID="drdtimeslote" Class="cs-select selectoptions" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name" ></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [name] FROM [timeslotes]"></asp:SqlDataSource>
                                       </div>
                                       <div class="col-md-3">
                                           <asp:DropDownList ID="drdsession" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name" ></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [name] FROM [sessionss]"></asp:SqlDataSource>
                                       </div>
                                   </div>    
                                <div class="row">

                                       <div class="col-md-3">
                                             <asp:TextBox ID="txthearaboutyou" runat="server" type="text"  value="" class="form_input required" placeholder="Hear About Us" ></asp:TextBox>
                                       </div>
                                       <div class="col-md-3">
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
                                       <div class="col-md-3">
                                           <asp:CheckBoxList class="label-checkbox item-content" ID="chkpreffer" runat="server">
                                   <asp:ListItem Text="Phone"></asp:ListItem>
                                   <asp:ListItem Text="Email"></asp:ListItem>
                               </asp:CheckBoxList>
                                       </div>
                                       <div class="col-md-3">

                                              <asp:TextBox ID="txtcommentifany" runat="server" type="text"  value="" class="form_input required" placeholder="Comment If Any" ></asp:TextBox>
                                       </div>
                                   </div>    

                           
                               

                              

                                       <asp:Button id="btnsubmit" runat="server" OnClick="btnsubmit_Click" type="submit" name="submit" class="form_submit" Text="SIGN IN" />

                               <br />
                               <div class="row">

                                   <div class="col-md-2"></div>
                                   <div class="col-md-8">
                                       <asp:Label ID="lblseats" runat="server" style="color:red">Opps Sorry Event Reached Maximum Seats !!</asp:Label>
                                   </div>
                                   <div class="col-md-2"></div>
                               </div>
                               
                               </div>
                        </div>

                    </div>

                </div>

            </div>

           </div>--%>



    <div class="pages">
        <div data-page="projects" class="page ">
            <div class="page-content">

                <div id="pages_maincontent">

                    <h2 class="page_title">Registration Form</h2>

                    <div class="page_content">

                        <div class="contactform">
                            <form>

                                <label>Name:</label>
                                <input type="text" name="name" value="" class="form_input" />

                                <label>Email:</label>
                                <input type="text" name="email" value="" class="form_input" />

                                <label>Phone:</label>
                                <input type="text" name="email" value="" class="form_input" />

                                <label>Birth date:</label>
                                <asp:TextBox ID="txtdob" runat="server" type="date" class="form_input required" placeholder="Date Of Birth"></asp:TextBox>

                                <label>Choose:</label>
                                <div class="selector_overlay">
                                    <select class="cs-select cs-skin-overlay selectoptions">
                                        <option value="" disabled="disabled" selected>select options</option>
                                        <option value="1">select one</option>
                                        <option value="2">select two</option>
                                        <option value="3">select three</option>
                                        <option value="4">select four</option>
                                        <option value="5">select five</option>
                                    </select>
                                </div>
                                <label>Choose:</label>
                                <div class="selector_overlay">
                                    <select class="cs-select cs-skin-overlay selectoptions">
                                        <option value="" disabled="disabled" selected>select options</option>
                                        <option value="1">select one</option>
                                        <option value="2">select two</option>
                                        <option value="3">select three</option>
                                        <option value="4">select four</option>
                                        <option value="5">select five</option>
                                    </select>
                                </div>
                                <label>Choose:</label>
                                <div class="selector_overlay">
                                    <select class="cs-select cs-skin-overlay selectoptions">
                                        <option value="" disabled="disabled" selected>select options</option>
                                        <option value="1">select one</option>
                                        <option value="2">select two</option>
                                        <option value="3">select three</option>
                                        <option value="4">select four</option>
                                        <option value="5">select five</option>
                                    </select>
                                </div>
                                <label>Hear About Us:</label>
                                <input type="text" name="name" value="" class="form_input" />

                                <label>Select:</label>
                                <div class="selector_overlay">
                                    <select class="cs-select cs-skin-overlay selectoptions">
                                        <option value="" disabled="disabled" selected>select options</option>
                                        <option>Alabama</option>
                                        <option>Alaska</option>
                                        <option>Arizona</option>
                                        <option>Arkansas</option>
                                        <option>California</option>
                                        <option>Colorado</option>
                                        <option>Connecticut</option>
                                        <option>District of Columbia</option>
                                        <option>Delaware</option>
                                        <option>Florida</option>
                                        <option>Georgia</option>
                                        <option>Hawaii</option>
                                        <option>Idaho</option>
                                        <option>Illinois</option>
                                        <option>Indiana</option>
                                        <option>Iowa</option>
                                        <option>Kansas</option>
                                        <option>Kentucky</option>
                                        <option>Louisiana</option>
                                        <option>Maine</option>
                                        <option>Maryland</option>
                                        <option>Massachusetts</option>
                                        <option>Michigan</option>
                                        <option>Minnesota</option>
                                        <option>Mississippi</option>
                                        <option>Missouri</option>
                                        <option>Montana</option>
                                        <option>Nebraska</option>
                                        <option>Nevada</option>
                                        <option>New Hampshire</option>
                                        <option>New Jersey</option>
                                        <option>New Mexico</option>
                                        <option>New York</option>
                                        <option>North Carolina</option>
                                        <option>North Dakota</option>
                                        <option>Ohio</option>
                                        <option>Oklahoma</option>
                                        <option>Oregon</option>
                                        <option>Pennsylvania</option>
                                        <option>Rhode Island</option>
                                        <option>South Carolina</option>
                                        <option>South Dakota</option>
                                        <option>Tennessee</option>
                                        <option>Texas</option>
                                        <option>Utah</option>
                                        <option>Vermont</option>
                                        <option>Virginia</option>
                                        <option>Washington</option>
                                        <option>West Virginia</option>
                                        <option>Wisconsin</option>
                                        <option>Wyoming</option>

                                    </select>
                                </div>

                                <label>Gender:</label>
                                <label class="label-radio item-content">
                                    <!-- Checked by default -->
                                    <input type="radio" name="my-radio" value="Books" checked="checked">
                                    <div class="item-inner">
                                        <div class="item-title">Male</div>
                                    </div>
                                </label>

                                <label class="label-radio item-content">
                                    <!-- Checked by default -->
                                    <input type="radio" name="my-radio" value="Movies">
                                    <div class="item-inner">
                                        <div class="item-title">Female</div>
                                    </div>
                                </label>

                                <label>Choose:</label>

                                <label class="label-checkbox item-content">
                                    <!-- Checked by default -->
                                    <input type="checkbox" name="my-checkbox" value="Phone" checked="checked">
                                    <div class="item-media">
                                        <i class="icon icon-form-checkbox"></i>
                                    </div>
                                    <div class="item-inner">
                                        <div class="item-title">Phone</div>
                                    </div>
                                </label>

                                <label class="label-checkbox item-content">
                                    <input type="checkbox" name="my-checkbox" value="Email">
                                    <div class="item-media">
                                        <i class="icon icon-form-checkbox"></i>
                                    </div>
                                    <div class="item-inner">
                                        <div class="item-title">Email</div>
                                    </div>
                                </label>


                                <input type="submit" name="submit" class="form_submit" id="submit" value="Send" />
                            </form>
                        </div>



                    </div>

                </div>
              
            </div>

        </div>

    </div>


</asp:Content>

