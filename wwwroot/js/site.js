// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const html = document.querySelector("#tema");
console.log(html);
const htmlColorMode = document.querySelector(".site-theme");

htmlColorMode.addEventListener("click", () => {
    if(html.getAttribute("data-bs-theme") === "dark")
        html.setAttribute("data-bs-theme","light");
    else
        html.setAttribute("data-bs-theme","dark");
})