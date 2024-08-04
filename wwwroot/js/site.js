// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const html = document.querySelector("#tema");
const htmlColorMode = document.querySelector(".site-theme");
html.setAttribute("data-bs-theme",localStorage.getItem("tema"));

htmlColorMode.addEventListener("click", () => {
    if(html.getAttribute("data-bs-theme") === "dark"){
        localStorage.setItem("tema","light");
        document.getElementById("themeSelector").src="/imgs/luna.png";
    }
    else{
        localStorage.setItem("tema","dark");
        document.getElementById("themeSelector").src="/imgs/sol.png";
    }
    html.setAttribute("data-bs-theme",localStorage.getItem("tema"));
})