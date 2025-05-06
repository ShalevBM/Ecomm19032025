<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Ecomm19032025.AdminManage.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/dataTables.bootstrap4.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h1>Product Manage</h1>
    <table class="table table-borderless table-hover">
      <thead>
        <tr>
          <th>Pid</th>
          <th>Pname</th>
          <th>price</th>
          <th>Picname</th>
          <th>Manage</th>
        </tr>
      </thead>
        <tbody>
            <asp:Repeater ID="RptProds" runat="server">
                <ItemTemplate>
                 <tr>
                    <td><%# Eval("Pid") %></td>
                    <td><%# Eval("Pname") %></td>
                    <td><%# Eval("Price") %></td>
                    <td><img src="/uploads/prods/img/<%# Eval("Picname") %>" class="avatar-img rounded-circle" width="40"/></td>
                    <td>
                    <button class="btn btn-sm dropdown-toggle more-horizontal" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <span class="text-muted sr-only">Manage</span>
                    </button>
                    <div class="dropdown-menu dropdown-menu-right">
                        <a class="dropdown-item" href="ProductAddEdit.aspx?Pid=<%# Eval("Pid") %>">Edit</a>
                        <a class="dropdown-item" href="#">Remove</a>
                    </div>
                    </td>
                 </tr>
                </ItemTemplate>
            </asp:Repeater>
           
        </tbody>
      
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
    <script src='js/jquery.dataTables.min.js'></script>
    <script src='js/dataTables.bootstrap4.min.js'></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>
