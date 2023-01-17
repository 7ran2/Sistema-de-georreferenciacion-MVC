<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VW_Seguimientos.aspx.cs" Inherits="VistaWeb.VW_Seguimientos" %>

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
            <form id="formulario_seguimientos" runat="server">
                <div class="form-control">
                    <center>
                    <div class="col-md-6 text-center mb5">
                        <asp:Label class="h2" ID="Label3" runat="server" Text="Ingrese los datos del medidor"></asp:Label>
                    </div>
                        </center>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Litros"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtLitros" runat="server" placeholder="Ingrese solo numeros"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="Trayectoria o Sector"></asp:Label>
                    </div>
                    
                   <%-- <div>
                        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="txtClave" runat="server" placeholder="Contraseña"></asp:TextBox>
                    </div>--%>
                    <div>
                        <asp:DropDownList ID="ddlTrayectorias" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Label ID="lblUbicacion" runat="server" Text="Ubicacion de Punto de Medicion"></asp:Label>
                    <div>
                        <asp:DropDownList ID="ddlPosicion" runat="server">
                            <asp:ListItem Value="1">Inicial</asp:ListItem>
                            <%--<asp:ListItem Value="2">Punto 2</asp:ListItem>
                            <asp:ListItem Value="3">Punto 3</asp:ListItem>
                            <asp:ListItem Value="4">Punto 4</asp:ListItem>--%>
                            <asp:ListItem Value="5">Final</asp:ListItem>
                        </asp:DropDownList>
                    </div>    
                      <div class="row">
                        <asp:Button CssClass="btn btn-primary btn-dark" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    </div>
                </div>
                <asp:Button CssClass="btn btn-primary btn-green" ID="btnFinalizarTrayectoria" runat="server" Text="Finalizar trayectoria" OnClick="btnFinalizarTrayectoria_Click" />
                <div>
                    <asp:Label ID="Label4" runat="server" Text="Vacio"></asp:Label>
                </div>
                <hr />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </form>
            
            
        </div>
    </div>
</body>
</html>
