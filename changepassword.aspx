<%@ Page Title="" Language="C#" MasterPageFile="~/Department/admin/admin.master" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="changepassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="block">
        <div class="block-header block-header-default bg-primary">
                <h3 class="block-title text-white"><i class="fa fa-gear"></i> Change Password</h3>
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
                                <asp:TextBox ID="txtoldpass" class="form-control" required="" TextMode="Password" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="<%=txtoldpass.ClientID %>">Old Password</label>
                            </div>
                        </div>
                    </div>

                     <div class="col-sm-4">
                        <div class="form-group">
                            <div class="form-material ">
                                <asp:TextBox ID="txtnewpass" class="form-control" required="" TextMode="Password" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="<%=txtnewpass.ClientID %>">New Password</label>
                            </div>
                        </div>
                    </div>

                     <div class="col-sm-4">
                        <div class="form-group">
                            <div class="form-material ">
                                <asp:TextBox ID="txtconfirmpass" class="form-control" TextMode="Password" required="" runat="server" name="wizard-simple2-firstname"></asp:TextBox>
                                <label for="<%=txtconfirmpass.ClientID %>">Confirm Password</label>
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
                  
                   
                </div>
            </div>
        </div>
        <!-- END Steps Navigation -->
              </div>



     <script type="text/javascript">


         var password = document.getElementById("<%=txtnewpass.ClientID%>")
           , confirm_password = document.getElementById("<%=txtconfirmpass.ClientID%>");

        function validatePassword() {


            if (password.value != confirm_password.value) {
                confirm_password.setCustomValidity("Passwords Don't Match");
            } else {
                confirm_password.setCustomValidity('');
            }
        }

        password.onchange = validatePassword;
        confirm_password.onkeyup = validatePassword;
        oldpw.onkeyup = validatePassword;

</script>
    
</asp:Content>

