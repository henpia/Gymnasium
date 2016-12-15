<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FagListe.aspx.cs" Inherits="Gymnasium.Web.FagListe" %>

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
            <p class="lead">Liste over Fag</p>
        </div>

        <asp:GridView ID="fagListeGridView" runat="server" AutoGenerateColumns="False" OnRowCommand="fagListeGridView_RowCommand" OnSelectedIndexChanged="fagListeGridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="fagId" HeaderText="Fag Id" />
                <asp:BoundField DataField="Navn" HeaderText="Navn" />
                <asp:BoundField DataField="Beskrivelse" HeaderText="Beskrivelse" />
                <asp:ButtonField Text="Slet" />
            </Columns>
        </asp:GridView>
        <p>&nbsp;</p>
        <asp:Button CssClass="btn btn-lg btn-primary" ID="tilbageButton" runat="server" Text="Tilbage" OnClick="tilbageButton_Click" />
        &nbsp;
        <asp:Button CssClass="btn btn-lg btn-primary" ID="slettedeFagButton" runat="server" Text="Slettede Fag" OnClick="slettedeFagButton_Click" />
    </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
