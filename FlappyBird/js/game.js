window.onload = init;

var backgroundcanvas = document.getElementById("background");
var gamecanvas = document.getElementById("game");
var columnTopcanvas = document.getElementById("columnTop");
var columnBottoncanvas = document.getElementById("columnBotton");
var titlecanvas = document.getElementById("title");
var infotitlecanvas = document.getElementById("infotitle");

var ctxbackground = backgroundcanvas.getContext("2d");
var ctxgame = gamecanvas.getContext("2d");
var ctxcolumnTop = columnTopcanvas.getContext("2d");
var ctxcolumnBotton = columnBottoncanvas.getContext("2d");
var ctxtitle = titlecanvas.getContext("2d");
var ctxinfotitle = infotitlecanvas.getContext("2d");

var gameWidth = 550; // Ширина игрового поля
var gameHeight = 650; // Высота игрового поля
var maxJump = -1.5; // Максимальный прыжок птицы
var grav = 0.5; // Переменная гравитации птицы
var beginspeed = 0; //Начальная скорость птицы
var CountOt = 0; // Счет в игре

var playerobj = {}; //Объект птица
	//Добавляем в объект индексы с настройками:
	playerobj.drawY = 50; //Положение птицы по оси У
	playerobj.isUp = false; // Совершает ли птица прыжок
	playerobj.drawX = 30; // Положение птицы по оси Х
	playerobj.width = 45; // Ширина птицы
	playerobj.height = 32; // Высота птицы

var isPlayIng = false; //Переменная старта игры, истина значит игра запущена

var rast = 170; // расстояние между колоннами
var max = 500; // Макс расстояние появление колонн
var min = 250; //Мин расстояние колонн
var speedColumn = 1 //Скорость колонн

var kolonnobj = {} // Объект колонны
	kolonnobj.drawX = 400; //Положение колонны по Х
	kolonnobj.drawY = (max - min) * Math.random() + min; // Случайный рандом по У;
	kolonnobj.height = 598; // Высота колонн
	kolonnobj.width = 92; // Ширина колонн

var imgBackground = new Image();
imgBackground.src = "img/fon.jpg";

//Переменная для хранения изображения птицы
var imgBird = new Image();
imgBird.src = "img/Flappy_Bird.png";

var imgBirdT = new Image();
imgBirdT.src = "img/Flappy_Bird_top.png";

var imgBirdB = new Image();
imgBirdB.src = "img/Flappy_Bird_button.png";

// Переменные для хранения изображений колонн
var imgColumnButton = new Image();
imgColumnButton.src = "img/Pl_Down.png";

var imgColumnTop = new Image();
imgColumnTop.src = "img/Pl_Up.png";

// Функция для загрузки игры, когда вкладка активна
function init(){
	backgroundcanvas.width = gameWidth; //Задаем размеры канвасам
	backgroundcanvas.height = gameHeight;
	gamecanvas.width = gameWidth;
	gamecanvas.height = gameHeight;
	columnTopcanvas.width = gameWidth;
	columnTopcanvas.height = gameHeight;
	columnBottoncanvas.width = gameWidth;
	columnBottoncanvas.height = gameHeight;
	titlecanvas.width = gameWidth;
	titlecanvas.height = gameHeight;
	ctxtitle.fillStyle = "#FFF";
	ctxtitle.font = "bold 30px Arial";
	ctxinfotitle.fillStyle = "lightgray";
	ctxinfotitle.font = "20px Arial";
	drawBackground(); //Вызываем функцию рисования фона
	drawBird(); //Вызываем функцию рисования птички
	document.addEventListener("keydown", checkKeyDown, false); //Слушатели нажатия клавиш
	document.addEventListener("keyup", checkKeyUp, false);
}

function drawBackground(){
	ctxbackground.drawImage(imgBackground, 0, 0, 600, 723, 0, 0, gameWidth, gameHeight);
	
}

// Функция вызывается по клику на кнопку Старт
function START(){
	isPlayIng = true; //Делаем переменную Истина
	document.getElementById("start").style.display = "none"; // Прячем кнопку
	// Функция для игрового цикла игры
	setInterval(logic, 1);
	function logic(){
		if (isPlayIng){ //Если переменная истина
			drawBird();
			drawColumn();
		}
	}
}
//Функция для рисования птицы
function drawBird(){
//Если она летит вверх, то подставляем картинку из спрайта вверх

	if(beginspeed < 0)
	{
		ctxgame.clearRect(0, 0, gameWidth, gameHeight);
		ctxgame.drawImage(imgBirdT, 0, 0, playerobj.width, playerobj.height,
			playerobj.drawX, playerobj.drawY, 56, 40);

		//ctxgame.strokeRect(playerobj.drawX, playerobj.drawY, 56, 40);

	} else if (beginspeed >= 1.5) {
		//Если вниз, то...
		ctxgame.clearRect(0, 0, gameWidth, gameHeight);
		ctxgame.drawImage(imgBirdB, 0, 0, playerobj.width, playerobj.height,
			playerobj.drawX, playerobj.drawY, 56, 40);

		//ctxgame.strokeRect(playerobj.drawX, playerobj.drawY, 56, 40);

	} else {
		// Просто прямо
		ctxgame.clearRect(0, 0, gameWidth, gameHeight);
		ctxgame.drawImage(imgBird, 0, 0, playerobj.width, playerobj.height, 
			playerobj.drawX, playerobj.drawY, 56, 40);

		//ctxgame.strokeRect(playerobj.drawX, playerobj.drawY, 56, 40);
	}

	//Начальную скорость птицы увеличиваем на гравитацию, и чтобы не было
	//слишком быстро умножаем на любое число, например, 0,05
	//После этого индекс "drawY" увеличиваем на скорость
	beginspeed += grav * 0.05;
	playerobj.drawY += beginspeed;

	if (playerobj.isUp){
		beginspeed = maxJump;
	}
// Если птица подлетает к верхнему краю, не даем ей залететь за него
	if (playerobj.drawY <= 0)
	{
		beginspeed = 0;
		playerobj.drawY = 0;
	}
// Если птица падает вниз, то останавливаем игру
	if (playerobj.drawY >= gameHeight)
	{
		isPlayIng = false;
	}
}

//Функции нажатия и отпускания клавиши
function checkKeyDown(e){
	var keyId = e.keyCode;
	if (keyId == "87"){
		playerobj.isUp = true;
	}
}

function checkKeyUp(e){
	var keyId = e.keyCode;
	if (keyId == "87"){
		playerobj.isUp = false;
	}
}

// Функция рисования колонн
function drawColumn(){
	var randcolumn = (max - min)*Math.random()+min; //Случайный рандом колонн по Y
//Рисование нижней колонны
	ctxcolumnBotton.clearRect(0, 0, gameWidth, gameHeight);
	ctxcolumnBotton.drawImage(imgColumnButton, 0, 0, 92, 598,
		kolonnobj.drawX, kolonnobj.drawY, 70, 400);

	//ctxcolumnBotton.strokeRect(kolonnobj.drawX, kolonnobj.drawY, 70, 400);

//Рисование верхней колонны
	ctxcolumnTop.clearRect(0, 0, gameWidth, gameHeight);
	ctxcolumnTop.drawImage(imgColumnTop, 0, 0, 92, 598,
		kolonnobj.drawX, (kolonnobj.drawY - rast) - 400, 70, 400);

	//ctxcolumnTop.strokeRect(kolonnobj.drawX, (kolonnobj.drawY - rast) - 400, 70, 400);

	kolonnobj.drawX = kolonnobj.drawX - speedColumn; //Двигаем колонны
//Если колонна ушла за левый край
	if (kolonnobj.drawX <= 0 - kolonnobj.width){
		kolonnobj.drawX = 600;
		kolonnobj.drawY = randcolumn;
		speedColumn += 0.08; //Увеличиваем скорость колонн
		CountOt++; //Прибавляем очко
	}

// Проверяем что птица задела нижнюю колонну
	if ((kolonnobj.drawX < playerobj.drawX + playerobj.width) &&
		(kolonnobj.drawX + kolonnobj.width >= playerobj.drawX) &&
		(kolonnobj.drawY <= playerobj.drawY) &&
		(kolonnobj.drawY + kolonnobj.height >= playerobj.drawY + playerobj.height))
	{
		isPlayIng = false; //Останавливаем анимацию
	}

//Проверяем что птица задела верхнюю колонну
	if ((kolonnobj.drawX < playerobj.drawX + playerobj.width) &&
		(kolonnobj.drawX + kolonnobj.width >= playerobj.drawX) &&
		(kolonnobj.drawY - rast > playerobj.drawY) &&
		((kolonnobj.drawY - rast) + kolonnobj.height >= playerobj.drawY + playerobj.height))
	{
		isPlayIng = false; //Останавливаем анимацию
	}

	ctxtitle.clearRect(0, 0, gameWidth, gameHeight);
	ctxtitle.fillText("Счет: " + CountOt, 20, 30);
	ctxinfotitle.clearRect(0, 0, gameWidth, gameHeight);
	ctxinfotitle.fillText("Скорость колонн: " + Math.round(speedColumn * 10) / 10 + "км/ч", 20, 50);
}