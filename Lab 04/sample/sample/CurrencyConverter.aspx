<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyConverter.aspx.cs" Inherits="sample.CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="lb">Input Currency: </asp:Label>
            <asp:TextBox runat="server" ID="inputCurrency" />
            <asp:Label ID="formLable" runat="server">From USD to: </asp:Label>
            <asp:DropDownList ID="fromCurrencyDropDown" runat="server" />
            <br /> <br />
            <asp:Label runat="server" ID="labelAns" />
            <br /> <br />
            <asp:Button Text="Convert!" OnClick="SubmitClickedEvent" runat="server" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
