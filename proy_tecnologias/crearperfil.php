<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Crear Perfil</title>
    <link rel="stylesheet" type="text/css" href="bootstrap/bootstrap/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="bootstrap/estilos.css">
    <link rel="stylesheet" href="bootstrap/letra.css">
    <link href="bootstrap/icofont/icofont.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.11.2/css/all.css" />
    <link rel="stylesheet" href="diseño_header.css" />
</head>

<?php
    include "backend/database.php";
     
    session_start();
    error_reporting(0);
    $varsesion = $_SESSION['usuario'];
    if($varsesion == null || $varsesion=''){
        echo 'No tiene autorización';
        die();
    }
    $var = $_GET['idcuenta'];
    //echo $var;

?>
<header>
    <nav class="navbar navbar-expand-sm">
        <div class="container">
            <div class="navbar-header">
                <h1 class="logo" href="" text-align="left">Sube el maus!</a>
            </div>
            <div class="btn-group">
                
                <div class="btn-group">
                <a href="seleccionarperfil.php?idcuenta=<?php echo $var?>" type="button" class="btn btn-dark">Perfiles</a>
                  <a href="cerrarsesion.php" type="button" class="btn btn-dark">Cerrar sesión</a>
                </div>
              </div>
        </div>
    </nav>

</header>

<body>
    
        <section class="espacio pt-4">
        <h3><strong>Crear un nuevo perfil:</strong></h3><br>
        <form id="perfil-form" class="pb-5">
        <div id="perfil-result" class="card text-white bg-danger my-4 d-none "></div> 
       <input type='hidden' name='idcuenta' id='idcuenta' value="<?=$var;?>">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Usuario:<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="usuario" name="usuario" placeholder="" required>
                </div>
                
            </div><br>
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Idioma:<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="idioma" name="idioma" placeholder="" required>
                </div>
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Edad:<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="edad" name="edad" placeholder="" required>
                </div>

                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Imagen<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="foto" name="foto" placeholder="" required>
                </div>
            </div><br>
            <button type="reset" class="btn btn-danger float-center ">Cancelar</button>
            <button type="submit" class="btn btn-primary float-center ">Guardar</button>
        </form>
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