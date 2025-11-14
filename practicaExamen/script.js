let nombre = document.getElementById("nombre");
let apellidos = document.getElementById("apellidos");
let edad = document.getElementById("edad");
let fechaNacimiento = document.getElementById("fechaNacimiento");
let dni = document.getElementById("dni");
let nie = document.getElementById("nie");
let radiodni = document.getElementById("radioDni");
let radionie = document.getElementById("radioNie");
let divDNI = document.getElementById("dniDisplay");
let divNIE = document.getElementById("nieDisplay");

let btn = document.getElementById("btn")


radiodni.addEventListener("click", () => {

    divDNI.style.display = "grid";
    divNIE.style.display = "none";
    dni.value = "";

})

radionie.addEventListener("click", () => {

    divNIE.style.display = "grid";
    divDNI.style.display = "none";
    nie.value = "";

})

btn.addEventListener("click", (e) => {
    e.preventDefault()
    let json = JSON.stringify(nombre, apellidos, edad, fechaNacimiento, dni, nie)

    console.log(json)

})