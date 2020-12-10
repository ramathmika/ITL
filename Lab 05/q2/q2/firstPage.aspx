<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstPage.aspx.cs" Inherits="q2.firstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>firstPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="NameTextBox" runat="server" Height="20px" Width="145px" style="vertical-align: middle" ></asp:TextBox>
            <br />
            <br />
            Roll Number:
            <asp:TextBox ID="RollTextBox" runat="server" Height="20px" Width="145px" style="vertical-align: middle"></asp:TextBox>
            <br />
            <br />
            Subject:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="SubjectDropDownList" runat="server" Height="25px" Width="145px" style="vertical-align: middle">
                <asp:ListItem>English</asp:ListItem>
                <asp:ListItem>Math</asp:ListItem>
                <asp:ListItem>Science</asp:ListItem>
                <asp:ListItem>Economics</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="GoButton" runat="server" Text="Go to Page 2" OnClick="GoButton_Click"/>
        </div>
    </form>
</body>
</html>
