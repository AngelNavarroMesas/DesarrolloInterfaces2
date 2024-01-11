// JavaScript source code

class clsPersona{
    constructor(nombre, apellidos) {
        this.nombre = nombre;
        this.apellidos = apellidos;
    }
}

function alertar() {
    var nombre = document.getElementById("Nombre").value;
    var apellidos = document.getElementById("Apellido").value;


    var persona = new clsPersona(nombre, apellidos);

    alert(persona.nombre + " " + persona.apellidos);
}