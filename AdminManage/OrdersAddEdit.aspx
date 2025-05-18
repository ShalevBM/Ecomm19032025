<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="OrdersAddEdit.aspx.cs" Inherits="Ecomm19032025.AdminManage.OrdersAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
     <h2 class="page-title">Edit/Add Orders</h2>
 <p class="text-muted">Write a Order Details and Save in the end</p>
 <div class="card-deck">
     <div class="card shadow mb-4">
         <div class="card-header">
             <strong class="card-title">Order Details</strong>
         </div>
         <div class="card-body">

             <div class="form-row">
                 <div class="form-group col-md-6">
                     <label for="TxtUid">User Name</label>
                     <asp:TextBox ID="TxtUid" runat="server" class="form-control" placeholder="Enter User ID" />
                 </div>
                 <div class="form-group col-md-6">
                     <label for="TxtTotalPrice">Total Price</label>
                     <asp:TextBox ID="TxtTotalPrice" runat="server" class="form-control" placeholder="Enter Total Price" />
                 </div>
             </div>
             <div class="form-row">
                 <div class="form-group col-md-3">
                     <label for="TxtTotalAmount">Total Amount</label>
                     <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
                     <asp:TextBox ID="TxtTotalAmount" runat="server" class="form-control" placeholder="Enter Total Amount" />
                 </div>
                 <div class="form-group col-md-3">
                     <label for="DDLStatus">Product Status</label>
                     <asp:DropDownList ID="DDLStatus" runat="server" class="form-control">
                         <asp:ListItem Text="Active" Value="1"></asp:ListItem>
                         <asp:ListItem Text="Not Active" Value="0"></asp:ListItem>
                     </asp:DropDownList>
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
