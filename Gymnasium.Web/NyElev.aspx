<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NyElev.aspx.cs" Inherits="Gymnasium.Web.NyElev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>Udby Gymnasium</h1>
        Oprettelse af Elev

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

        <asp:Button ID="opretElevButton" runat="server" Text="Opret Elev" />
        <asp:Button ID="tilbageButton" runat="server" Text="Tilbage" />
    
    </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
