<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Editar perfil</title>
    <link rel="stylesheet" type="text/css" href="bootstrap/bootstrap/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="bootstrap/estilos.css">
    <link rel="stylesheet" href="bootstrap/letra.css">
    <link href="bootstrap/icofont/icofont.min.css" rel="stylesheet">
</head>
<style>
    html {
        min-height: 100%;
        position: relative;
    }
    body {
        margin: 0;
        margin-bottom: 40px;
    }
    footer {
        background-color: rgb(14, 12, 12); 
        position: absolute;
       
    }
    nav {
        font-family: 'Courier New', Courier, monospace;
        color: black;
    }
    
    h1 {
        font-family: 'Courier New', Courier, monospace;
        text-align: left;
    }  
    .logo {
        display: flex;
        align-items: left;
        letter-spacing: 3px;
        font-size: 300%;
        float: right;
        font-family: fantasy;
        color: rgb(253, 252, 252);
    }
    header {
        background-color: rgb(8, 8, 7);
    }
</style>
<?php


session_start();
error_reporting(0);
$varsesion = $_SESSION['usuario'];
$varcontra = $_SESSION['contraseña'];
if($varsesion == null || $varsesion=''){
    echo 'No tiene autorización';
    die();
}     
  
include "backend/database.php";
$usuario  = '';
$idioma = '';
$edad = '';
$foto = '';

$var = $_GET['id'];
   
$sql = mysqli_query($conexion, "SELECT * from perfil where id=$var");
$row = mysqli_num_rows($sql);
if($row > 0)
{
    while ($arr = mysqli_fetch_assoc($sql)){
        $id = $arr['id'];
        $usuario  = $arr['usuario'];
        $idioma = $arr['idioma'];
        $edad = $arr['edad'];
        $foto = $arr['rutaimagen'];
        $idcuenta = $arr['idcuenta'];
    }
}
  
?>
<header>
    <nav class="navbar navbar-expand-sm">
        <div class="container">
            <div class="navbar-header">
                <h1 class="logo" href="" text-align="left">Sube el maus!</a>
            </div>
            <div class="btn-group">
                
                <div class="btn-group">
                  <a type="button" class="btn btn-dark" href="edit.php?idcuenta=<?php echo $idcuenta?>">Perfiles</a>
                  <a href="cerrarsesion.php" type="button" class="btn btn-dark">Cerrar sesión</a>
                </div>
              </div>
        </div>
    </nav>

</header>

    <body>
        <section class="espacio pt-4">
            <h3><strong>Editar perfil: </strong></h3><br>
            <div class="card my-4 d-none" id="perfil-result">
                    <div class="card-body">
                        <ul id="container"></ul>
                    </div>
                </div>
            <form  id="editar-form" class="pb-5">
                <div class="form-row"><div id="load_img">
                        <img class="img-responsive" alt="Logo" src="<?=$foto;?>">
                    </div>
                    <br>
                    <div class="form-group col-md-6">
                    <div class="form-group col-md-6">
                    <label class="font-weight-bold">Imagen</label>
                    <input type="text" class="form-control" id="imagen" name="imagen" placeholder="" value="<?=$foto;?>" required>
                </div>

                    </div>
                    <div hidden>
                        <label class="font-weight-bold">ID:<span class="text-danger font-weight-bold"></span></label>
                        <input type="text" class="form-control" id="id" name="id" placeholder="" value="<?=$id;?>">
                    </div>
                    <div class="form-group col-md-6">
                        <label class="font-weight-bold">Usuario:<span class="text-danger font-weight-bold"></span></label>
                        <input type="text" class="form-control" id="usuario" name="usuario" placeholder="" value="<?=$usuario;?>" required>
                    </div>
                    <div class="form-group col-md-6">
                        <label class="font-weight-bold">Idioma:<span class="text-danger font-weight-bold"></span></label>
                        <input type="text" class="form-control" name="idioma" id="idioma" value="<?=$idioma;?>" placeholder="" required>
                    </div>
                    <div class="form-group col-md-6">
                        <label class="font-weight-bold">Edad:<span class="text-danger font-weight-bold"></span></label>
                        <input type="text" class="form-control" id="edad" name="edad" value="<?=$edad;?>" placeholder="" required>
                    </div>
                    
                </div>

                </div><br>

                </div><br>

                <input type="submit" value="Guardar" class=" editar btn btn-primary float-center">
                <input type="submit" id="<?=$id;?>" value="Eliminar" class=" eliminar btn btn-danger float-center" name="eliminar">
               
                
            </form>
        </section>

        <script src="https://code.jquery.com/jquery-3.3.1.min.js" integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=" crossorigin="anonymous"></script>
        <!-- Lógica del Frontend -->
        <script src="app.js"></script>


    </body>

    <footer class="w-100 py-1 flex-shrink-0">
        <div class="container py-4">
            <div class="row gy-4 gx-5">
                <div class="col-lg-4 col-md-6">
                    <h5 class="h1 text-white">Sube el maus</h5>
                    <p class="small text-muted"></p>
                    <p class="small text-muted mb-0">&copy; Copyrights. All rights reserved. <a class="text-primary" href="#"></a></p>
                </div>
                <div class="col-lg-2 col-md-6">
                    <h5 class="text-white mb-3">Contactanos</h5>
                    <ul class="list-unstyled text-muted">
                        <li><a href="#">Privacidad</a></li>
                        <li><a href="#">About</a></li>
                        
                    </ul>
                </div>
                <div class="col-lg-2 col-md-6">
                    <h5 class="text-white mb-3">Preguntas</h5>
                    <ul class="list-unstyled text-muted">
                        <li><a href="#">Centro de ayuda</a></li>
                        <li><a href="#">About</a></li>
                    </ul>
                </div>
                <div class="col-lg-4 col-md-6">
                    <h5 class="text-white mb-3">Streaming México</h5>
                    <p class="small text-muted">Sube el maus es un servicio de streaming que ofrece una gran variedad de películas, series y documentales premiados en casi cualquier pantalla conectada a internet.</p>
                    <form action="#">
                        <div class="input-group mb-3">
                            <input class="form-control" type="text" placeholder="Recipient's username" aria-label="Recipient's username" aria-describedby="button-addon2">
                            <button class="btn btn-primary" id="button-addon2" type="button"><i class="fas fa-paper-plane"></i></button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </footer>

</html>