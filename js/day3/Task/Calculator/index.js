var answer = document.getElementById('Answer')

function EnterNumber(value){
    answer.value += value
} 

function EnterOperator(value){
    answer.value += value
}

function EnterEqual(){
    var val1 = parseInt(answer.value[0])
    var val2 = parseInt(answer.value[2])
    operant = answer.value[1]

    switch (operant){
        case "+":
            answer.value = val1+val2
            break;
        
        case "-":
            answer.value = val1-val2
            break;
        
        case "*":
            answer.value = val1*val2
            break;
        
        case "/":
        answer.value = val1/val2
        break;
    }
}

function EnterClear(){
    answer.value=""
}