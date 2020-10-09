﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="q2.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Employee Promotion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 15px; margin: 15px; height: 254px; width: 153px; font-size: small; font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;">
            <br />
            Select Employee ID:<br />
            <asp:DropDownList ID="EmployeeIDList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="UpdateInfo" Height="30px" Width="145px"></asp:DropDownList>&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            Name of Employee:<br />
            <asp:TextBox ID="EmployeeTextBox" runat="server" Height="20px" Width="145px"></asp:TextBox>
            <br />
            <br />
            Date of Joining:<br />
            <asp:TextBox ID="DOJTextBox" runat="server" Height="20px" Width="145px" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="EligibleButton" runat="server" Text="Am I Eligible?" OnClick="PrintResult" />
            <br />
            <br />
            <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        </div>
        <div style="left: 220px; position: absolute; top:44px; height: 100px; width: 111px;">

            <asp:Image ID="EmployeeImage" runat="server" Height="98px" Width="112px" />

        </div>
    </form>
</body>
</html>
