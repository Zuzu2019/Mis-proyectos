<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Crear Cuenta</title>
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

$var = $_GET['idcuenta'];
   
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
                  <a type="button" class="btn btn-dark" href="seleccionarperfil.php?idcuenta=<?php echo $var?>">Perfiles</a>
                  <a href="cerrarsesion.php" type="button" class="btn btn-dark">Cerrar sesión</a>
                </div>
              </div>
        </div>
    </nav>

</header>
<body>
    <section class="espacio pt-4">
        <h3><strong>Editar perfil:</strong></h3><br>
        <input type='hidden' name='idcuenta' id='idcuenta' value="<?=$var;?>">
        <div class="card-deck">
        <table class="table table-bordered table-sm">
            <thead>
              <tr>
                <td>Id</td>
                <td>Usuario</td>
                <td>Foto de perfil</td>
              </tr>
            </thead>
            <tbody id="perfil"></tbody>
          </table>
        </div>
    </section>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js" integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=" crossorigin="anonymous"></script>
    <!-- Lógica del Frontend -->
    <script src="app.js"></script>
</body>
<footer class="w-100 py-4 flex-shrink-0">
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