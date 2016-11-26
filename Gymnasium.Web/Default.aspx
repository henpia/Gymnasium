<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gymnasium.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="page-header">
            <h1>Udby Gymnasium</h1>
            <p class="lead">Administration af Udby Gymnasium</p>
        </div>

        <h3>Lærer:</h3>
        <asp:Button CssClass="btn btn-lg btn-primary" ID="nyLærerButton" runat="server" Text="Ny Lærer" OnClick="nyLærerButton_Click" />
        &nbsp;
        <asp:Button CssClass="btn btn-lg btn-primary" ID="listeLærerButton" runat="server" Text="Liste over Lærere" OnClick="listeLærerButton_Click" />

        <h3>Fag:</h3>
        <asp:Button CssClass="btn btn-lg btn-primary" ID="nytFagButton" runat="server" Text="Nyt Fag" OnClick="nytFagButton_Click" />
        &nbsp;
        <asp:Button CssClass="btn btn-lg btn-primary" ID="listeFagButton" runat="server" Text="Liste over Fag" OnClick="listeFagButton_Click" />

        <h3>Elev:</h3>
        <asp:Button CssClass="btn btn-lg btn-primary" ID="nyElevButton" runat="server" Text="Ny Elev" OnClick="nyElevButton_Click" />
        &nbsp;
        <asp:Button CssClass="btn btn-lg btn-primary" ID="listeElevButton" runat="server" Text="Liste over Elever" OnClick="listeElevButton_Click" />


    </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
