const contraseña1 = document.getElementById("password1")
const contraseña2 = document.getElementById("password2")
const form = document.getElementById("form")
const btn = document.getElementById("btn")

let llave = false

contraseña1.addEventListener("change", () => {

    if (contraseña2.value != "") {

        if (contraseña1.value != contraseña2.value) {

            alert("Las cotraseñas no son iguales")

            btn.disabled = true


        } else {

            btn.disabled = false
        }

    }

})

contraseña2.addEventListener("change", () => {

    if (contraseña1.value != "") {

        if (contraseña1.value != contraseña2.value) {

            alert("Las cotraseñas no son iguales")
            llave = false
            btn.disabled = true


        } else {

            btn.disabled = false
        }

    }

})


f