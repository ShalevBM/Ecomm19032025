<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="OrdersList.aspx.cs" Inherits="Ecomm19032025.AdminManage.OrdersList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h1>Orders Manage</h1>
    <table id="OrdersTable" class="table table-borderless table-hover">
        <thead>
            <tr>
                <th>OrderId</th>
                <th>Uid</th>
                <th>TotalPrice</th>
                <th>TotalAmount</th>
                <th>Status</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RptOrders" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("OrderId") %></td>
                        <td><%# Eval("Uid") %></td>
                        <td><%# Eval("TotalPrice") %></td>
                        <td><%# Eval("TotalAmount") %></td>
                        <td><%# Eval("Status") %></td>
                        <td>
                            <button class="btn btn-sm btn-outline-secondary dropdown-toggle" type="button" data-toggle="dropdown">
                                Action
                            </button>
                            <div class="dropdown-menu dropdown-menu-right">
                                <a class="dropdown-item" href="OrdersAddEdit.aspx?Uid=<%# Eval("Uid") %>">Edit</a>
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
    <script>
        $('#OrdersTable').DataTable(
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
