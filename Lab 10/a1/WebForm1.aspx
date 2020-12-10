<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="a1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="font-family: Bahnschrift; text-align: center">Products</h2>

            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Products_170905004ConnectionString %>" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE Product SET Name=@Name, Quantity=@Quantity WHERE Id=@Id"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowSorting="True" HorizontalAlign="Center">
                <HeaderStyle ForeColor="Black" Font-Bold="true" Font-Size="Medium"/>
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:TemplateField HeaderText="Name" SortExpression="Name">
                        <ItemTemplate>
                            <%#Eval("Name") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%#Bind("Name") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Required" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Details">
                        <ItemTemplate>
                            Price: 
                            <%#Eval("Price") %><br />
                            Quantity: 
                            <%#Eval("Quantity") %>
                            <br />
                            </ItemTemplate>
                        <EditItemTemplate>
                            Price: 
                            <%#Eval("Price") %><br />
                            Quantity: 
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%#Bind("Quantity") %>'></asp:TextBox>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Quantity has to be in the range of 1-20" ControlToValidate="TextBox1" MinimumValue="01" MaximumValue="20"></asp:RangeValidator>
                        </EditItemTemplate>
                        
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="true" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
