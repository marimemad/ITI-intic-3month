
function get_data(){
    var inp = document.getElementById("inp").value
    var xhr = new XMLHttpRequest()

    xhr.open('GET',('https://jsonplaceholder.typicode.com/users/'+inp))

    xhr.onreadystatechange =function(){

    if(xhr.readyState == 4){
        if(xhr.status >=200 && xhr.status <300){
            document.getElementsByTagName('div')[0].innerHTML = ""
            var data = JSON.parse(xhr.responseText)
            for(var i=0;i<data.length;i++){
                console.log(data[i])
                document.getElementsByTagName('div')[0].innerHTML+=data[i].name+":::"+data[i].address.geo.lat+"<br>"
            }
        }
        else{

        }
    }
    }

    xhr.send('')
}
