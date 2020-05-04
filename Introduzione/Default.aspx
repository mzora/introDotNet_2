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
        <div class="container col-12 no-gutters">
            <div id="formBox" class="col-sm-2 offset-sm-5">
                <div id="formItem" class="form-group">
                    <label for="userID">USERNAME:</label>
                    <asp:TextBox ID="userID" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div id="formItem" class="form-group">
                    <label for="pswID">PASSWORD:</label>
                    <asp:TextBox ID="pswID" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>

                <div id="formItemBtn" class="form-group">
                    <asp:Button ID="BTNSubmitLogin" runat="server" Text="Submit" OnClick="BTNSubmitLogin_Click" CssClass="btn btn-outline-light" />
                </div>

                <div class="form-group">
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