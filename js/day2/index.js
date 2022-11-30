function task1_1(){
    var num = prompt("Emter a set of numbers")
    var arr = num.split(" ")
    var sum = 0 , mul = 1 , div = arr[0]
    arr.forEach(function( value ){
        sum+=parseInt(value)
        mul*=value
        if(value!=0){
            div/=value
        }
    })
    var page = document.getElementsByClassName("task1_1")[0]
    page.innerHTML = "<p> The sum = " + sum + "<p> The multiplication = " + mul + "</p>" + "<p>The divition  = " + div + "</p>"
}

function task1_2(){
    var num = prompt("Emter a set of numbers")
    var arr = num.split(" ")
    var page = document.getElementsByClassName("task1_2")[0]
    page.innerHTML = "<p> The ascending order : " + arr.sort(function(a, b){return a - b}) + "<p> The descending order : " + arr.sort(function(a, b){return b - a}) + "</p>" 
}

function task2(){
    var radius = prompt("Emter The radius of circle")
    alert("The area of the circle = " + radius*radius*Math.PI)

    var sq= prompt("Emter a number")
    alert("The squar root = " + Math.sqrt(sq))

    var ang= prompt("Emter an angle")
    alert("The cos of tha angle = " + Math.cos(((ang * Math.PI)/180)))
}

//---------------------------------------------------------------------------------------

var win , timerID
function startWin(){
    win = open('./popup.html',"",'width=200,height=200')
    timerID = setInterval(function(){
        win.moveBy(20,20)
        win.focus()
    },5000)

}

function m(){
    win.moveBy(20,20)
}

function endWin(){
    clearInterval(timerID)
}

//------------------------------------------------------------------------------------------

function task2_1_2(){
    var sen="Welcome"
    var page = document.getElementsByClassName("task2_1_2")[0]
    for(var i=0; i<sen.length; i++){
        window.setTimeout(function(){
            page.innerHTML = "<p> " + sen[i]+ "</p>"
        },5000)
    }
}





function task2_2(){
    var data = location.search.substring(1,location.search.length).split('&')
    var assoArray =[]
    for(var i=0 ; i<data.length; i++){
        assoArray[data[i].split('=')[0]] = data[i].split('=')[1]
    }
    var page = document.getElementsByClassName("task2_2")[0]
    console.log(assoArray)
    page.innerHTML = "<p>Welom: " + assoArray["usrnm"] + "<p> age: " + assoArray["usrage"] + "</p>"+ "<p> Email: " + assoArray["usremail"] + "</p>" + "<p> Address: " + assoArray["usraddress"] + "</p>"+ "<p> Gender: " + assoArray["usrgender"] + "</p>"  

}
