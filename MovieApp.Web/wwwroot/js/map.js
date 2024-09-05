function initMap(lat, lng) {
    //alert('initMap called with lat: ' + lat + ' lng: ' + lng); // Debug alert

    var location = { lat: lat, lng: lng };
    var map = new google.maps.Map(document.getElementById('map'), {
        center: location,
        zoom: 14
    });
    var marker = new google.maps.Marker({
        position: location,
        map: map
    });
}

function showMap(lat, lng) {
    //alert('ahowmap called with lat: ' + lat + ' lng: ' + lng); // Debug alert
    initMap(parseFloat(lat), parseFloat(lng)); // Ensure lat and lng are parsed as floats
    document.getElementById('map').style.display = 'block';
}