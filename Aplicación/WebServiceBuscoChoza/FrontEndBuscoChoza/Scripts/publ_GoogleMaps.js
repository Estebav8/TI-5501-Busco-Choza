// Variables de Configuracion
var _zoom 				= 12;
var _arrastre 			= true;
var _largoCoordenada 	= 6;
var _latitudInicial 	= 9.859953;
var _longitudInicial 	= -83.928607;

// Crea el Mapa
// Aplica el zoom
// Centra el mapa en coordenada
// Selecciona el tipo de mapa
var _mapa = new google.maps.Map(document.getElementById('canvas'), {
	zoom: _zoom,
	center: new google.maps.LatLng(_latitudInicial, _longitudInicial),
	mapTypeId: google.maps.MapTypeId.HYBRID
});

// Creacion del marcador
var _marcador = new google.maps.Marker({
	position: new google.maps.LatLng(_latitudInicial, _longitudInicial),
	draggable: _arrastre
});

// Agrega un listener al marcador
// Brinda las coordenadas cuando el marcador se detiene
// Carga en pantalla las nuevas coordenadas
google.maps.event.addListener(_marcador, 'dragend', function(evt){
	document.getElementById('latitud').value = evt.latLng.lat();//.toFixed(_largoCoordenada);
	document.getElementById('longitud').value = evt.latLng.lng();//.toFixed(_largoCoordenada);
});

// Centra el mapa en las nuevas coordenadas del marcador
_mapa.setCenter(_marcador.position);

// Agrega el marcador al mapa
_marcador.setMap(_mapa);