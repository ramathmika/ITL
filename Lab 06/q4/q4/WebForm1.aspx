<%@ Page Title="ContentPage1" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q4.WebForm1" StylesheetTheme="Default"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="IndexChanged">
    </asp:DropDownList>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Go to next page" OnClick="Button1_Click" />
</asp:Content>
