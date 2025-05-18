<%@ Page Title="" Language="C#" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="Ecomm19032025.AdminManage.CategoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
     <h1>Category Manage</h1>
 <table id="CategoryTable" class="table table-borderless table-hover">
     <thead>
         <tr>
             <th>Cid</th>
             <th>CName</th>
             <th>Action</th>
         </tr>
     </thead>
     <tbody>
         <asp:Repeater ID="RptCategory" runat="server">
             <ItemTemplate>
                 <tr>
                     <td><%# Eval("Cid") %></td>
                     <td><%# Eval("CName") %></td>
                     <td>
                         <button class="btn btn-sm btn-outline-secondary dropdown-toggle" type="button" data-toggle="dropdown">
                             Action
                         </button>
                         <div class="dropdown-menu dropdown-menu-right">
                             <a class="dropdown-item" href="CategoryAddEdit.aspx?Cid=<%# Eval("Cid") %>">Edit</a>
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
        $('#CategoryTable').DataTable(
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
