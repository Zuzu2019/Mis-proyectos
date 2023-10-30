<!DOCTYPE html>
<html lang="es">
<head>
    <link rel="stylesheet" type="text/css" href="bootstrap/bootstrap/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="bootstrap/estilos.css">
    <link rel="stylesheet" href="bootstrap/letra.css">
    <link href="bootstrap/icofont/icofont.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.11.2/css/all.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" 
    integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="diseño_header.css" />
    <style type="text/css">
        
        div.peliculas{
          width: 1000px;
          margin: 0 auto;
        }
        div.series{
          width: 1000px;
          margin: 0 auto;
        }
        p.u_inf{
          text-align:right;
        }
        img#img_prf{
          border-radius: 50%;
        }
        ul {
            list-style-type: none;
        }
        .peliculas{
            margin-left: auto;
            margin-right: auto;
        }
    </style>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pagina princial</title>
</head>
<?php

session_start();
error_reporting(0);
$varsesion = $_SESSION['usuario'];
$varcontra = $_SESSION['contraseña'];
if($varsesion == null || $varsesion=''){
    echo 'No tiene autorización';
    die();
} 
$id = $_GET['perfilid'];
  
?>
<header>
    <nav class="navbar navbar-expand-sm">
        <div class="container">
            <div class="navbar-header">
                <h1 class="logo" href="" text-align="left">Sube el maus!</a>
            </div>
            <?php
            if($_GET['perfilid']==1){
              echo "<li class='nav-item'>";
              echo "<a class='nav-link' href='./admin.php'>Admin</a>";
              echo "</li>";
            }
          ?>
                </div>
            </div>
        </div>
            <div class="btn-group">
                  <a href="index.html" type="button" class="btn btn-dark">Inicio</a>
                  <a href="backend/red-perfiles.php?perfilid=<?php echo $id?>" type="button" class="btn btn-dark">Cambiar perfil</a>
                  <a href="cerrarsesion.php" type="button" class="btn btn-dark">Cerrar sesión</a> 
                 
                </div> 
                <form class="d-flex">      
                    <input id="search" class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
                    <button class="btn btn-primary" type="submit" disabled>Buscar</button>
                  </form>
              </div>
        </div>
    </nav>

</header>
<body>

<div class="container  pt-4">
      <h1 class="text-center" aria-current="page" href="#">Pagina principal</h1>
      </div>
      <div class="container">
          <div class= "container">  
            <?php
          echo "<input type='text' name='iduser' id='iduser' value=",$id,">";
            ?>
        <p id="nom" class="u_inf"></p>
        <div class="container p-3 my-5 border">
            <h1>Lista de peliculas!</h1>
          <div class="peliculas">
              <table class="table " id="peli" style="margin-left:auto; margin-right:auto; text-align:center;">
                  
              </table>
          </div>
      </div>
      <div class="container p-3 my-5 border">
        <h1>Series del momento...</h1>
        <div class="series">
              <table class="table" id="seri" style="margin-left:auto; margin-right:auto; text-align:center;">

              </table>
        </div>
      </div>
  
  </div>
</div>

<script src="https://code.jquery.com/jquery-3.3.1.min.js"
      integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="
      crossorigin="anonymous"></script>
<script src="jqprinc.js"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
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