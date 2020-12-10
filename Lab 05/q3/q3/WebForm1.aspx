<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shopping</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 204px">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Panel ID="Input_Panel" runat="server">
                <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="145px" style="vertical-align: middle"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Select items to add to cart"></asp:Label>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>Bag</asp:ListItem>
                    <asp:ListItem>Shoe</asp:ListItem>
                    <asp:ListItem>Glasses</asp:ListItem>
                    <asp:ListItem>Watch</asp:ListItem>
                    <asp:ListItem>T-Shirt</asp:ListItem>
                    <asp:ListItem>Sofa</asp:ListItem>
                </asp:CheckBoxList>
                <br />
            <br />
            </asp:Panel>
            
            <asp:Button ID="Button1" runat="server" Text="Continue Shopping" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
