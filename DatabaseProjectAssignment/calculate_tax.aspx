<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="calculate_tax.aspx.cs" Inherits="calculateTax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="Server">
    Calculate Tax
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="Server">
    <div id="mainform">
        <br />
        <asp:DropDownList ID="cityList" CssClass="dropdownlist" runat="server"></asp:DropDownList>
        <br />
        <asp:TextBox ID="subtotalTxt" CssClass="textbox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="taxBtn" CssClass="btn" runat="server" Text="Calculate Tax" OnClick="taxBtn_Click" />
        <br />
        <asp:Label ID="taxLabel" CssClass="labelMsg" runat="server" Visible="False"></asp:Label>
        <br />
        <div id="taxTable">
            <br />
            <asp:GridView ID="tax_Table" AutoGenerateColumns="false" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
                <Columns>
                    <asp:BoundField DataField="STATE" HeaderText="STATE" />
                    <asp:BoundField DataField="TAXRATE" HeaderText="Tax Rate" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>

