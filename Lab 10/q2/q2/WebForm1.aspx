<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Authors</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="font-family: Bahnschrift; text-align: center">Authors</h2>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Author_170905004ConnectionString %>" SelectCommand="SELECT * FROM [Authors]" UpdateCommand="UPDATE Authors SET FirstName=@FirstName, CopiesSold=@CopiesSold WHERE Id=@Id"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowPaging="True" PageSize="3" HorizontalAlign="Center">
                <HeaderStyle BackColor="#339966" ForeColor="#990000" Font-Bold="true" />
                <Columns>
                    <asp:CommandField ShowEditButton="True" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" ItemStyle-HorizontalAlign="Center"/>
                    <asp:TemplateField HeaderText="Name" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <b>First Name: </b>
                            <%#Eval("FirstName") %>
                            <br /> 
                            <b>Last Name: </b>
                            <%#Eval("LastName") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <b>First Name: </b>
                            <asp:TextBox Text='<%#Bind("FirstName")%>' runat="server" ID="txtFirstName"></asp:TextBox>
                            <br /> 
                            <b>Last Name: </b>
                            <%#Eval("LastName") %>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Book Title" HeaderText="Book Title" SortExpression="Book Title" ReadOnly="true" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="CopiesSold" HeaderText="CopiesSold" SortExpression="CopiesSold" ItemStyle-HorizontalAlign="Center" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
