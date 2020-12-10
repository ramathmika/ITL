<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Details</title>
</head>
<body>
    <form id="form1" runat="server" style="text-align: center">
        <div>
            Select the staff_id:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="100px"></asp:DropDownList>
            <br /><br />
            Select the city:
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="95px" Width="105px">
                <asp:ListItem>Bangalore</asp:ListItem>
                <asp:ListItem>Manipal</asp:ListItem>
                <asp:ListItem>Chennai</asp:ListItem>
                <asp:ListItem>Jaipur</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
            </asp:ListBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Update City" Height="30px" Width="100px" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="View Details" Height="30px" Width="100px" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <%--<asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <asp:BoundField DataField="StaffID" HeaderText="ID" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                </Columns>
            </asp:GridView>--%>
        </div>
    </form>
</body>
</html>
