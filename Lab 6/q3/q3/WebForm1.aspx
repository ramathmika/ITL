<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q3.WebForm1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Season Themes</title>
</head>
<body id="body1" style="text-align: center" runat="server">
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Select the Theme"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="ChangeTheme" AutoPostBack="true" >
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Monsoon</asp:ListItem>
                <asp:ListItem>Summer</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
