window.initMap = function (dotNetHelper) {
    var map = L.map('map').setView([51.505, -0.09], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    map.locate({setView: true, maxZoom: 10});
    
    L.control.locate().addTo(map);
    
    window.currentMarker = null;

    map.on('click', function(e) {
        var coordinates = e.latlng;
        
        if (window.currentMarker !== null) {
            map.removeLayer(window.currentMarker);
        }
        
        window.currentMarker = L.marker([coordinates.lat, coordinates.lng]).addTo(map);
        
        // Используем dotNetHelper для вызова нестатического метода ReceiveCoordinates
        dotNetHelper.invokeMethodAsync('ReceiveCoordinates', [coordinates.lat, coordinates.lng]);
    });
};
