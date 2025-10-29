let miFormulario = document.getElementById("miFormulario");
let miInput = document.getElementById("miInput");
console.log(miFormulario);
console.log(miInput);

// function cambiarFondo() {
//     miFormulario.style.background = "blue";
// }


miFormulario.addEventListener("submit", (e) => {

    e.preventDefault(); // evita recargar la pagina

    miFormulario.style.background = "red";

})