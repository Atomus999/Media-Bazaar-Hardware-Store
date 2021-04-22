/*Mobile navigation modal overlay*/
var backdrop = document.querySelector(".backdrop");
var toggleButton = document.querySelector(".toggle-button");
var mobileNav = document.querySelector(".mobile-nav");

// console.dir(backdrop.style['background-image']);

// console.dir(backdrop);

backdrop.addEventListener("click", function () {
    // mobileNav.style.display = 'none';
    mobileNav.classList.remove("open");
    closeModal();
});

function closeModal() {
    backdrop.classList.remove("open");
}

if(document.body.contains(document.querySelector(".toggle-button"))){
    toggleButton.addEventListener("click", function () {
        // mobileNav.style.display = 'block';
        // backdrop.style.display = 'block';
        mobileNav.classList.add("open");
        backdrop.classList.add("open");
    });
} 



/*Go to top button*/

//Get the button:
mybutton = document.getElementById("goTop-btn");

// When the user scrolls down 200px from the top of the document, show the button
if(document.body.contains(document.getElementById("goTop-btn"))){
    window.onscroll = function () {
        scrollFunction();
    };
}


function scrollFunction() {
    if (document.body.scrollTop > 600 || document.documentElement.scrollTop > 600) {
        mybutton.style.display = "block";
    } else {
        mybutton.style.display = "none";
    }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    document.body.scrollTop = 0; // For Safari
    document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
}

/*Login show/hide button*/

var ueInputPassword = document.querySelector("#ue-password-input");
var uePasswordIconContainer = document.querySelector(".show-password-btn");
var uePasswordIcon = document.getElementById("icon-password");

if(document.body.contains(document.querySelector(".user-edit-text-input")) && document.body.contains(document.querySelector(".show-password-btn")) && document.body.contains(document.getElementById("icon-password"))){
    uePasswordIconContainer.addEventListener("click", function (){
        if(ueInputPassword.classList.contains('active')){
            ueInputPassword.setAttribute('type', 'text');
            uePasswordIcon.className = 'fa fa-eye';
            ueInputPassword.classList.remove("active");
        }
        else{
            ueInputPassword.setAttribute('type', 'password');
            uePasswordIcon.className = 'fa fa-eye-slash';
            ueInputPassword.classList.add("active");
        }
    });
}
