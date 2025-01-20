// JavaScript function to trigger a download of the file
function downloadFile(filename, base64Data) {
    var link = document.createElement('a');
    link.href = 'data:application/pdf;base64,' + base64Data;
    link.download = filename;
    link.click();
}

function initializeGoogleMap(apiKey) {
    const script = document.createElement('script');
    script.src = `https://maps.googleapis.com/maps/api/js?key=${apiKey}&callback=initMap&libraries=maps,marker&v=beta`;
    script.async = true;
    script.defer = true;
    document.head.appendChild(script);
}

function initMap() {
    const mapElement = document.getElementById('map');
    if (!mapElement) {
        console.error('Map element not found');
        return;
    }

    const map = new google.maps.Map(mapElement, {
        center: { lat: 40.12150192260742, lng: -100.45039367675781 },
        zoom: 4,
        mapId: 'DEMO_MAP_ID',
    });

    new google.maps.marker.AdvancedMarkerView({
        map: map,
        position: { lat: 40.12150192260742, lng: -100.45039367675781 },
        title: "My location",
    });
}
