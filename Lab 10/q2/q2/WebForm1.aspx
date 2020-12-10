<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AuthorConnectionString %>" SelectCommand="SELECT * FROM [Author]" UpdateCommand="UPDATE Author SET FirstName=@FirstName, CopiesSold=@CopiesSold WHERE Id=@Id"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowPaging="True" PageSize="3" HeaderStyle-BackColor="Green" HeaderStyle-ForeColor="Red" HeaderStyle-Font-Bold="true">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id"/>
                    <asp:TemplateField HeaderText="Name">
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
                    <asp:BoundField DataField="Book Title" HeaderText="Book Title" SortExpression="Book Title" ReadOnly="true" />
                    <asp:BoundField DataField="CopiesSold" HeaderText="CopiesSold" SortExpression="CopiesSold" />
                </Columns>

<HeaderStyle BackColor="Green" Font-Bold="True" ForeColor="Red"></HeaderStyle>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
