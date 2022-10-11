// Работа с первым попапом
function openPopap1() {
    document.querySelector(".popap1").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap1() {
    document.querySelector(".popap1").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа со вторым попапом
function openPopap2() {
    document.querySelector(".popap2").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap2() {
    document.querySelector(".popap2").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с пятым попапом
function openPopap5() {
    document.querySelector(".popap5").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap5() {
    document.querySelector(".popap5").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с девятым попапом
function openPopap9() {
    document.querySelector(".popap9").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap9() {
    document.querySelector(".popap9").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с десятым попапом
function openPopap10() {
    document.querySelector(".popap10").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap10() {
    document.querySelector(".popap10").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с одиннадцатым попапом
function openPopap11() {
    document.querySelector(".popap11").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap11() {
    document.querySelector(".popap11").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с двенадцатым попапом
function openPopap12() {
    document.querySelector(".popap12").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap12() {
    document.querySelector(".popap12").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с тринадцатым попапом
function openPopap13() {
    document.querySelector(".popap13").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap13() {
    document.querySelector(".popap13").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с четырнадцатым попапом
function openPopap14() {
    document.querySelector(".popap14").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap14() {
    document.querySelector(".popap14").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с пятнадцатым попапом
function openPopap15() {
    document.querySelector(".popap15").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap15() {
    document.querySelector(".popap15").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с шеснадцатым попапом
function openPopap16() {
    document.querySelector(".popap16").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap16() {
    document.querySelector(".popap16").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с семнадцатым попапом
function openPopap17() {
    document.querySelector(".popap17").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap17() {
    document.querySelector(".popap17").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}

// Работа с восемнадцатым попапом
function openPopap18() {
    document.querySelector(".popap18").style.display = "block";
    document.querySelector("body").style.overflowY = "hidden";
}
function closePopap18() {
    document.querySelector(".popap18").style.display = "none";
    document.querySelector("body").style.overflowY = "auto";
}


autoSlider();

var left = 0;
var timer;

function autoSlider() {
    timer = setTimeout(function () {
        var polosa = document.querySelector(".polosa");
        left -= document.querySelector('.galery_block').offsetWidth;
        if(left < -(document.querySelector('.galery_block').offsetWidth)*6){
            left = 0;
            clearTimeout(timer);
        }
        polosa.style.left = left + "px";
        autoSlider();
    }, 5000);
}



let menuElem = document.getElementById('sweeties');
let titleElem = menuElem.querySelector('.title');

titleElem.onclick = function() {
    menuElem.classList.toggle('open');
};