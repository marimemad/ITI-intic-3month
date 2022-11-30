 
function move(){
    var div = document.getElementById("header")
    var div2 = div.cloneNode(true)
    
    div.style.textAlign = "right"
    div2.style.textAlign = "left"
    
    document.getElementsByClassName("center")[0].appendChild(div2)
}