<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff</title>
</head>
<body style="background-color: rgba(204, 229, 251, 0.65); text-align: center">
    <form id="form1" runat="server">
        <div>
            <h2 style="font-family: Bahnschrift">Details of Staff</h2>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Staff_170905004ConnectionString %>" SelectCommand="SELECT * FROM [Staff]"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Name" DataSourceID="SqlDataSource1" OnRowDataBound="RowDataBound" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" style="margin: auto" HeaderStyle-Height="50px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:TemplateField HeaderText="Staff Details" SortExpression="Name">
                        <ItemTemplate>
                            <b>Name: </b>
                            <%#Eval("Name") %><br />
                            <b>Age: </b>
                            <%#Eval("Age") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
