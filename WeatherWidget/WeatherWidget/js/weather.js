var getJSON = function (url) {
    return new Promise(function (resolve, reject) {
        var xhr = new XMLHttpRequest();
        xhr.open('get', url, true);
        xhr.responseType = 'json';
        xhr.onload = function () {
            var status = xhr.status;
            if (status == 200) {
                resolve(xhr.response);
            } else {
                reject(status);
            }
        };
        xhr.send();
    });
};

//current weather URL
var url = "http://training.appyoda.io/api/weather/";
var cityName = "pune";

window.onload = function getCityList() {
    var optionArray = ["pune|Pune", "beijing|Beijing", "london|London", "moscow|Moscow", "newdelhi|New Delhi", "newyork|New York", "paris|Paris", "tokyo|Tokyo"];
    var render = '<select onchange="updateCity(this.value)" class="btn" id="cityList" name="selectCity"> </select> </br></br> <div align="center" id="location"></div>';
    document.getElementById("cities").innerHTML = render;
    for (var option in optionArray) {
        var pair = optionArray[option].split("|");
        var newOption = document.createElement("option");
        newOption.value = pair[0];
        newOption.innerHTML = pair[1];
        cityList.options.add(newOption);
    }
}

function updateCity(cityList) {
    cityName = document.getElementById('cityList').value;

    getJSON("http://training.appyoda.io/api/weather/" + cityName).then(function (data) {
        document.getElementById("location").innerHTML = 
             "<h1>" + data.temp_C + " &deg;C&ensp;" + '<img src="' + data.weatherIconUrl[0].value + '" />' + "</h1>"
            + "Cloud Cover : " + data.cloudcover
            + "<br>" + "Humidity : " + data.humidity
            + "<br>" + "Precipitation : " + data.precipMM
            + "<br>" + "Wind Speed (Kmph) : " + data.windspeedKmph
            + "<br>" + "Wind Direction : " + data.winddir16Point;
    },
    function (status) { //error detection....
        alert('Something went wrong.');
    });
}