<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>City</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Choose a state:
            <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="145px" style="vertical-align:middle" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=City;Integrated Security=True" SelectCommand="SELECT CityName from City WHERE StateID=@StateID">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" DefaultValue="0" Name="StateID" PropertyName="SelectedValue" />
                </SelectParameters>

            </asp:SqlDataSource>
            Choose a city:
            <asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="145px" style="vertical-align:middle" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="CityName" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
