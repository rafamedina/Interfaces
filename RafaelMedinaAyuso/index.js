const contraseña1 = document.getElementById("password1")
const contraseña2 = document.getElementById("password2")
const form = document.getElementById("form")
const Nombre = document.getElementById("Nombre")
const Apellidos = document.getElementById("Apellidos")
const telefono = document.getElementById("telefono")
const Usuario = document.getElementById("Usuario")
const direccion = document.getElementById("direccion")
const ciudad = document.getElementById("ciudad")
const cp = document.getElementById("cp")
const formSelect = document.getElementById("form-select")
const exampleCheck1 = document.getElementById("exampleCheck1")
const btn = document.getElementById("btn")

let llave = false

const listaInputs = [];
contraseña1.addEventListener("change", () => {

    if (contraseña2.value != "") {

        if (contraseña1.value != contraseña2.value) {

            alert("No coincide la clave")

            btn.disabled = true

        } else {

            btn.disabled = false
        }

    }

})

contraseña2.addEventListener("change", () => {

    if (contraseña1.value != "") {

        if (contraseña1.value != contraseña2.value) {

            alert("No coincide la clave")
            llave = false
            btn.disabled = true

        } else {

            btn.disabled = false
        }

    }

})

form.addEventListener("submit", (e) => {
    e.preventDefault()
    listaInputs.push({ id: "Nombre", valor: Nombre.value })
    listaInputs.push({ id: "Apellidos", valor: Apellidos.value })
    listaInputs.push({ id: "telefono", valor: telefono.value })
    listaInputs.push({ id: "Usuario", valor: Usuario.value })
    listaInputs.push({ id: "direccion", valor: direccion.value })
    listaInputs.push({ id: "ciudad", valor: ciudad.value })
    listaInputs.push({ id: "cp", valor: cp.value })
    listaInputs.push({ id: "formSelect", valor: formSelect.value })
    listaInputs.push({ id: "exampleCheck1", valor: exampleCheck1.value })


    localStorage.setItem("datosJSON", JSON.stringify(listaInputs))
    console.log(localStorage.getItem("datosJSON"))

    setTimeout(() => {

        alert("Datos Enviados Correctamente")
    }, 5000)


})
