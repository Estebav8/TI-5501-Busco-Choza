<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="FrontEndBuscoChoza.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Busco Choza</title>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no"/>
    <meta charset="utf-8"/>
    <!-- Bootstrap Core CSS -->
    <link href="CSS/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom CSS -->
    <link href="Content/scrolling-nav.css" rel="stylesheet" type="text/css"/>
</head>
<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top">
    <header>
    <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header page-scroll">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#page-top">BuscoChoza.com</a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse navbar-ex1-collapse">
                <ul class="nav navbar-nav">
                    <!-- Hidden li included to remove active class from about link when scrolled up past about section -->
                    <li class="hidden">
                        <a href="#page-top"></a>
                    </li>
                    <li class="page-scroll">
                        <a href="#about">Iniciar Sesión</a>
                    </li>
                    <li class="page-scroll">
                        <a href="Publicar.aspx">Publicar</a>
                    </li>
                    <li class="page-scroll">
                        <a href="#contact">Contact</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>
    </header>
    <br />
    <br />
    <br />
    <br />
    <br />
    <section id="about" class="about-section">
     <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <div class="panel panel-primary">
                    <div class ="panel-body">
                        <form id="Iniciar" runat="server">
                            <asp:Label ID="lbl_inicioSesion" class="col-sm-5 col-sm-offset-3  col-xs-12 text-primary"  runat="server" Text="Iniciar Sesión "></asp:Label>
                            <br/>
                            <br/>
                            <asp:Label ID="lbl_correoInicio" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Correo:"></asp:Label>
                            <div class="input-group col-sm-4 col-xs-12">
                                <asp:TextBox ID="txt_correoInicio" class="form-control" runat="server" ></asp:TextBox>
                            </div>
                            <br />
                            <asp:Label ID="lbl_passwordInicio" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Contraseña:"></asp:Label>
                            <div class="input-group col-sm-4 col-xs-12">
                                <asp:TextBox ID="txt_passwordInicio" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                            <br />
                            <div class="col-sm-5 col-sm-offset-3  col-xs-12">
                                <asp:Button ID="btn_iniciarSesion"  class="btn btn-success" runat="server" OnClick="btn_iniciarSesion_Click" Text="Iniciar Sesión" />
                            </div>
                            <br />
                            <br />
                            <hr class="dl-horizontal"/>
                            <br />
                            <br />
                            <asp:Label ID="lbl_registro" class="col-sm-5 col-sm-offset-3  col-xs-12 text-primary"  runat="server" Text="Registrarse "></asp:Label>
                            <br/>
                            <br/>
                            <asp:Label ID="lbl_nombreRegistro" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Nombre de usuario:"></asp:Label>
                            <div class="input-group col-sm-4 col-xs-12">
                                <asp:TextBox ID="txt_nombreRegistro" class="form-control" runat="server" ></asp:TextBox>
                            </div>
                            <br />
                            <asp:Label ID="lbl_correoRegistro" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Correo:"></asp:Label>
                            <div class="input-group col-sm-4 col-xs-12">
                                <asp:TextBox ID="txt_correoRegistro" class="form-control" runat="server" ></asp:TextBox>
                            </div>
                            <br />
                            <asp:Label ID="lbl_passwordRegistro" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Contraseña:"></asp:Label>
                            <div class="input-group col-sm-4 col-xs-12">
                                <asp:TextBox ID="txt_passwordRegistro" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                            <br />
                            <asp:Label ID="lbl_telefono" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Telefono:"></asp:Label>
                            <div class="input-group col-sm-4 col-xs-12">
                                <asp:TextBox ID="txt_telefono" class="form-control" runat="server" ></asp:TextBox>
                            </div>
                            <br />
                            <asp:Label ID="lbl_direccion" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Dirección:"></asp:Label>
                            <div class="input-group col-sm-4 col-xs-12">
                                <asp:TextBox ID="txt_direccion" TextMode="multiline" class=" form-control " runat="server" ></asp:TextBox>
                            </div>
                            <br />
                            <div class="col-sm-5 col-sm-offset-3  col-xs-12">
                                <asp:Button ID="btn_registrar"  class="btn btn-success" OnClick="btn_registrarse_Click" runat="server"  Text="Registrarse" />
                            </div> 
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </section>

    <!-- Core JavaScript Files -->
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery.easing.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="Scripts/scrolling-nav.js"></script>
</body>
</html>
