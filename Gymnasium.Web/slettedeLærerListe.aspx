﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="slettedeLærerListe.aspx.cs" Inherits="Gymnasium.Web.slettedeLærerListe" %>

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
            <p class="lead">Liste over Slettede Lærere</p>
        </div>

        <asp:GridView 
            CssClass="table table-bordered table-condensed table-hover table-responsive" 
            ID="slettedeLærereGridView" 
            runat="server" 
            AutoGenerateColumns="false" 
            OnRowCommand="slettedeLærereGridView_RowCommand">
            <Columns>
                <asp:BoundField DataField="LærerId" HeaderText="Lærer ID" />
                <asp:BoundField DataField="Cprnummer" HeaderText="CPR Nummer" />
                <asp:BoundField DataField="Navn" HeaderText="Navn" />
                <asp:BoundField DataField="Adresse" HeaderText="Adresse" />
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
