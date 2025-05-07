<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductAddEdit.aspx.cs" Inherits="Ecomm19032025.AdminManage.ProductAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h2 class="page-title">Edit/Add Product</h2>
    <p class="text-muted">Write a Product Details and Save in the end</p>
    <div class="card-deck">
        <div class="card shadow mb-4">
            <div class="card-header">
                <strong class="card-title">Product Details</strong>
            </div>
            <div class="card-body">

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="TxtPName">Product Name</label>
                        <asp:TextBox ID="TxtPName" runat="server" class="form-control" placeholder="Enter Product Details" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TxtPrice">Price</label>
                        <asp:TextBox ID="TxtPrice" runat="server" class="form-control" placeholder="Enter Product Price" />
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-3">
                        <label for="TxtPicname">Product Picture</label>
                        <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
                        <asp:TextBox ID="TxtPicname" runat="server" class="form-control" placeholder="Enter Product Picture" />
                    </div>
                    <div class="form-group col-md-3">
                        <label for="TxtPicname">Product Category</label>
                        <asp:DropDownList ID="DDLCategory" runat="server" class="form-control" />

                    </div>
                    <div class="form-group col-md-6">
                        <label for="TxtPdesc">Description</label>
                        <asp:TextBox ID="TxtPdesc" runat="server" class="form-control" TextMode="MultiLine" Columns="40" Rows="10" placeholder="Enter Product Description" />
                    </div>
                </div>
                <asp:Button ID="BtnSave" Text="Save" runat="server" class="btn btn-primary" ></asp:Button>


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
