let morningSwitch = document.querySelector("#abs_morning_switch");
let eveningSwitch = document.querySelector("#abs_evening_switch");

morningSwitch.addEventListener("click", function(){
    if(morningSwitch.checked){
        eveningSwitch.checked = false;
        eveningSwitch.disabled = true;
    }
    else{
        eveningSwitch.checked = false;
        eveningSwitch.disabled = false;
    }
});

eveningSwitch.addEventListener("click", function(){
    if(eveningSwitch.checked){
        morningSwitch.checked = false;
        morningSwitch.disabled = true;
    }
    else{
        morningSwitch.checked = false;
        morningSwitch.disabled = false;
    }
});