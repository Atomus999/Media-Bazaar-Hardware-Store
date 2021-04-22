let spouseBtn = document.querySelector(".spouse-btn-container");
let spouseButton = document.querySelector("#spouse_btn");

let spouseFirstNameWrapper = document.querySelector(".edit-spouseFirstName");
let spouseLastNameWrapper = document.querySelector(".edit-spouseLastName");
let spousePhoneNrWrapper =document.querySelector(".edit-spousePhoneNr");

let spouseFirstNameInput = document.querySelector("#user_edit_spouseFirstName");
let spouseLastNameInput = document.querySelector("#user_edit_spouseLastName");
let spousePhoneNrInput = document.querySelector("#user_edit_spousePhoneNr");
let userEditForm = document.querySelector("#user_edit_info_form");

function SetHtmlValidationForSpouse(validate){
    if(validate == true){
        spouseFirstNameInput.setAttribute('required', true);
        spouseLastNameInput.setAttribute('required', true);
        spousePhoneNrInput.setAttribute('required', true);
        spousePhoneNrInput.setAttribute('title', 'Phone number required format is 316-xxxx-xxxx')
        spousePhoneNrInput.setAttribute('pattern', "316[0-9]{4}[0-9]{4}$");
    }
    else{
        spouseFirstNameInput.removeAttribute('required');
        spouseLastNameInput.removeAttribute('required');
        spousePhoneNrInput.removeAttribute('required');
        spousePhoneNrInput.removeAttribute('title');
        spousePhoneNrInput.removeAttribute('pattern');
    }
    
}

function ClearInputs(){
    spouseFirstNameInput.value = "";
    spouseLastNameInput.value= "";
    spousePhoneNrInput.value= "";
}

window.onload = function(){
    if(spouseFirstNameInput.value != "" && spouseLastNameInput.value != "" && spousePhoneNrInput.value != ""){
        SetHtmlValidationForSpouse(true);
        spouseButton.innerHTML = "Clear Spouse Info"
    }
    else{
        spouseButton.innerHTML = "Spouse Info"
    }
    // else{
    //     // spouseFirstNameInput.classList.add("hidden");
    //     // spouseLastNameInput.classList.add("hidden");
    //     // spousePhoneNrInput.classList.add("hidden");
    // }
  }

spouseBtn.addEventListener("click", function(){
    if(spouseFirstNameWrapper.classList.contains("hidden") && spouseLastNameWrapper.classList.contains("hidden") && spousePhoneNrWrapper.classList.contains("hidden")){
        spouseFirstNameWrapper.classList.remove("hidden");
        spouseLastNameWrapper.classList.remove("hidden");
        spousePhoneNrWrapper.classList.remove("hidden");
        SetHtmlValidationForSpouse(true);
        spouseButton.innerHTML = "Clear Spouse Info";
    }
    else{
        spouseButton.innerHTML = "Spouse Info";
        SetHtmlValidationForSpouse(false);
        ClearInputs();
        spouseFirstNameWrapper.classList.add("hidden");
        spouseLastNameWrapper.classList.add("hidden");
        spousePhoneNrWrapper.classList.add("hidden");
    }
});



