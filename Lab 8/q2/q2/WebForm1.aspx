<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Legends</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; margin-left: auto; margin-right: auto">
            Choose the genre: &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="100px" style="vertical-align: middle" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="120px" Width="150px" AutoPostBack="True" ></asp:ListBox>
            <br />
            <br />
            <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=Test;Integrated Security=True" SelectCommand="SelectCommand=&quot;SELECT name, age from Legends WHERE name=@name and category=@category&quot;" >
                <SelectParameters>
                    <asp:FormParameter DefaultValue="nam" FormField="ListBox1.SelectedItem.Text" Name="@name" />
                    <asp:FormParameter DefaultValue="cat" FormField="DropDownList1.SelectedItem.Text" Name="@category" />
                </SelectParameters>
            </asp:SqlDataSource>--%>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Test_170905004ConnectionString %>" SelectCommand="SELECT name, age FROM Legends WHERE name=@Name and category=@Category">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ListBox1" Name="Name" PropertyName="SelectedItem.Text" Type="String" />
                    <asp:ControlParameter ControlID="DropDownList1" Name="Category" PropertyName="SelectedItem.Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" style=" margin-left: auto; margin-right: auto">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <b>Name: </b>
                            <%#Eval("name") %>
                            <br />
                            <b>Age: </b>
                            <%#Eval("age") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            
        </div>
    </form>
</body>
</html>
