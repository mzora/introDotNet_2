﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Import.aspx.cs" Inherits="Introduzione.Import" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Import Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-8">
            <div class="form-group">
                <div class="justify-content-center">

                    <label for="InputNome">Nome</label>
                    <asp:TextBox ID="TXTNome" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="justify-content-center">
                    <label for="InputCognome">Cognome</label>
                    <asp:TextBox ID="TXTCognome" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="justify-content-center">
                    <label for="InputEta">Eta</label>
                    <asp:TextBox ID="TXTEta" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="justify-content-center">
                    <asp:Button ID="BTNSubmit" runat="server" Text="Submit" OnClick="BTNSubmit_Click" CssClass="btn btn-primary" />
                    <asp:Label ID="LBLOutput" runat="server"></asp:Label>
                </div>
            </div>
            <div class="col-12">
                <asp:GridView ID="GRDPerson" runat="server" CssClass="table table-striped table-borderless table-dark"></asp:GridView>
            </div>
        </div>
    </form>

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>