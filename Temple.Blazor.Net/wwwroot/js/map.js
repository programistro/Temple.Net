var map;
var currentMarker = null;
var enableClickToAddMarker = false;

window.initMap = function (dotNetHelper) {
    map = L.map('map').setView([51.505, -0.09], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    map.locate({setView: true, maxZoom: 10});
    
    L.control.locate().addTo(map);
    
    window.currentMarker = null;

    map.on('click', function(e) {
        if (!enableClickToAddMarker) return;
        var coordinates = e.latlng;
        
        if (window.currentMarker !== null) {
            map.removeLayer(window.currentMarker);
        }
        
        window.currentMarker = L.marker([coordinates.lat, coordinates.lng]).addTo(map);
        
        // Используем dotNetHelper для вызова нестатического метода ReceiveCoordinates
        dotNetHelper.invokeMethodAsync('ReceiveCoordinates', [coordinates.lat, coordinates.lng]);
    });
};

window.enableClickHandler = function() {
    enableClickToAddMarker = true;
};

// Функция для отключения обработчика клика
window.disableClickHandler = function() {
    enableClickToAddMarker = false;
};

window.addMarker = function(lat, lng) {
    // Удаление предыдущего маркера, если он есть
    if (window.currentMarker) {
        map.removeLayer(window.currentMarker);
    }

    // Создание нового маркера и добавление его на карту
    window.currentMarker = L.marker([lat, lng]).addTo(map);
};