<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="order_status.aspx.cs" Inherits="order_status" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Order Status
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            padding: 12px 20px;
            margin-left: 150px;
            display: inline-block;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            text-align: center;
            font-size: x-large;
            margin-right: 0;
            margin-top: 8px;
            margin-bottom: 8px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" Runat="Server">
    <div id="mainform">
        <br />
        <asp:TextBox ID="basketIdTxt" CssClass="textbox" placeholder="Basket ID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="oarderStatus" CssClass="btn" runat="server" Text="Check Status" OnClick="oarderStatus_Click" />
        <br />
        <br />
        <asp:Label ID="StatusLbl" CssClass="labelMsg" runat="server" Visible="False"></asp:Label>
    </div>
</asp:Content>

