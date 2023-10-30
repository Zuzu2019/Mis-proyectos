$(document).ready(function(){
    $('#idp').hide();
    $('#ids').hide();
    $('.ocult1').hide();
    $('.ocult2').hide();
    let anadir=false;
    lista_pelic();
    lista_serie();
    $('#search').keyup(function(){
        if($('#search').val()){
            let search=$('#search').val();
            $("#pelic > tbody").empty();
            $.ajax({
                
                url: 'backend/lista_busq_peli.php',
                type: 'POST',
                data: {search},
                success: function(resp){
                    let resul=JSON.parse(resp);
                    console.log(resul);
                    let plant='';
                    resul.forEach(peli=>{
                        plant+=`
                            <tr productid=${peli.id}>
                                <td>${peli.id}</td>
                                <td>
                                    <a href="#">${peli.titulo}</a>
                                </td>
                                <td>${peli.duracion}</td>
                                <td>${peli.descripcion}</td>
                                <td>${peli.nombre}</td>
                                <td>${peli.clave}</td>
                                <td><img src="img/${peli.rutaportada}" width=50 height=50></td>
                                <td>
                                    <button class='peli-edit btn btn-outline-secondary'>
                                        Editar datos
                                    </button>
                                </td>
                                <td>
                                    <button class='peli-delete btn-outline-danger'>
                                        Eliminar pelicula
                                    </button>
                                </td>
                            </tr>
                        `;
                    })
                    $('#pelics').html(plant);
                    
                    
                    //$('#product-result').show();
                }
            })
            $("#ser > tbody").empty();
            $.ajax({
                
                url: 'backend/lista_busq_seri.php',
                type: 'POST',
                data: {search},
                success: function(resp){
                    let resul=JSON.parse(resp);
                    console.log(resul);
                    let plant='';
                    resul.forEach(ser => {
                        plant += `
                            <tr productid=${ser.id}>
                                <td>${ser.id}</td>
                                <td>
                                    <a href="">${ser.titulo}</a>
                                </td>
                                <td>${ser.numtemporadas}</td>
                                <td>${ser.totalcapitulos}</td>
                                
                                <td>${ser.descripcion}</td>
                                <td>${ser.nombre}</td>
                                <td>${ser.clave}</td>
                                <td><img src='img/${ser.rutaportada}' width=50 height=50></td>
                                <td>
                                    <button class='seri-edit btn btn-outline-secondary'>
                                        Editar datos
                                    </button>
                                </td>
                                <td>
                                    <button class='seri-delete btn-outline-danger'>
                                        Eliminar serie
                                    </button>
                                </td>
                            </tr>
                        `;
                    });
                    $('#sers').html(plant);
                    
                    
                    //$('#product-result').show();
                }
            })
    
        }
    

    })

    $(document).on('click', '.peli-delete', function(){
        if(window.confirm("Estas seguro de querer eliminar el elemento seleccionado? \n este dato se perdera para siempre!")){
            let elem=$(this)[0].parentElement.parentElement;
            let id=$(elem).attr('productid');

            $.post('backend/pelicula-delete.php', {id}, function(response){
                let resp=JSON.parse(response)
                console.log(resp);
                lista_pelic();
                lista_serie();
            })
        }
    })
    $(document).on('click', '.peli-edit', function(){
        $('.ocult1').show();
        let element=$(this)[0].parentElement.parentElement;
        let id=$(element).attr('productid');
        $.post('backend/peli_solo.php', {id}, function(response){
            console.log(response);
            
            let peli = JSON.parse(response);
            $('#idp').val(peli.id);
            $('#titup').val(peli.titulo);
            $('#durap').val(peli.duracion);
            $('#regp').val(peli.idregion);
            $('#genp').val(peli.idgenero);
            $('#clasp').val(peli.idclasificacion);
            $('#imagp').val(peli.rutaportada);
            $('html, body').scrollTop(0);
        })
    })
    $(document).on('click', '.seri-delete', function(){
        if(window.confirm("Estas seguro de querer eliminar el elemento seleccionado? \n este dato se perdera para siempre!")){
            let elem=$(this)[0].parentElement.parentElement;
            let id=$(elem).attr('productid');
            
            $.post('backend/serie-delete.php', {id}, function(response){
                //let resp=JSON.parse(response)
                
                lista_pelic();
                lista_serie();
            })
        }
    })
    $('#peli-form').submit(function(e){
        let url="backend/peli_edit.php";
        e.preventDefault();
        var datos={};
        datos.id=$('#idp').val();
        datos.titulo=$('#titup').val();
        datos.duracion=$('#durap').val();
        datos.region=$('#regp').val();
        datos.genero=$('#genp').val();
        datos.clasificacion=$('#clasp').val();
        datos.rutaportada=$('#imagp').val();
        var jsoncomp=JSON.stringify(datos);
        

        if(anadir){url="backend/peli_add.php"}
        console.log(url);
        $.post(url, jsoncomp, function(response){
            console.log(response);
            console.log(url+", "+anadir);
            document.getElementById('peli-form').reset();
            lista_pelic();
            $('.ocult1').hide();
            if(anadir){anadir=false}
        });
        
    })
    $(document).on('click', '#canc', function(){
        $('.ocult1').hide();
        $('.ocult2').hide();
        anadir=false;
        $('#sub1').attr("value","Editar pelicula");
        $('#sub2').attr("value","Editar pelicula");
    })
    $(document).on('click', '.addp', function(){
        $('.ocult1').show();
        $('#sub1').attr("value","Añadir pelicula");
        $('html, body').scrollTop(0);
        anadir=true;
    })
    $(document).on('click', '.adds', function(){
        $('.ocult2').show();
        $('#sub2').attr("value","Añadir serie");
        $('html, body').scrollTop(0);
        anadir=true;
    })

    $(document).on('click', '.seri-edit', function(){
        $('.ocult2').show();
        let element=$(this)[0].parentElement.parentElement;
        let id=$(element).attr('productid');
        
        $.post('backend/seri_solo.php', {id}, function(response){
            console.log(response);
            
            let seri = JSON.parse(response);
            $('#ids').val(seri.id);
            $('#titus').val(seri.titulo);
            $('#temps').val(seri.numtemporadas);
            $('#capis').val(seri.totalcapitulos);
            $('#regs').val(seri.idregion);
            $('#gens').val(seri.idgenero);
            $('#class').val(seri.idclasificacion);
            $('#imags').val(seri.rutaportada);
            $('html, body').scrollTop(0);
        })
        
    })
    $('#seri-form').submit(function(e){
        e.preventDefault();
        let url="backend/seri_edit.php";
        var datos={};
        console.log("------------------------------------fin");
        datos.id=$('#ids').val();
        datos.titulo=$('#titus').val();
        datos.numtemporadas=$('#temps').val();
        datos.totalcapitulos=$('#capis').val();
        datos.region=$('#regs').val();
        datos.genero=$('#gens').val();
        datos.clasificacion=$('#class').val();
        datos.rutaportada=$('#imags').val();
        var jsoncomp=JSON.stringify(datos);
        console.log(jsoncomp);

        if(anadir){url="backend/seri_add.php"}
        
        $.post(url, jsoncomp, function(response){
            let resp=JSON.parse(response)
            console.log(resp);
            document.getElementById('seri-form').reset();
            lista_serie();
            $('.ocult2').hide();
            if(anadir){anadir=false}
        });
        
    })
})

function lista_pelic(){
    $.ajax({
        url: "backend/lista_peliculas.php",
        type: 'GET',
        success: function(response){
            let jsprod=JSON.parse(response);
                let temp='';
                jsprod.forEach(peli => {
                    temp += `
                        <tr productid=${peli.id}>
                            <td>${peli.id}</td>
                            <td>
                                <a href="#">${peli.titulo}</a>
                            </td>
                            <td>${peli.duracion}</td>
                            <td>${peli.idregion}</td><!---imagen-->
                            <td>${peli.idgenero}</td>
                            <td>${peli.idclasificacion}</td>
                            <td><img src="img/${peli.rutaportada}" width=50 height=50></td>
                            <td>
                                <button class='peli-edit btn btn-outline-secondary'>
                                    Editar datos
                                </button>
                            </td>
                            <td>
                                <button class='peli-delete btn btn-outline-danger'>
                                    Eliminar pelicula
                                </button>
                            </td>
                        </tr>
                    `;
                });
                $('#pelics').html(temp);
        }
    })
}

function lista_serie(){
    $.ajax({
        url: "backend/lista_series.php",
        type: 'GET',
        success: function(response){
            let jsprod=JSON.parse(response);
                let temp='';
                jsprod.forEach(ser => {
                    temp += `
                        <tr productid=${ser.id}>
                            <td>${ser.id}</td>
                            <td>
                                <a href="#">${ser.titulo}</a>
                            </td>
                            <td>${ser.numtemporadas}</td>
                            <td>${ser.totalcapitulos}</td>
                            <td>${ser.idregion}</td><!---imagen-->
                            <td>${ser.idgenero}</td>
                            <td>${ser.idclasificacion}</td>
                            <td><img src='img/${ser.rutaportada}' width=50 height=50></td>
                            <td>
                                <button class='seri-edit btn btn-outline-secondary'>
                                    Editar datos
                                </button>
                            </td>
                            <td>
                                <button class='seri-delete btn btn-outline-danger'>
                                    Eliminar serie
                                </button>
                            </td>
                        </tr>
                    `;
                });
                $('#sers').html(temp);
        }
    })
}
