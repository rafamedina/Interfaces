let Nombre = document.getElementById("Nombre")
let Apellidos = document.getElementById("Apellidos")
let Email = document.getElementById("Email")
let Dninie = document.getElementById("dninie")
let Password = document.getElementById("Password")

let radioDni = document.getElementById("radioDni")
let radioNie = document.getElementById("radioNie")

let etiquetaDNINIE = document.getElementById("EtiquetaDNINIE")

let check = document.getElementById("check")
let btn = document.getElementById("btn")

const listaInputs = [];

radioDni.addEventListener("click", () => {

    etiquetaDNINIE.innerText = "DNI";
    dninie = ""

})

radioNie.addEventListener("click", () => {

    etiquetaDNINIE.innerText = "NIE";
    ninie = ""
})


btn.addEventListener("click", (e) => {
    e.preventDefault()

    listaInputs.push({ id: "Nombre", valor: Nombre.value })
    listaInputs.push({ id: "Apellidos", valor: Apellidos.value })
    listaInputs.push({ id: "Email", valor: Email.value })

    listaInputs.push({ id: "Password", valor: Password.value })



    if (radioDni.checked) {

        listaInputs.push({ id: "DNI", valor: Dninie.value })
    }


    if (radioNie.checked) {
        listaInputs.push({ id: "NIE", valor: Dninie.value })
    }


    localStorage.setItem("misDatos", JSON.stringify(listaInputs))
    console.log(localStorage.getItem("misDatos"))


})