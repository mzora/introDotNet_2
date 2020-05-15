<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Import.aspx.cs" Inherits="Introduzione.Import" %>

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
        <div id="container" class="container col-10 pt-4">
            <div id="lblLogged" class="col-6">
                <asp:Label ID="LBLLoggedName" runat="server"></asp:Label>
            </div>

            <div id="insertBox" class="col-6 offset-6 py-1 mb-2">
                <div class="form-group">
                    <label for="InputUsername">Username</label>
                    <asp:TextBox ID="TXTUsername" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="InputPsw">Password</label>
                    <asp:TextBox ID="TXTPsw" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="InputNome">Nome</label>
                    <asp:TextBox ID="TXTNome" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="InputCognome">Cognome</label>
                    <asp:TextBox ID="TXTCognome" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="InputEta">Eta</label>
                    <asp:TextBox ID="TXTEta" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group text-center">
                    <asp:Button ID="BTNSubmit" runat="server" Text="Submit" OnClick="BTNSubmit_Click" CssClass="btn btn-info"/>
                </div>

                <asp:Label ID="LBLOutput" runat="server"></asp:Label>
            </div>

            <div class="form-group text-center">
                <asp:Button ID="BTNSubmitTab" runat="server" Text="Refresh Table" OnClick="BTNSubmitTab_Click" CssClass="btn btn-info" />
            </div>
                

            <div class="form-group col-12">
                <asp:GridView ID="GRDPerson" runat="server" OnRowDataBound="GRDPerson_RowDataBound" CssClass="table table-bordered"></asp:GridView>
            </div>
        </div>
    </form>

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
