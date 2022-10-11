autoSlider();

// Переменная ширины страницы
var pageWidth = document.documentElement.scrollWidth;

var left = 0;
var timer;

// Если ширина экрана больше 1200px
var widthLeft = 404;
var widthLeftPolosa = -808;

// Если ширина экрана больше 992рх, но меньше 1200рх
if(pageWidth<1199.98){
    widthLeft = 304;
    widthLeftPolosa = -608;
}

// Если ширина экрана больше 768рх, но меньше 992рх
if(pageWidth<991.98){
    widthLeft = 254;
    widthLeftPolosa = -508;
}

// Если ширина экрана больше 576рх, но меньше 768рх
if(pageWidth<767.98){
    widthLeft = 204;
    widthLeftPolosa = -408;
}

// Если ширина экрана меньше 576рх
if(pageWidth<575.98){
    widthLeft = 256;
    widthLeftPolosa = -512;
}

function autoSlider (){
    timer = setTimeout(function(){
        var polosa = document.getElementById('polosa');
        left = left - widthLeft;
        if (left < widthLeftPolosa){
            left = 0;
            clearTimeout(timer);
        }
        polosa.style.left = left + 'px';
        autoSlider(); 
    },3000);
}
