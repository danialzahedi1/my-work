toggleSearch = 1;
modalstate = 1;


function svgOver(){
    $(".svg").css("transform", "scale(1.1)");
    $(".svg").css("margin-left", "20px");
    $("nav").css("padding-left", "15px");
}

function svgOut(){
    $(".svg").css("transform", "scale(1)");
    $(".svg").css("margin-left", "5px");
    $("nav").css("padding-left", "0px");

}

function svgClick(){
    window.open("http://localhost/GameWorld/", "_self");
}  

function searchBar(){
    switch(toggleSearch){
        case 1:
            $(".searchBar").css({transform: 'translate(-50%, 100%) scale(1.1)'});
            $(".searchBar").css("filter", "opacity(1)");
            toggleSearch = 2;
        break;
        case 2: 
            $(".searchBar").css({transform: 'translate(-50%, 0%) scale(1)'});
            $(".searchBar").css("filter", "opacity(0)");
            toggleSearch = 1;
        break;
    }
}

function openModal(){
    $(".modal").css("display", "block");
}

function closeModal(){
    $(".modal").css("display", "none");
}

var myMarquee = document.getElementById("myMarquee");
var marqueeContent = myMarquee.innerHTML;
myMarquee.innerHTML = marqueeContent + marqueeContent;
