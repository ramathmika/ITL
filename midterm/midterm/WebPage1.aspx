<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPage1.aspx.cs" Inherits="midterm.WebPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebPage1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 10px">

            Value:
            <asp:TextBox ID="ValueTextBox" runat="server" Height="16px" Width="120px" style="vertical-align: middle"></asp:TextBox>
            <br />
            <br />
            From:
            <asp:DropDownList ID="FromDropDownList" runat="server" Height="20px" Width="120px" style="vertical-align: middle">
            </asp:DropDownList>
            <br />
            <br />
            To:
            <asp:DropDownList ID="ToDropDownList" runat="server" Height="20px" Width="120px" style="vertical-align: middle">
            </asp:DropDownList>
            <br />
            <br />
            You are:<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
            <br />
            <br />
            <br />
            <asp:Button ID="ConvertButton" runat="server" Text="CONVERT" OnClick="ConvertButton_Click" Height="30px" Width="105px" />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="CounterButton" runat="server" Text="COUNTER" OnClick="CounterButton_Click" Height="30px" Width="105px" />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

            <br />
            <br />

            <br />

            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
