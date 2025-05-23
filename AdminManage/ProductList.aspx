﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Ecomm19032025.AdminManage.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/dataTables.bootstrap4.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h1>Product Manage</h1>
    <table id="ProductTable" class="table table-borderless table-hover">
        <thead>
            <tr>
                <th>Pid</th>
                <th>Pname</th>
                <th>price</th>
                <th>Pdesc</th>
                <th>Cid</th>
                <th>Status</th>
                <th>Picname</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RptProds" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Pid") %></td>
                        <td><%# Eval("Pname") %></td>
                        <td><%# Eval("Price") %></td>
                        <td><%# Eval("Pdesc") %></td>
                        <td><%# Eval("Cid") %></td>
                        <td><%# Eval("Status") %></td>
                        <td>
                            <img src='/Uploads/Prods/img/<%# Eval("Picname") %>' style="width: 80px; height: 80px;" />
                        </td>
                        <td>
                            <button class="btn btn-sm btn-outline-secondary dropdown-toggle" type="button" data-toggle="dropdown">
                                Action
                            </button>

                            <div class="dropdown-menu dropdown-menu-right">
                                <a class="dropdown-item" href="ProductAddEdit.aspx?Pid=<%# Eval("Pid") %>">Edit</a>
                                <a class="dropdown-item" href='ProductList.aspx?remove=<%# Eval("Pid") %>' onclick="return confirm('Are you sure you want to remove this product?');">Remove</a>
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
    <script>
        $('#ProductTable').DataTable(
            {
                autoWidth: true,
                "lengthMenu": [
                    [16, 32, 64, -1],
                    [16, 32, 64, "All"]
                ]
            });
    </script>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>
