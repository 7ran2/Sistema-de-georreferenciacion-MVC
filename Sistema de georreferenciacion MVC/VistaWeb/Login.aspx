<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VistaWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="app/Styles/Main.css" rel="stylesheet" />
    <title></title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="formulario_login" runat="server">
                <div class="form-control">
                    <div class="col-md-6 text-center mb5">
                        <asp:Label class="h2" ID="Label3" runat="server" Text="Bienvennido /a al sistema"></asp:Label>
                    </div>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Nombre de usuario"></asp:TextBox> 
                    </div>
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtClave" runat="server" placeholder="Contraseña"></asp:TextBox>
                    </div>
                    <hr />
                    <div class="row">
                        <asp:Button CssClass="btn btn-primary btn-dark" ID="btnIngresar" runat="server" Text="Button" OnClick="btnIngresar_Click1" />
                    </div>
                </div>
                <div>
                    <asp:Label ID="Label4" runat="server" Text="Inicio"></asp:Label>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
