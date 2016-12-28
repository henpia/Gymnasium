<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LærerListe.aspx.cs" Inherits="Gymnasium.Web.LærerListe" %>

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
        <p class="lead">Liste over Lærere</p>
        </div>
        <asp:GridView CssClass="table table-bordered table-condensed table-hover table-responsive" ID="lærerListeGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="lærerListeGridView_RowCommand">
            <Columns>
                <asp:BoundField DataField="LærerId" HeaderText="Lærer ID" />
                <asp:BoundField DataField="CprNummer" HeaderText="Cpr Nummer" />
                <asp:BoundField DataField="Navn" HeaderText="Navn" />
                <asp:BoundField DataField="Adresse" HeaderText="Adresse" />
                <asp:ButtonField Text="Slet" />
            </Columns>
        </asp:GridView>
        <p>&nbsp;</p>
        <asp:Button CssClass="btn btn-lg btn-primary" ID="tilbageButton" runat="server" Text="Tilbage" OnClick="tilbageButton_Click" />
        <asp:Button CssClass="btn btn-lg btn-primary" ID="slettedeLærerButton" runat="server" Text="Slettede Fag" OnClick="slettedeLærerButton_Click" />
    </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
