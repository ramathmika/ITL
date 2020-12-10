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
            <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="145px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            Model Name:<br />
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="145px"></asp:TextBox>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
