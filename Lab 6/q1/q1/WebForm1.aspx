<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Election 2017</title>
    <style>
        body h2{
            font-weight: bolder;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: 'Century Gothic'; background-color: #99CCFF; width:100%; text-align: center; overflow: scroll; height: 100%; font-size: medium; font-weight: bold;">
            <br />
            <br />
            <br />
            <h2>STUDENT HOUSE PRESIDENT ELECTION</h2><br />
            Choose a candidate:&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="28px" Width="128px" style="vertical-align: middle; margin-left: 2px">
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
            </asp:DropDownList>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please choose a candidate" Display="None" ControlToValidate="DropDownList1"></asp:RequiredFieldValidator>
            <br />
            <br />
            House:&nbsp;
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="display: inline; vertical-align: top; text-align:left; margin-left: 55px">
                <asp:ListItem>Emerald</asp:ListItem>
                <asp:ListItem>Ruby</asp:ListItem>
                <asp:ListItem>Sapphire</asp:ListItem>
                <asp:ListItem>Topaz</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please choose a house" Display="None" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>

            <br />
            <br />

            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class:&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" style="vertical-align: middle; margin-left: 105px" Width="138px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="You must be studying in Class 6-12" Display="None" ControlToValidate="TextBox1" MaximumValue="12" MinimumValue="6" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            Email id:
            <asp:TextBox ID="TextBox2" runat="server" style="vertical-align: middle; margin-left: 95px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter your email-id" Display="None" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter correct email id" Display="None" ValidationExpression="\S+@\S+\.\S+" ControlToValidate="TextBox2"></asp:RegularExpressionValidator>
            <br />
            <br />
            Parent Phone Number:
            <asp:TextBox ID="TextBox3" runat="server" Width="143px" style="vertical-align: middle"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please enter a 10 digit number" ValidateEmptyText="false" OnServerValidate="val_Phone" ControlToValidate="TextBox3" Display="None" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#B9DCFF" ForeColor="Black" Height="31px" Width="72px" style="font-family: 'Century Gothic'; font-weight: bold" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>
            <asp:ValidationSummary ID="errors" runat="server" ShowMessageBox="true" ShowSummary="false" />
        </div>
    </form>
</body>
</html>
