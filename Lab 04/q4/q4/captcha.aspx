<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="captcha.aspx.cs" Inherits="q4.captcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Captcha</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 213px; width: 268px">
        &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp; Enter the text<br />
&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;
            <asp:Image ID="CaptchaImage" runat="server" Height="44px" ImageUrl="~/Images/botdetect-captcha-cut.jpg" Width="185px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="CaptchaTextBox" runat="server" style="margin-top: 0px" Width="157px" OnTextChanged="AttemptMade" AutoPostBack="true" Height="18px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
