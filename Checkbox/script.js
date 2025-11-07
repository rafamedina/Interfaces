const nombre = document.getElementById("nombre")
const appelidos = document.getElementById("appelidos")
const dni = document.getElementById("dni")
const nie = document.getElementById("nie")
const radioDni = document.getElementById("radioDni")
const radioNie = document.getElementById("radioNie")
const edad = document.getElementById("edad")
const politicas = document.getElementById("politicas")
const contendorNie = document.getElementById("contenedorNie")
const contendorDni = document.getElementById("contenedorDni")

const contenedorInputs = document.getElementById("contenedorInputs")

contendorDni.style.display = "none"
contendorNie.style.display = "none"


radioDni.addEventListener("click", () => {

    contendorDni.style.display = "grid";
    contendorNie.style.display = "none";
    // contenedorInputs.style.gridTemplateAreas = ' "nombre apellidos" "edad edad" "opcion opcion" " dninie dninie" "politica politica"  '
    nie.value = "";

})
radioNie.addEventListener("click", () => {

    contendorNie.style.display = "grid";
    contendorDni.style.display = "none";
    dni.value = "";

})