let submit = document.getElementById("submit");

submit.addEventListener("click",(event)=>{
    let weight = document.getElementById("weight").value;

    let convert = (weight * 2.2).toFixed(1);

    document.getElementById("result").innerHTML = "The weight in pounds is " + convert;

});