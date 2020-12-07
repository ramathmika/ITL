<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JuiceShop.aspx.cs" Inherits="q1.JuiceShop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px">
            <h2>Fruits</h2>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
            <br />
            <br />
            <h2>Icecreams</h2>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Order" Height="30px" OnClick="Button1_Click" Width="75px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
