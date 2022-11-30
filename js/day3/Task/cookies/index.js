
var assoArray =[]
var counter = 0

onload = function get_data(){
    var data = location.search.substring(1,location.search.length).split('&')
    for(var i=0 ; i<data.length; i++){
        assoArray[data[i].split('=')[0]] = data[i].split('=')[1]
    }

    create_Cookie()

    var img = document.querySelector("img")
    img.src = "./"+assoArray["gender"]+".jpeg"

    var name = document.querySelector("#name")
    name.innerText = assoArray["usrnm"]
    name.style.color = assoArray["colors"]

    var counter = document.querySelector("#counter")
    counter.innerText = window.counter
    counter.style.color = assoArray["colors"]
    
    this.window.counter += 1
}

function create_Cookie(){
    for(var key in assoArray){
        document.cookie = key + "=" + assoArray[key]
    }
    document.cookie = "counter =" + counter
}
get_data()