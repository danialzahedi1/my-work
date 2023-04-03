toggleBar = 1;
hell = 1;
haven = 1;


$("#play").click(function(){
    audioPobi = new Audio("media/mp3/lilPobi.mp3");
    audioPobi.play();
    if(window.location.href != ("http://localhost/radioGaGa/index.php")){
        setTimeout(function(){
            window.location.href = "http://localhost/radioGaGa/index.php";
        }, 1600);    
    }
})


$(".play").click(function(){
    audioPobi = new Audio("media/mp3/lilPobi.mp3");
    audioPobi.play();
})
//shows and hides the mobile menu bar
$(".barMenu").slideUp(0);
$(".bars").click(function(){

    switch(toggleBar){
        case 1:
            $(".barMenu").fadeIn(200); 
            toggleBar = 2;
        break;
        case 2: 
            $(".barMenu").fadeOut(200);
            toggleBar = 1;
        break;
    }
})


$(".limburg").click(function(){

    switch(hell){
        case 1:
            document.getElementById("bg").style="background-image:url('media/img/hell.jpg')";
            hell = 2;
            haven = 2;   
        break;
        case 2: 
            document.getElementById("bg").style="background-image:url('https:/picsum.photos/2560/1600');";
            hell = 1;
            haven = 1;
        break;
    }
})

$(".nederland").click(function(){

    switch(haven){
        case 1:
            document.getElementById("bg").style="background-image:url('media/img/haven.jpeg')";
            haven = 2; 
            hell = 2;  
        break;
        case 2: 
            document.getElementById("bg").style="background-image:url('https:/picsum.photos/2560/1600');";
            haven = 1;
            hell = 1;
        break;
    }
})

var vid = document.getElementById("vid"); 

function playSnippet(artistId) {
    vid = document.getElementById("vid" + artistId);
    vid.play(); 
}

function pauseSnippet(artistId) {
    vid = document.getElementById("vid" + artistId); 
    vid.pause(); 
}

function unmute(artistId) {
    vid = document.getElementById("vid" + artistId);
    vid.muted = false; 
}

function mute(artistId) {
    vid = document.getElementById("vid" + artistId);
    vid.muted = true; 
}

function songSelect(selector){
    $("iframe").attr("src", "https://www.youtube.com/embed/" + $("#rowUrl" + selector).attr("sesamzaadolie") + "?autoplay=1&mute=");
}

const numName = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"];
var captchaAnswer;
function generateCaptcha(){
    var getRnd1 = (Math.floor(Math.random() * 10) + 1);
    var getRnd2 = (Math.floor(Math.random() * 10) + 1);
    captchaAnswer = getRnd1 + getRnd2;
    $("#js-captcha").val(numName[getRnd1] + " + " + numName[getRnd2]);
}

function checkCaptcha(val){
    if(val == captchaAnswer) 
        return true;
    return false;
    
}

generateCaptcha();

function captcha(){
    alert("Checking");
    if (checkCaptcha($("#captchaAnswer").val())){
        $("#js-submit").removeAttr("disabled");
        $("#js-submit").css("color", "white");
        $("#js-submit").css("background-color", "#4CAF50");
        return;
    }
    alert("Captcha not valid!");
}

function acceptCookies() {
    // set a cookie to remember that the user has accepted cookies
    document.cookie = "cookies-accepted=true; expires=Fri, 31 Dec 9999 23:59:59 GMT";
    // hide the cookie consent message
    document.getElementById("cookie-consent").style.display = "none";
  }

  // check if the user has previously accepted cookies
  if (document.cookie.indexOf("cookies-accepted=true") === -1) {
    document.getElementById("cookie-consent").style.display = "block";
  }

  stopReading = false;
  function formSubmit() {
    stopReading = false;

    // if($("#js-name").val() == ""){
    //     alert("Plase enter a name")
    //     return;
    // }
    // if($("#js-lastName").val() == ""){
    //     alert("Please enter a last name")
    //     return;
    // }
    // if($("#js-message").val() == ""){
    //     alert("Please enter a message")
    //     return;
    // }

    $(".required").prop("placeholder", "");
    $(".required").css("background-color", "#fff9");
    for(i = 0; i < $(".required").length; i++){
        if($(".required").eq(i).val() == ""){
            $(".required").eq(i).prop("placeholder", "Required field");
            $(".required").eq(i).css("background-color", "#5007");
            $(".required").eq(i).css("color", "#fff");
            stopReading = true;
            $(".required").eq(i).css("color", "#000000");
        }
    }
    if(stopReading){
        return;
    }

    var name = document.querySelector('input[name="name"]').value;
    var lastName = document.querySelector('input[name="lastName"]').value;

    document.querySelector('#userName').innerHTML = name + " " + lastName;
    document.querySelector('#thankYouMessage').style.display = "block";
    setTimeout(function(){
        window.location.href = "http://localhost/radioGaGa/contact.php";
    }, 3000); 
  }