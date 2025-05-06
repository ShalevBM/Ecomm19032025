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
            <label for="TxtPname">Product Name:</label>
            <aspx:TextBox ID="TxtPname" runat="server" class="from-control" placeholder="Enter Product Details"></aspx:TextBox>
          </div>
          <div class="form-group col-md-6">
            <label for="TxtPrice">Price:</label>
             <aspx:TextBox ID="TxtPrice" runat="server" class="from-control" placeholder="Enter Product Price"></aspx:TextBox>
          </div>
        </div>
         <div class="form-row">
           <div class="form-group col-md-3">
             <label for="TxtPicname">Product Picture</label>
             <aspx:TextBox ID="TxtPicname" runat="server" class="from-control" placeholder="Enter Product Picture"></aspx:TextBox>
           </div>
             <div class="form-row">
              <div class="form-group col-md-3">
                <label for="TxtPicname">Product Category</label>
                  <aspx:DropDownList ID="DDLCategory" runat="server" class="from-control" />

              </div>
           <div class="form-group col-md-6">
             <label for="TxtPdesc">Description</label>
              <aspx:TextBox ID="TextPdesc" runat="server" class="from-control" TextMode="MultiLine" Columns="40" Rows="10" placeholder="Enter Product Description"></aspx:TextBox>
           </div>
         </div>
        <aspx:Button ID="BtnSave" Text="Save" runat="server" class="btn btn-primary"></aspx:Button>
       
     
    </div>
  </div>
  
</div> <!-- / .card-desk-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>
