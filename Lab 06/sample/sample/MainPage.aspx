<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="sample.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="themeDropDown" runat="server" AutoPostBack="true" OnSelectedIndexChange="themeDropDown_SelectedIndexChanged" OnSelectedIndexChanged="themeDropDown_SelectedIndexChanged" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Theme Demo" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Text="" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Click Here" />
        </div>
    </form>
</body>
</html>
