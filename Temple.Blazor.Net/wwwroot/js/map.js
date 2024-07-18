window.currentMarker = null;

window.initMap = function () {
    var map = L.map('map').setView([51.505, -0.09], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    map.on('click', function(e) {
        var coordinates = e.latlng;
        
        // Если текущая метка существует, удаляем её
        if (window.currentMarker !== null) {
            map.removeLayer(window.currentMarker);
        }
        
        // Создаем новую метку и сохраняем ссылку на неё
        window.currentMarker = L.marker([coordinates.lat, coordinates.lng]).addTo(map);
        
        // Отправляем координаты в Blazor
        DotNet.invokeMethodAsync('Temple.Blazor.Net', 'ReceiveCoordinates', [coordinates.lat, coordinates.lng]);
    });
};
