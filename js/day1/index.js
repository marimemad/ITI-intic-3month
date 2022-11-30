function task1(){
    var s = prompt("Enter a sentence")
    for (var i = 1; i <=6; i++) {
        document.write("<h",i," > ",s," </h",i,">")
      }
} 

function task2(){
    var n = parseInt(prompt("Enter a number"))
    var sum=0
    while (n>0 && Number.isInteger(n)){
        sum+=n
        n = parseInt(prompt("Enter a number"))
    }
    document.write("The sum = ",sum)
}

function task3(){
    
    var w = prompt("Enter a word");
    var case_sen = prompt("is case sensitive?")
    var len = w.length
    var pal = true

    for (var i = 0; i<len/2 && pal; i++){
        w=w.trim()
        
        if (case_sen.toLowerCase() == "no"){
            w = w.toLowerCase()
        }

        if (w[i]!=w[len-i-1]){
            pal=false
        }
    }
    if (pal){
        document.write("The string is palindrome")
    }
    else{
        document.write("The string is non palindrome")
    }
}