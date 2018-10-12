<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="add_product.aspx.cs" Inherits="add_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Add Product
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">

     <div id="mainform">
         <br />
         <asp:TextBox ID="productNameTxt" CssClass="textbox" placeholder="Product Name" runat="server"></asp:TextBox>
         <br />
         <asp:TextBox ID="descriptionTxt" CssClass="textbox" placeholder="Product Description" runat="server"></asp:TextBox>
         <br />
         <asp:TextBox ID="image" CssClass="textbox" placeholder="image" runat="server"></asp:TextBox>
         <br />
         <asp:TextBox ID="priceTxt" CssClass="textbox" placeholder="Product Price" runat="server" TextMode="Number"></asp:TextBox>
         <br />
         <asp:DropDownList ID="StatusList" CssClass="dropdownlist" runat="server">
             <asp:ListItem Text="Active" Value="1" Selected="True"></asp:ListItem>
             <asp:ListItem Text="Not Active" Value="0"></asp:ListItem>
         </asp:DropDownList>
         <br />
         <asp:Button ID="save" CssClass="btn" runat="server" Text="ADD" OnClick="save_Click" />
         
     </div>
</asp:Content>

