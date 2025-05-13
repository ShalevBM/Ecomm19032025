<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UserAddEdit.aspx.cs" Inherits="Ecomm19032025.AdminManage.UserAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h2 class="page-title">Edit/Add User</h2>
    <p class="text-muted">Write a User Details and Save in the end</p>
    <div class="card-deck">
        <div class="card shadow mb-4">
            <div class="card-header">
                <strong class="card-title">User Details</strong>
            </div>
            <div class="card-body">

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="TxtFullName">User Name</label>
                        <asp:TextBox ID="TxtFullName" runat="server" class="form-control" placeholder="Enter User Name" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TxtPass">Password</label>
                        <asp:TextBox ID="TxtPass" runat="server" class="form-control" placeholder="Enter User Password" />
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3">
                        <label for="TxtEmail">Email</label>
                        <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
                        <asp:TextBox ID="TxtEmail" runat="server" class="form-control" placeholder="Enter Email" />
                    </div>
                    <div class="form-group col-md-3">
                        <label for="TxtPhone">Phone</label>
                        <asp:TextBox ID="TxtPhone" runat="server" class="form-control" placeholder="Enter Phone Number" />
                    </div>
                    <div class="form-group col-md-3">
                        <label for="TxtAddress">Address</label>
                        <asp:TextBox ID="TxtAddress" runat="server" class="form-control" placeholder="Enter Address" />
                    </div>

                    <div class="form-group col-md-3">
                        <label for="DDLStatus">User Status</label>
                        <asp:DropDownList ID="DDLStatus" runat="server" class="form-control">
                            <asp:ListItem Text="Active" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Not Active" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                <asp:Button ID="BtnSave" Text="Save" runat="server" class="btn btn-primary" OnClick="BtnSave_Click" ></asp:Button>


            </div>

        </div>

    </div>
    <!-- / .card-desk-->
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>
