<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="addagegroups.aspx.cs" Inherits="Task_masterform_addagegroups" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div class="block">
        <div class="block-header block-header-default bg-primary">
                <h3 class="block-title text-white"><i class="fa fa-users"></i> Add Age Group</h3>
            </div>
        <!-- Form -->

        <!-- Steps Content -->
        <div class="block-content block-content-full tab-content">
            <!-- Step 1 -->
            <div class="tab-pane active" id="wizard-simple2-step1" role="tabpanel">
                
                <div class="row">
                    <div class="col-sm-4">
                        <div class="form-group">
                            <div class="form-material ">
                                <asp:TextBox ID="txtname" class="form-control cap" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="<%=txtname.ClientID %>">Age Group</label>
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
       <div class="block">
        <div class="block-header block-header-default bg-primary">
            <h3 class="block-title text-white"><i class="fa fa-users"></i> View Age Group</h3>

           <%-- <a href="addagegroups.aspx" class="btn btn-outline-dark" style="float:right">+ Add</a>--%>
        </div>
        <div class="block-content">
              <div class="table-responsive">
            <%=data %>
                  </div>
        </div>
    </div>
</asp:Content>

