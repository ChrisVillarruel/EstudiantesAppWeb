//@Autor: Juan Manuel Cruz Badillo
//@Modificado por: Gil Villarruel Christian 

// 1- Obtener los elementos con el id boton-eliminar

var botones = document.querySelectorAll("#boton-eliminarEs");
var rowDelete = document.querySelector("#tbody-estudiantes");

// 2- Obtener el boton que ha sido oprimido mediante un recorrido forEach
botones.forEach(boton => {
    // 3- Crear el evento click para obtener la información del boton presionado
    boton.addEventListener("click", function () {
        // Obtener la fila del registro a eliminar
        var dataButton = boton.parentNode.parentNode;

        // 4- Obtener el id del registro que se pretende eliminar
        const idEstudiante = this.dataset.estudiante;

        // 5- Crear la ventana de confirmación para eliminar el registro
        var confirm = window.confirm("¿Estas seguro de querer Eliminar a este Alumno?");


        // 6- Evaluamos la respuesta de confirm
        if (confirm) {
            // Creamos la petición Ajax

            // 7- Instanciamos la clase XMLHttpRequest
            var request = new XMLHttpRequest();

            // 8- Abrimos la conexión
            request.open("GET", "https://localhost:44331/Estudiantes/EliminarEstudiante?claveEstudiante=" + idEstudiante, true);

            // 9- Realizamos el contenido de la petición
            request.onreadystatechange = function () {
                // 10- Evaluar si la petición a la URL se envio y recibio correctamente
                if (this.readyState == 4 && this.status == 200) {
                    console.log(this.responseText);
                    rowDelete.removeChild(dataButton);
                }
            };

            request.send();

        }

    });
});