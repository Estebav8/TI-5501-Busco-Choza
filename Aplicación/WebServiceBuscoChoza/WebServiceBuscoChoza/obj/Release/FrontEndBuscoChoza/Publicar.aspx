<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Publicar.aspx.cs" Inherits="FrontEndBuscoChoza.Publicar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <style type="text/css">
        .span6 {
            height: 36px;
        }
    </style>
</head>
<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top">
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
                            <a href="Buscar.aspx">Buscar</a>
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
                            <asp:Label ID="lbl_tituloPublicacion" runat="server" class="col-sm-6 col-sm-offset-3  col-xs-12 text-center text-primary" Text="Publique su propiedad" text-align="right"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="lbl_tipoPublicacion" class="col-sm-4 col-sm-offset-1  col-xs-12"  runat="server" Text="Tipo de Publicación que desea realizar: "></asp:Label> 
                            <asp:DropDownList ID="ddl_tipoPublicacion" class="btn btn-primary col-sm-2 col-xs-12 dropdown-toggle" runat="server" OnSelectedIndexChanged="ddl_tipoPublicacion_SelectedIndexChanged" AutoPostBack="True" role="menu">
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
                            <asp:DropDownList ID="ddl_provincia" class="btn btn-primary col-sm-2 col-xs-12" runat="server" AutoPostBack="True">
                                <asp:ListItem>San José</asp:ListItem>
                                <asp:ListItem>Cartago</asp:ListItem>
                                <asp:ListItem>Etc</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="lbl_canton" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server"  Text="Cantón:"></asp:Label>
                            <asp:DropDownList ID="ddl_canton" class="btn btn-primary col-sm-2 col-xs-12" runat="server" OnSelectedIndexChanged="ddl_canton_SelectedIndexChanged" AutoPostBack="True">
                                <asp:ListItem>Central</asp:ListItem>
                                <asp:ListItem>Etc</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="lbl_distrito" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Distrito"></asp:Label>
                            <asp:DropDownList ID="ddl_distrito" class="btn btn-primary col-sm-2 col-xs-12" runat="server" AutoPostBack="True" >
                                <asp:ListItem>Central</asp:ListItem>
                                <asp:ListItem>Etc</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="lbl_caracteristicas" class="col-sm-6 col-sm-offset-3  col-xs-12" runat="server" Text="Indique las caracteristicas de su propiedad" HorizontalAlign="Center"></asp:Label>
                            <br />  
                            <br />
                            <asp:Label ID="lbl_mtsTerreno" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Dimensión del Terreno:"></asp:Label>
                            <div class="input-group col-sm-2 col-xs-12">
                                <asp:TextBox ID="txt_mtsTerreno" class=" form-control " runat="server" ></asp:TextBox>
                                <span class="input-group-addon">m<sup>2</sup></span>
                            </div>
                            <br />
                            <asp:Label ID="lbl_mtsConstruccion" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Dimensión de la Construcción:"></asp:Label>
                            <div class="input-group col-sm-2 col-xs-12">
                                <asp:TextBox ID="txt_mtsConstruccion" class=" form-control " runat="server" ></asp:TextBox>
                                <span class="input-group-addon">m<sup>2</sup></span>
                            </div>
                            <br />
                            <asp:Label ID="lbl_precio" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server"></asp:Label>
                            <div class="input-group col-sm-2 col-xs-12">
                                <span class="input-group-addon">¢</span>
                                <asp:TextBox ID="txt_precio" class=" form-control " runat="server" ></asp:TextBox>
                                    
                            </div>
                            <br />
                            <asp:Label ID="lbl_habitaciones" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Habitaciones"></asp:Label>
                            <div class="input-group col-sm-2 col-xs-12">
                                <asp:TextBox ID="txt_habitaciones" class=" form-control " runat="server" ></asp:TextBox>
                            </div>
                            <br />
                            <asp:Label ID="lbl_bannos" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Baños"></asp:Label>
                            <div class="input-group col-sm-2 col-xs-12">
                                <asp:TextBox ID="txt_bannos" class=" form-control " runat="server" ></asp:TextBox>
                            </div>
                            <br />
                            <asp:CheckBox class="col-sm-4 col-sm-offset-1  col-xs-12 checkbox" ID="cbx_estacionamiento" runat="server" Text="Estacionamiento" /> 
                            <br />
                            <asp:Panel ID="pnl_casas" class="panel " runat="server">
                                <br />
                                <asp:CheckBox class="col-sm-4 col-sm-offset-1  col-xs-12 checkbox" ID="cbx_piscina" runat="server" Text="Piscina" />
                                <br />
                                <br />
                                <asp:CheckBox class="col-sm-4 col-sm-offset-1  col-xs-12 checkbox" ID="cbx_balcon" runat="server" Text="Balcón" />
                                <br />
                                <br />
                                <asp:CheckBox class="col-sm-4 col-sm-offset-1  col-xs-12 checkbox" ID="cbx_jardin" runat="server" Text="Jardín" />     
                            </asp:Panel>
                            <asp:Panel ID="pnl_apartamento_oficina" class="panel " runat="server">
                                <br />
                                <br />
                                <asp:Label ID="lbl_edificio" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Edificio en que se ubica:"></asp:Label>
                                <div class="input-group col-sm-2 col-xs-12">
                                    <asp:TextBox ID="txt_edificio" class=" form-control " runat="server" ></asp:TextBox>
                                </div>
                                <br />
                                <asp:Label ID="lbl_piso" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Piso en que se ubica:"></asp:Label>
                                <div class="input-group col-sm-2 col-xs-12 ">
                                    <asp:TextBox ID="TextBox1" class=" form-control " runat="server" ValidationExpression="\D"></asp:TextBox>
                                </div>
                                <br />
                                <asp:Label ID="lbl_apartamento_oficina" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" ></asp:Label>
                                <div class="input-group col-sm-2 col-xs-12 ">
                                    <asp:TextBox ID="txt_apartamento_oficina" class=" form-control " runat="server" ValidationExpression=""></asp:TextBox>
                                </div>     
                            </asp:Panel>
                            <asp:Panel ID="pnl_descripcion" class="panel " runat="server">
                                <br />
                                <br />
                                <asp:Label ID="lbl_descripcion" class="col-sm-4 col-sm-offset-1  col-xs-12" runat="server" Text="Descripción:"></asp:Label>
                                <div class="input-group col-sm-4 col-xs-12 ">
                                    <asp:TextBox ID="txt_descripción" TextMode="multiline" class=" form-control " runat="server" ></asp:TextBox>
                                </div>
                            </asp:Panel>
	                        <br />   
                            <br />                           
                            <div class="panel panel-primary">
                                <div  class ="panel-heading">
                                    <asp:Label ID="lbl_coloqueMarcador" class="col-sm-12 col-xs-12" runat="server" Text="Coloque el marcador sobre la propiedad" HorizontalAlign="Center"></asp:Label>
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
                            <br />
                            <div class="col-sm-6 col-sm-offset-5  col-xs-8 col-xs-offset-4">
                                <asp:Button ID="btn_publicar"  class="btn btn-success" runat="server" OnClick="btn_publicar_Click" Text="Publicar" />
                            </div> 
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
