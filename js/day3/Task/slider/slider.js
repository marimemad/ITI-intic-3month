var elem = document.getElementById("slider")
var imgs=["img1.png","img2.png","img3.png","img4.png","img5.png","img6.png","img7.png","img8.png","img9.png","img10.png","img11.png","img12.png","img13.png"]
onload = slider()
var inid
var i = 0

function slider(){
    i=0
    inid=setInterval(function(){
        if (i==imgs.length-1){i=0}
        else{i++}
        elem.src="./img/"+imgs[i]
        console.log(i)
    },2000)
} 

function next(){
    clearInterval(inid)
    
    if (i==imgs.length-1){i=0} else{i++}
    elem.src="./img/"+imgs[i]
}

function previous(){
    clearInterval(inid)
    if (i<=0){i=imgs.length-1} else{i--}
    elem.src="./img/"+imgs[i]
}
