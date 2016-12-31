<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="slettedeFagListe.aspx.cs" Inherits="Gymnasium.Web.slettedeFagListe" %>

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
            <div class="lead">Liste over Slettede Fag</div> 
        </div>

        <asp:GridView 
            CssClass="table table-hover table-bordered table-condensed table-responsive" 
            ID="slettedeFagGridView" 
            runat="server" 
            AutoGenerateColumns="False" 
            OnRowCommand="slettedeFagGridView_RowCommand">
            <Columns>
                <asp:BoundField DataField="FagId" HeaderText="Fag Id" />
                <asp:BoundField DataField="Navn" HeaderText="Navn" />
                <asp:BoundField DataField="Beskrivelse" HeaderText="Beskrivelse" />
                <asp:ButtonField Text="Slet Permanent" />
            </Columns>
        </asp:GridView>

        <p>&nbsp;</p>
        <asp:Button CssClass="btn btn-lg btn-primary" ID="tilbageButton" runat="server" Text="Tilbage" OnClick="tilbageButton_Click" />
    
    </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
