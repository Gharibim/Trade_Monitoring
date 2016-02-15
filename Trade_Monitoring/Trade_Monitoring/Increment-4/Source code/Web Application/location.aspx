<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMaster.master" AutoEventWireup="true" CodeFile="location.aspx.cs" Inherits="location" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Middle" Runat="Server">

<script src="https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=false" type="text/javascript"></script>
<script type="text/javascript" src="http://google-maps-utility-library-v3.googlecode.com/svn/trunk/markerclusterer/src/markerclusterer.js"></script>
<script type="text/javascript">
  
    var address = "215 W. Pershing Road, 5th floor,Kansas City, MO 64108";
    function initialize() {
        geocoder = new google.maps.Geocoder();
        var directionsDisplay = new google.maps.DirectionsRenderer();
        var directionsService = new google.maps.DirectionsService();
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(function (position) {
                var lat = position.coords.latitude;
                var lng = position.coords.longitude;
                var pos = new google.maps.LatLng(lat, lng);
                var pinColor = "0B610B";
                var pinImage = new google.maps.MarkerImage("http://chart.apis.google.com/chart?chst=d_map_pin_letter&chld=%E2%80%A2|" + pinColor,
                    new google.maps.Size(21, 34),
                    new google.maps.Point(0, 0),
                    new google.maps.Point(10, 34));
                var pinShadow = new google.maps.MarkerImage("http://chart.apis.google.com/chart?chst=d_map_pin_shadow",
                    new google.maps.Size(40, 37),
                    new google.maps.Point(0, 0),
                    new google.maps.Point(12, 35));
                var marker = new google.maps.Marker({
                    position: pos,
                    map: map,
                    icon: pinImage,
                    shadow: pinShadow
                });
                map.setCenter(pos);
                geocoder.geocode({ 'address': address }, function (results, status) {
                    posi = results[0].geometry.location;
                    map.setCenter(results[0].geometry.location);
                    var marker2 = new google.maps.Marker({
                        map: map,
                        position: results[0].geometry.location,
                        title: address
                    });
                    //alert(marker2.position);
                    var request = {
                        origin: pos,
                        destination: marker2.position,
                        travelMode: google.maps.DirectionsTravelMode.DRIVING
                    };
                    directionsService.route(request, function (response, status) {
                        if (status == google.maps.DirectionsStatus.OK) {
                            directionsDisplay.setDirections(response);
                        }
                    });
                });
            }, function () {
                handleNoGeolocation(true);
            });
        } else {
            // Browser doesn't support Geolocation
            handleNoGeolocation(false);
        }
        function handleNoGeolocation(errorFlag) {
            if (errorFlag) {
                var content = 'Error: The Geolocation service failed.';
            } else {
                var content = 'Error: Your browser doesn\'t support geolocation.';
            }
        }
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 15,
            center: new google.maps.LatLng(39.032969, -94.578019),
            mapTypeId: google.maps.MapTypeId.ROADMAP
        });
        directionsDisplay.setMap(map);
        directionsDisplay.setPanel(document.getElementById('directions-panel'));
    }
    function find_closest_marker(lat, lng) {
        var pi = Math.PI;
        var R = 6371; //equatorial radius
        var distances = [];
        var closest = -1;
        for (i = 0; i < locations.length; i++) {
            var lat2 = locations[i][1];
            var lon2 = locations[i][2];
            var chLat = lat2 - lat;
            var chLon = lon2 - lng;
            var dLat = chLat * (pi / 180);
            var dLon = chLon * (pi / 180);
            var rLat1 = lat * (pi / 180);
            var rLat2 = lat2 * (pi / 180);
            var a = Math.sin(dLat / 2) * Math.sin(dLat / 2) +
            Math.sin(dLon / 2) * Math.sin(dLon / 2) * Math.cos(rLat1) * Math.cos(rLat2);
            var c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
            var d = R * c;
            distances[i] = d;
            if (closest == -1 || d < distances[closest]) {
                closest = i;
            }
        }
        return {
            latitude: locations[closest][1],
            longitude: locations[closest][2]
        };
    }
    google.maps.event.addListener(window, 'load', find_closest_marker);
    google.maps.event.addDomListener(window, 'load', initialize);
    </script>
        
<div class="main_bg"><!-- start main -->
	
	<div class="container">
		<div class="main row">
			<div id="map" style="width: 100%; height: 350px;"></div>
			<div id="directions-panel"></div>
		</div>

		</div>
	</div>
</asp:Content>

