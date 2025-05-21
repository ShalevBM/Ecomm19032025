<%@ Page Title="" Language="C#" ValidateRequest="false" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductAddEdit.aspx.cs" Inherits="Ecomm19032025.AdminManage.ProductAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="tinymce/tinymce.min.js"></script>
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
                        <asp:TextBox ID="TxtPName" runat="server" class="form-control" placeholder="Enter Product Name" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TxtPrice">Price</label>
                        <asp:TextBox ID="TxtPrice" runat="server" class="form-control" placeholder="Enter Product Price" />
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-4">
                        <label for="TxtPicname">Product Picture</label>
                        <asp:FileUpload ID="UplPic" runat="server" />
                        <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
                        <asp:TextBox ID="TxtPicname" runat="server" class="form-control" placeholder="Enter Product Picture" Visible="false" />
                        
                    </div>
                    <div class="form-group col-md-4">
                        <label for="DDLCategory">Product Category</label>
                        <asp:DropDownList ID="DDLCategory" runat="server" class="form-control" />
                    </div>
                    <div class="form-group col-md-4">
                        <label for="DDLStatus">Product Status</label>
                        <asp:DropDownList ID="DDLStatus" runat="server" class="form-control">
                            <asp:ListItem Text="Active" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Not Active" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-md-12">
                        <label for="TxtPdesc">Description</label>
                        <asp:TextBox ID="TxtPdesc" runat="server" class="form-control" TextMode="MultiLine" Columns="40" Rows="10" placeholder="Enter Product Description" />
                    </div>
                </div>
                <asp:Button ID="BtnSave" Text="Save" runat="server" class="btn btn-primary" OnClick="BtnSave_Click"></asp:Button>


            </div>

        </div>

    </div>
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
    <script>
        tinymce.init({
            selector: '#MainCnt_TxtPdesc',
            height: 500,
            plugins: [
                'advlist', 'autolink', 'lists', 'link', 'image', 'charmap', 'preview',
                'anchor', 'searchreplace', 'visualblocks', 'code', 'fullscreen',
                'insertdatetime', 'media', 'table', 'help', 'wordcount'
            ],
            toolbar: 'undo redo | blocks | ' +
                'bold italic backcolor | alignleft aligncenter ' +
                'alignright alignjustify | bullist numlist outdent indent | ' +
                'removeformat | help',
            content_style: 'body { font-family:Helvetica,Arial,sans-serif; font-size:16px }'
        });
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>
