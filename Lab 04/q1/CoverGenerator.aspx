﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoverGenerator.aspx.cs" Inherits="q4.CoverGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Front Cover Generator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: auto; width: 100%">
            <asp:Panel ID="ConfigureDiv" runat="server" style="padding: 15px; border-style: inset; border-width: medium; height: 705px; width: 300px; font-family: Calibri; font-size: medium; font-weight: bold; background-color: #5C87D8; position: absolute; z-index: auto; display: block; float: left; cursor: auto; clip: rect(auto, auto, auto, auto); color: #FFFFFF; top: 15px; left: 10px; overflow: scroll;">
                Choose the bacground image:<br />
                <asp:DropDownList ID="ImageDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChanged" Height="25px" Width="175px">
                    <asp:ListItem>None</asp:ListItem>
                    <asp:ListItem>Abstract Image 1</asp:ListItem>
                    <asp:ListItem>Abstract Image 2</asp:ListItem>
                    <asp:ListItem>Abstract Image 3</asp:ListItem>
                </asp:DropDownList><br /><br />
                Choose the background colour:<br />
                <asp:DropDownList ID="BackgoundDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ControlChanged" Height="25px" Width="175px"> </asp:DropDownList><br /><br />
                Choose the text colour:<br />
                <asp:DropDownList ID="TextDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChanged" Height="25px" Width="175px"></asp:DropDownList><br /><br />
                Choose the font name:<br />
                <asp:DropDownList ID="FontDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChanged" Height="25px" Width="175px"></asp:DropDownList><br /><br />
                Enter the font size:<br />
                <asp:TextBox ID="SizeTextBox" runat="server" AutoPostBack="true" OnTextChanged="ControlChanged" Height="16px" Width="175px"></asp:TextBox><br /><br />
                Choose the border style:<br />
                <asp:RadioButtonList ID="BorderRadioButtonList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ControlChanged" Height="23px" RepeatColumns="2" Width="175px">
                </asp:RadioButtonList><br />
                Enter the text to be displayed on the cover:<br />
                <asp:TextBox ID="GreetingsTextBox" runat="server" AutoPostBack="True" OnTextChanged="ControlChanged" Height="75px" Rows="2" TextMode="MultiLine" Width="175px"></asp:TextBox>
                <br /><br />
                <br />
                <asp:Button ID="PreviewButton" runat="server" Text="Preview" OnClick="PreviewButton_Click" Height="31px" Width="76px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ClearButton" runat="server" Text="Clear" OnClick="ClearButton_Click" Height="31px" Width="76px" />
                <br />
                <br />
                <br />
                <br />
                </asp:Panel>
            <asp:Panel ID="CoverPanel" runat="server" style="left: 355px; position: absolute; top:18px; background-position: center center" Height="545px" Width="358px" HorizontalAlign="Center">
                <br /><br />&nbsp;
                <asp:Label ID="GreetingsLabel" runat="server" Height="160px" Width="300px"></asp:Label>
                <br />
            </asp:Panel>
            <asp:Panel ID="EditButtonPanel" runat="server" style="left: 355px; position: absolute; top:583px" Height="30px" Width="358px" HorizontalAlign="Center">
                <asp:Button ID="Button1" runat="server" Text="Edit" OnClick="Button1_Click" Width="60px" Height="34px" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>