// JavaScript source code

window.onload = inicializaEventos;

function inicializaEventos() {
    document.getElementById("btnCambiar").addEventListener("click")
}


function cambiarTitulo()
{
    //document.getElementById("Texo").innerHTML = "Hola muy buenas";
    //document.getElementsByTagName("h2")[0].innerHTML = "Hola muy buenas 2 ahora es personal";

    /*
    var misH2;
    misH2 = document.getElementsByTagName("h2");
    alert(misH2);
    misH2[0].innerHTML = "Hola muy buenas 3 ahora es adios";
    */

   
    var misH2;
    misH2 = document.getElementsByTagName("h2");
    for (i = 0; i < misH2.length; i++) {
        misH2[i].innerHTML = "Hola muy buenas "+i;
    }
    

    miBoton = document.getElementById("btnCambiar");
    miBoton.value = "Ya has cambiado";
    miBoton.disabled = true;
}