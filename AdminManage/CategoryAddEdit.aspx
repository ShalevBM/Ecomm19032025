<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryAddEdit.aspx.cs" Inherits="Ecomm19032025.AdminManage.CategoryAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
        <h2 class="page-title">Edit/Add Category</h2>
<p class="text-muted">Write a Category Details and Save in the end</p>
<div class="card-deck">
    <div class="card shadow mb-4">
        <div class="card-header">
            <strong class="card-title">Category Details</strong>
        </div>
        <div class="card-body">

            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="TxtCid">Category ID</label>
                    <asp:TextBox ID="TxtCid" runat="server" class="form-control" placeholder="Enter Category ID" />
                </div>
                <div class="form-group col-md-6">
                    <label for="TxtCName">CName</label>
                    <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
                    <asp:TextBox ID="TxtCName" runat="server" class="form-control" placeholder="Enter Category Name" />
                </div>
            </div>
            </div>
            <asp:Button ID="BtnSave" Text="Save" runat="server" class="btn btn-primary" OnClick="BtnSave_Click"></asp:Button>


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
