<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="FrontEndBuscoChoza.Buscar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Busco Choza</title>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <meta charset="utf-8" />
    <!-- Bootstrap Core CSS -->
    <link href="CSS/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom CSS -->
    <link href="Content/scrolling-nav.css" rel="stylesheet" type="text/css" />
    <!-- Estilos para Mapa-->
    <link rel="stylesheet" href="Content/publ_GoogleMaps.css" />
	<!--[if lt IE 9]>
	<script src="//html5shiv.googlecode.com/svn/trunk/html5.js"></script>
	<![endif]-->
	<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false&q=Space+Needle,Seattle+WA"></script>
</head>
<body>
    <header class="navbar navbar-inverse col-xs-12">       
        <div class="container">
            <nav  role="navigation">
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
                            <a href="Perfil.aspx">Perfil</a>
                        </li>
                        <li class="page-scroll">
                            <a href="Publicar.aspx">Publicar</a>
                        </li>
                        <li class="page-scroll">
                            <a href="Principal.aspx">Cerrar Sesión</a>
                        </li>
                    </ul>
                </div>
            </nav><!-- /.navbar-collapse -->
        </div><!-- /.container -->
    </header>
    <div class="container">
        <div class="row">
            <div class="col-xs-12">
                <div class="panel panel-primary">
                    <div class ="panel-body">
                        <form id="Publicacion" runat="server">
                            <asp:Label ID="lbl_tituloPublicacion" runat="server" class="col-sm-6 col-sm-offset-3  col-xs-12 text-center text-primary" Text="Busque una propiedad" text-align="right"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="lbl_tipoPublicacion" class="col-sm-4 col-sm-offset-1  col-xs-12"  runat="server" Text="Tipo de Busqueda que desea realizar: "></asp:Label> 
                            <asp:DropDownList ID="ddl_tipoPublicacion" class="btn btn-primary col-sm-2 col-xs-12 dropdown-toggle" runat="server"  AutoPostBack="True" role="menu">
                                <asp:ListItem>Vender</asp:ListItem>
                                <asp:ListItem>Alquilar</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="lbl_tipoPropiedad" runat="server" class="col-sm-4 col-sm-offset-1  col-xs-12" Text="Tipo de propiedad"  ></asp:Label>  
                            <asp:DropDownList ID="ddl_tipoPropiedad" class="btn btn-primary col-sm-2 col-xs-12" runat="server" AutoPostBack="True">
                                <asp:ListItem>Casa</asp:ListItem>
                                <asp:ListItem>Apartamento</asp:ListItem>
                                <asp:ListItem>Oficina</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="lbl_ubicacion" runat="server" class="col-sm-6 col-sm-offset-3  col-xs-12" Text="Ingrese la ubicación de su propiedad" text-align="right"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="lbl_provincia" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Provincia:"></asp:Label>
                            <asp:DropDownList ID="ddl_provincia" class="btn btn-primary col-sm-2 col-xs-12" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_provincia_SelectedIndexChanged">
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="lbl_canton" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server"  Text="Cantón:"></asp:Label>
                            <asp:DropDownList ID="ddl_canton" class="btn btn-primary col-sm-2 col-xs-12" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_canton_SelectedIndexChanged">
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="lbl_distrito" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Distrito"></asp:Label>
                            <asp:DropDownList ID="ddl_distrito" class="btn btn-primary col-sm-2 col-xs-12" runat="server" AutoPostBack="True"  >
                            </asp:DropDownList>
                            <br />
                            <br />
                            <div class="col-sm-6 col-sm-offset-5  col-xs-8 col-xs-offset-4">
                                <asp:Button ID="btn_buscar"  class="btn btn-success" runat="server" OnClick="btn_buscar_Click" Text="Buscar" />
                            </div>  
                            <br />
                            <br /> 
                            <br />                            
                            <div class="panel panel-primary">
                                <div  class ="panel-heading">
                                    <asp:Label ID="lbl_resultado" class="col-sm-7 col-sm-offset-4 col-xs-12 col-xs-offset-1" runat="server" Text="El resultado de su busqueda es:" HorizontalAlign="Center"></asp:Label>
	                                <br />   
                                    <br />   
                                    <div id="canvas"></div>
                                </div>
                            </div>
	                        <br />
                            <asp:Label ID="lb_latitud" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Latitud:"></asp:Label>
                            <div class="input-group col-sm-2 col-xs-12">
                                    <asp:TextBox ID="latitud" class="form-control " ReadOnly="true" runat="server"></asp:TextBox>
                            </div>
	                        <br />
                            <asp:Label ID="lb_longitud" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Longitud:"></asp:Label>
                            <div class="input-group col-sm-2 col-xs-12">
                                    <asp:TextBox ID="longitud" class="form-control " ReadOnly="true" runat="server"></asp:TextBox>
                            </div> 
                            <div class="table-responsive col-sm-2 col-xs-12">
                                <asp:Label ID="lbl_resultadoBusqueda" runat="server"></asp:Label>
                                    <asp:GridView ID="dtg_resultadoBusqueda" class="table col-sm-12 col-xs-12 table-hover table-condensed" AutoGenerateSelectButton="True" runat="server" OnSelectedIndexChanged="dtg_resultadoBusqueda_onSelectedIndexChanged">   
                                    </asp:GridView>
                            </div>
                            <br />
                            
                                
                            
                            <br />
                        </form>
                    </div>
                </div>
            </div> 
        </div>
    </div> 
    <br />
    <!-- Core JavaScript Files -->
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery.easing.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="Scripts/scrolling-nav.js"></script>

    <!-- Script para Mapa -->
    <script type="text/javascript" src="Scripts/publ_GoogleMaps.js"></script>
</body>
</html>
