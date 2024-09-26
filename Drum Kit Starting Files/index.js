var numberOfDrumButtons = document.querySelector(".drum").length;

for(let i = 0;i< numberOfDrumButtons;i++)
document.querySelectorAll("button")[i].addEventListener("click", function(){
    //document.getElementById("msg").innerHTML = "click" +i;
console.log(this.innerHTML);
switch(buttonInnerHTML){
case"w":
var tom1 = new Audio("sound/tom-1.mp3");
tom1.play();

case"a":
var audio = new Audio("sound/tom-2.mp3");
audio.play();

case"s":
var audio = new Audio("sound/tom-3.mp3");
audio.play();

case"d":
var audio = new Audio("sound/tom-4.mp3");
audio.play();

case"j":
var audio = new Audio("sound/snare-.mp3");
audio.play();

case"k":
var audio = new Audio("sound/crash-.mp3");
audio.play();


case"l":
var audio = new Audio("sound/kick-.mp3");
audio.play();
}
});
document.getElementById("btn").addEventListener("Click",function(event){
    document.getElementById("msg").innerHTML = document.getElementById("txt").value;
});

document.getElementById("btn").addEventListener("mousedown",function(event){
    document.getElementById("msg").innerHTML = document.getElementById("txt").value;
});
document.body.addEventListener("keydown",function(event){
console.log(event.key);
});