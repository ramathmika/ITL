<%@ Page Title="Electronics" Language="C#" MasterPageFile="~/ecommMaster.Master" AutoEventWireup="true" CodeBehind="Electronics.aspx.cs" Inherits="q2.Electronics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Mobiles</h3>
    <asp:Image ID="Image1" runat="server" Width="100%" ImageUrl="~/Images/mobiles.jpg" Height="150px" /><br /><br />
    Vendors: <asp:DropDownList ID="DropDownList1" runat="server" style="vertical-align: middle" Height="16px" Width="103px">
        <asp:ListItem>Vendor1</asp:ListItem>
        <asp:ListItem>Vendor2</asp:ListItem>
        <asp:ListItem>Vendor3</asp:ListItem>
    </asp:DropDownList>
    <br /><br />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3>Laptops</h3>
    <asp:Image ID="Image2" runat="server" Width="100%" ImageUrl="~/Images/laptops.jpg" Height="150px" /><br /><br />
    Vendors: <asp:DropDownList ID="DropDownList2" runat="server" style="vertical-align: middle" Height="16px" Width="103px">
        <asp:ListItem>Vendor1</asp:ListItem>
        <asp:ListItem>Vendor2</asp:ListItem>
        <asp:ListItem>Vendor3</asp:ListItem>
    </asp:DropDownList>
    <br /><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <h3>Printers</h3>
    <asp:Image ID="Image3" runat="server" Width="100%" ImageUrl="~/Images/printers.png" Height="150px" /><br /><br />
    Vendors: <asp:DropDownList ID="DropDownList3" runat="server" style="vertical-align: middle" Height="16px" Width="103px">
        <asp:ListItem>Vendor1</asp:ListItem>
        <asp:ListItem>Vendor2</asp:ListItem>
        <asp:ListItem>Vendor3</asp:ListItem>
    </asp:DropDownList>
    <br /><br />
</asp:Content>
