var n_of_img= screen.width/100
on="on.jpeg"
off="off.jpeg"
var imgs = []
function create_img(){
    for (var i=1; i<=n_of_img; i++){
        var img = document.createElement("img")
        img.src = off
        img.width = 100
        img.height = 100
        imgs.push(img)
        document.body.appendChild(img)
    }
}

function slider(){
    create_img()
    i=0
    inid=setInterval(function(){
        if (i==0){
            imgs[imgs.length-1].src = off
            imgs[i].src = on
            i++
        }
        else{
            imgs[i-1].src = off
            imgs[i].src = on
            i++
            if(i>imgs.length-1){i=0}
        }
    },1500)
}

onload = slider()