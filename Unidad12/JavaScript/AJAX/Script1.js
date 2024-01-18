// JavaScript source code
window.onload = inicializaEventos

function inicializaEventos() {
    let button = document.getElementById("Saludar");
    button.addEventListener("click", saludar, false);
}

function saludar() {
    let request = new XMLHttpRequest();

    miLlamada.open("GET", "127.0.0.1/")

    miLlamada.onreadystatechange = function () {
        if (miLlamada.readyState < 4) {
            divMensaje.innerHTML = "Cargando..."
        } else if (miLlamada.readyState == 4 && miLlamada.status == 200) {
            let response = miLlamada.responseText;
            divMensaje.innerHTML = response;
        }
    };

    miLlamada.send()
}