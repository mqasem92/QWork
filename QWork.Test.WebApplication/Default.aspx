﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QWork.Test.WebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fuTestControl" AllowMultiple="True" runat="server" />
            <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_OnClick" Text="Submit" />
        </div>
    </form>
</body>
</html>
