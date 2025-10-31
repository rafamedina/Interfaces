
let formulario = document.getElementById("formulario")
let email = document.getElementById("email")
let password = document.getElementById("password")
let enviar = document.getElementById("enviar")


console.log(formulario, email, password, enviar)

enviar.addEventListener("click", (e) => {
    e.preventDefault(); // evitar recargar la pagina

    console.log(email.value)
    console.log(password.value)


    if (password.value == 123) {
        alert("Ceporro")

        document.body.style.background = "red";
    } else {
        document.body.style.background = "green";
    }


})