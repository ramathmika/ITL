<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Travel Packs</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=TravelPackage;Integrated Security=True" SelectCommand="SELECT place FROM Packs"></asp:SqlDataSource>
            <h3>Choose a travel pack:</h3>
            <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="place" Height="118px" Width="147px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Check Details" Height="30px" Width="120px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
