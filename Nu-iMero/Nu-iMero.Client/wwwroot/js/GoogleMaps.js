let map;

window.initializeGoogleMap = (mapContainerId, latitude, longitude, zoom) => {
    const mapOptions = {
        center: { lat: latitude, lng: longitude },
        zoom: zoom,
    };
    map = new google.maps.Map(document.getElementById(mapContainerId), mapOptions);
};

window.addGoogleMapMarker = (latitude, longitude, title) => {
    const marker = new google.maps.Marker({
        position: { lat: latitude, lng: longitude },
        map: map,
        title: title,
    });
};