﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Icecream.aspx.cs" Inherits="q3.Icecream" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Icecreams</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            Current price of Vanilla icecream: 
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            <br />

            <br />
            Enter new price of Vanilla icecream:
            <asp:TextBox ID="TextBox1" runat="server" style="vertical-align:middle" OnTextChanged="textChanged"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
