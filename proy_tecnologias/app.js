$(document).ready(function() {

    //crear cuenta
    $('#cuenta-form').submit(function(e) {
        const postData = {
            nombre: $('#nombre').val(),
            apellido1: $('#apellido1').val(),
            apellido2: $('#apellido2').val(),
            correo: $('#correo').val(),
            tipo: $('#tipo').val(),
            pais: $('#pais').val(),
            numtarjeta: $('#numtarjeta').val(),
            pago: $('#pago').val(),
            usuario: $('#usuario').val(),
            contraseña: $('#contraseña').val()
        };
        //console.log(postData);
        $.post('backend/cuenta-add.php', postData, function(response) {
            console.log(response);
            let respuesta = JSON.parse(response);
            let template_bar = '';
            template_bar = `
                            <li style="list-style: none;">status: ${respuesta.status}</li>
                            <li style="list-style: none;">message: ${respuesta.message}</li>
                        `;
            $('#cuenta-form').trigger('reset');
            $('#cuenta-result').html(template_bar);

            if (respuesta.status == 'success') {
                document.getElementById("cuenta-result").className = "card text-white bg-primary my-4";
                //window.location.replace("login.php");
            } else {
                document.getElementById("cuenta-result").className = "card text-white bg-danger my-4";
            }
        });
        e.preventDefault();

    });

    //crear perfil
    $('#perfil-form').submit(function(e) {
        const postData = {
            idcuenta: $('#idcuenta').val(),
            usuario: $('#usuario').val(),
            idioma: $('#idioma').val(),
            edad: $('#edad').val(),
            foto: $('#foto').val()
        };
        console.log(postData);

        $.post('backend/perfil-add.php', postData, function(response) {
            console.log(response);
            let respuesta = JSON.parse(response);
            let template_bar = '';
            template_bar = `
                            <li style="list-style: none;">status: ${respuesta.status}</li>
                            <li style="list-style: none;">message: ${respuesta.message}</li>
                        `;
            $('#perfil-form').trigger('reset');
            $('#perfil-result').html(template_bar);

            if (respuesta.status == 'success') {
                document.getElementById("perfil-result").className = "card text-white bg-primary my-4";
                //window.location.replace("login.php");
            } else {
                document.getElementById("perfil-result").className = "card text-white bg-danger my-4";
            }
        });
        e.prevenDefault();
    });

    //editar perfil
    $('#editar-form').submit(function(e) {
        if (confirm('¿Realmente deseas actualizar el perfil?')) {
            const postData = {
                id: $('#id').val(),
                usuario: $('#usuario').val(),
                idioma: $('#idioma').val(),
                edad: $('#edad').val(),
                imagen: $('#imagen').val()

            };

            $.post('backend/perfil-edit.php', postData, function(response) {
                console.log(response);
                let respuesta = JSON.parse(response);
                let template_bar = '';
                template_bar = `
                            <li style="list-style: none;">status: ${respuesta.status}</li>
                            <li style="list-style: none;">message: ${respuesta.message}</li>
                        `;
                //$('#perfil-result').trigger('reset');
                $('#perfil-result').html(template_bar);
                document.getElementById("perfil-result").className = "card my-4 d-block";

            });
        }
    });

    //eliminar perfil
    $('.eliminar').click(function(e) {
        if (confirm('¿Realmente deseas eliminar el perfil?')) {

            var id = $(this).attr("id");
            var dataString = 'id=' + id;


            $.post('./backend/perfil-delete.php', { id }, (response) => {
                console.log(response);
            });
            $('#cuenta-form').trigger('reset');

        }
    });

    //listar perfiles
    //$.ajax({

    //url: './backend/perfil-list.php',
    //    type: 'GET',
    //    success: function(response) {
    //     $('#perfil').html(response);

    //  }

    //});
    id = $('#idcuenta').val();
    $.ajax({
        url: 'backend/perfil-list.php?idcuenta=' + id,
        type: 'GET',
        success: function(response) {
            let perfiles = JSON.parse(response);
            let template = '';
            perfiles.forEach(perfil => {
                // SE CREA UNA LISTA HTML CON LA DESCRIPCIÓN DEL PRODUCTO
                template += `
                        <tr id="${perfil.id}">
                        <td>${perfil.id}</td>
                        <td>${perfil.usuario}</td>
                        <td>${perfil.rutaimagen}</td>                       
                        <td><button class="perfil-edit btn btn-primary" >
                        Editar
                        </button> </td>
                        </tr> `;
            });
            $('#perfil').html(template);
        }
    })
    $(document).on('click', '.perfil-edit', (e) => {
        const element = $(this)[0].activeElement.parentElement.parentElement;
        const id = $(element).attr('id');
        console.log(id);
        location.href = "editarperfil.php?id=" + $(element).attr('id');
    });

});