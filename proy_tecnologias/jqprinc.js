$(document).ready(function() {
    lista_pelic();
    lista_serie();
    perfil();
    $('#iduser').hide();
    $('#search').keyup(function() {
        var datos = {};
        datos.id = $('#iduser').val();
        datos.search = $('#search').val();
        var jsoncomp = JSON.stringify(datos);
        if ($('#search').val()) {
            $("#peli").empty();
            $.post("backend/busq_user_peli.php", jsoncomp, function(response) {
                let jsprod = JSON.parse(response);
                let temp = '';
                jsprod.forEach(peli => {
                    temp += `
                            <tr productid=${peli.id}>
                                <td>
                                    <img src="img/${peli.rutaportada}" width=300 height=300>
                                </td>
                                <td>
                                    <ul>
                                        <li>
                                            <a href="">Titulo: ${peli.titulo}</a>
                                        </li>
                                        <li> Duración: ${peli.duracion}</li>
                                        <li> Genero: ${peli.nombre}</li>
                                        <li> Clasificación: ${peli.clave}</li>
                                    </ul>
                                </td>
                                <td>
                                    <a href='#'>Ver ahora</a>
                                </td>
                            </tr>
                        `;
                });
                $('#peli').html(temp);
            });
            $("#seri").empty();
            $.post("backend/busq_user_seri.php", jsoncomp, function(response) {
                let jsprod = JSON.parse(response);
                let temp = '';
                jsprod.forEach(ser => {
                    temp += `
                        <tr productid=${ser.id}>
                    <td><img src='img/${ser.rutaportada}' width=300 height=300></td>
                    <td>
                        <ul>
                            <li>Titulo: ${ser.titulo}</li>
                            <li>Temporadas: ${ser.numtemporadas}</li>
                            <li>Total de capitulos: ${ser.totalcapitulos}</li>
                            <li>Genero: ${ser.nombre}</li>
                            <li>Clasificación: ${ser.clave}</li>
                            
                        </ul>
                    </td>
                    <td>
                        <a href='#'>Ver ahora</a>
                    </td>
                </tr>
                        `;
                });
                $('#seri').html(temp);
            });

        }


    })
})

function lista_pelic() {
    var datos = {};
    datos.id = $('#iduser').val();
    var jsoncomp = JSON.stringify(datos);

    $.post("backend/lista_peli_user.php", jsoncomp, function(response) {
        console.log(response);
        let jsprod = JSON.parse(response);
        console.log(jsprod);
        let temp = '';
        let textgen = "";
        let txtclas = "";
        jsprod.forEach(peli => {
            console.log("AAAA:" + peli.idgenero);
            console.log("BBBB:" + peli.idclasificacion);
            switch (peli.idgenero) {
                case "1":
                    textgen = "comedia";
                    break;
                case "2":
                    textgen = "terror";
                    break;
                case "3":
                    textgen = "drama";
                    break;
                case "4":
                    textgen = "accion";
                    break;

                case "5":
                    textgen = "Aventura";
                    break;

                default:
                    textgen = "WAT";
                    break;
            }
            switch (peli.idclasificacion) {
                case "1":
                    txtclas = "AA";
                    break;
                case "2":
                    txtclas = "A";
                    break;
                case "3":
                    txtclas = "B";
                    break;
                case "4":
                    txtclas = "B15";
                    break;

                case "5":
                    txtclas = "C";
                    break;

                case "6":
                    txtclas = "D";
                    break;
                default:
                    txtclas = "WAT2";
                    break;
            }
            temp += `
                    <tr productid=${peli.id}>
                        <td>
                            <img src="img/${peli.rutaportada}" width=300 height=300>
                        </td>
                        <td>
                            <ul>
                                <li>
                                    Titulo: ${peli.titulo}
                                </li>
                                <li> Duración: ${peli.duracion}</li>
                                <li> Genero: ${textgen}</li>
                                <li> Clasificación: ${txtclas}</li>
                            </ul>
                        </td>
                        <td>
                                    <a href='#'>Ver ahora</a>
                                </td>
                    </tr>
                `;
        });
        $('#peli').html(temp);
    });
}


function lista_serie() {
    var datos = {};
    datos.id = $('#iduser').val();
    var jsoncomp = JSON.stringify(datos);

    $.post("backend/lista_seri_user.php", jsoncomp, function(response) {
        let jsprod = JSON.parse(response);

        let temp = '';
        let textgen = "";
        let txtclas = "";
        jsprod.forEach(ser => {
            switch (ser.idgenero) {
                case "1":
                    textgen = "comedia";
                    break;
                case "2":
                    textgen = "terror";
                    break;
                case "3":
                    textgen = "drama";
                    break;
                case "4":
                    textgen = "accion";
                    break;

                case "5":
                    textgen = "Aventura";
                    break;

                default:
                    textgen = "WAT";
                    break;
            }
            switch (ser.idclasificacion) {
                case "1":
                    txtclas = "AA";
                    break;
                case "2":
                    txtclas = "A";
                    break;
                case "3":
                    txtclas = "B";
                    break;
                case "4":
                    txtclas = "B15";
                    break;

                case "5":
                    txtclas = "C";
                    break;

                case "6":
                    txtclas = "D";
                    break;
                default:
                    txtclas = "WAT2";
                    break;
            }
            temp += `
                <tr productid=${ser.id}>
                    <td><img src='img/${ser.rutaportada}' width=300 height=300></td>
                    <td>
                        <ul>
                            <li>Titulo: ${ser.titulo}</li>
                            <li>Temporadas: ${ser.numtemporadas}</li>
                            <li>Total de capitulos: ${ser.totalcapitulos}</li>
                            <li>Genero: ${textgen}</li>
                            <li>Clasificacion: ${txtclas}</li>
                        </ul>
                    </td>
                    <td>
                        <a href='#'>Ver ahora</a>
                    </td>
                </tr>
            `;
        });
        $('#seri').html(temp);
    });
}

function perfil() {
    var datos = {};
    datos.id = $('#iduser').val();
    var jsoncomp = JSON.stringify(datos);
    $.post("backend/userperfil.php", jsoncomp, function(response) {
        let jsprod = JSON.parse(response);
        jsprod.forEach(perf => {
            console.log(perf.usuario);
            $('#nom').html("Hola " + perf.usuario + "!" + "<img  id='img_prf' src='img/" + perf.rutaimagen + "' width=50 height=50>");
        })



    });
}