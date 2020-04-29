<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Introduzione.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-8">
            <div class="form-group">
                <div class="justify-content-center">
                    <label for="userID">scrivi user</label>
                    <asp:TextBox ID="userID" runat="server"></asp:TextBox>
                </div>

                <div class="justify-content-center">
                    <label for="pswID">scrivi psw</label>
                    <asp:TextBox ID="pswID" runat="server" TextMode="Password"></asp:TextBox>
                </div>

                <div class="justify-content-center">
                    <asp:Button ID="BTNSubmitLogin" runat="server" Text="Submit" OnClick="BTNSubmitLogin_Click" CssClass="btn btn-danger" />
                </div>

                <div class="row">
                    <asp:Label ID="LBLOutLogin" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
