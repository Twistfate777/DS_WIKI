<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" BorderStyle="Solid" ClientIDMode="AutoID" CssClass="auto-style1" Height="73px" Text="人物" Width="235px"></asp:Label>
            <asp:Button ID="Button1" runat="server" BorderStyle="Solid" Height="73px" Text="人物" Width="235px" />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="73px" ImageUrl="~/Images/NowLoadingBG.png" OnClick="ImageButton1_Click" Text="人物" Width="235px" />
        </div>
    </form>
</body>
</html>
