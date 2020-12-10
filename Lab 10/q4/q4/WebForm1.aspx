<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose a drive: 
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
