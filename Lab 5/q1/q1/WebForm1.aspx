 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose the car manufacturer<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="124px">
                <asp:ListItem>Toyota</asp:ListItem>
                <asp:ListItem>Maruti</asp:ListItem>
                <asp:ListItem>Tesla</asp:ListItem>
                <asp:ListItem>BMW</asp:ListItem>
                <asp:ListItem>Honda</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Model Name:<br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="ControlChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
