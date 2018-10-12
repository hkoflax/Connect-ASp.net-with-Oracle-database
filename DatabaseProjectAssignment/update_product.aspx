<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="update_product.aspx.cs" Inherits="updateProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Update Product
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">

    <div id="mainform">
        <br />
        <asp:DropDownList CssClass="dropdownlist" ID="NameList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="productNameTxt" CssClass="textbox" placeholder="Product Name" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="update" CssClass="btn" runat="server" Text="Update" OnClick="update_Click" />
    </div>

</asp:Content>

