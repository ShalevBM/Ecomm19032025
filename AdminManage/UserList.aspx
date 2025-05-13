<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Ecomm19032025.AdminManage.UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h1>User Manage</h1>
    <table id="UserTable" class="table table-borderless table-hover">
        <thead>
            <tr>
                <th>Uid</th>
                <th>FullName</th>
                <th>Pass</th>
                <th>Email</th>
                <th>Phone</th>
                <th>Address</th>
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="RptProds" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Uid") %></td>
                        <td><%# Eval("FullName") %></td>
                        <td><%# Eval("Pass") %></td>
                        <td><%# Eval("Email") %></td>
                        <td><%# Eval("Phone") %></td>
                        <td><%# Eval("Address") %></td>
                        <td>
                        <button class="btn btn-sm btn-outline-secondary dropdown-toggle" type="button" data-toggle="dropdown">
                            Action
                        </button>
                        <div class="dropdown-menu dropdown-menu-right">
                            <a class="dropdown-item" href="UserAddEdit.aspx?Uid=<%# Eval("Uid") %>">Edit</a>
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
        $('#UserTable').DataTable(
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
