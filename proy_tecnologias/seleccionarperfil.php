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
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.11.2/css/all.css" />
    <link rel="stylesheet" href="diseño_header.css" />
    <style type="text/css">
        .card { box-shadow: 10px 10px 5px #888; }
        .footer {
            position:absolute;
            bottom:0px;
            margin: 0;
        }

    </style>
</head>

<?php
    include "backend/database.php";
     
    session_start();
    error_reporting(0);
    $varsesion = $_SESSION['usuario'];
    $varcontra = $_SESSION['contraseña'];
    if($varsesion == null || $varsesion=''){
        echo 'No tiene autorización';
        die();
    }

    $var=$_GET['idcuenta'];
    $result = ("SELECT id, usuario, rutaimagen FROM perfil WHERE idcuenta=$var and eliminado = 0 ");
        // SE OBTIENEN LOS RESULTADOS
        $rows = mysqli_query($conexion, $result);
?>
<header>
    <nav class="navbar navbar-expand-sm">
        <div class="container">
            <div class="navbar-header">
                <h1 class="logo" href="" text-align="left">Sube el maus!</a>
            </div>
            <div class="btn-group">
                
                <div class="btn-group">
                  <a href="cerrarsesion.php" type="button" class="btn btn-dark">Cerrar sesión</a>
                </div>
              </div>
        </div>
    </nav>

</header>
    <body>
        
        <section class="espacio pt-3">
            <div class= "container-sm border p-4 my-3 bg-dark text-white">
                <h4 class="h4">Cuenta: <?php echo $_SESSION['usuario']; ?> </h4>
                <?php             
                $sql = "SELECT * FROM perfil where idcuenta=$var";
                $sql2 = "SELECT idcuenta from perfil";
                $result2 = mysqli_query($conexion, $sql2);
                if ($result=mysqli_query($conexion,$sql)) {
                    $rowcount=mysqli_num_rows($result);
                    
                }

                if($rowcount >= 7 and $result=$var)
                {
                    echo"No puedes crear otro perfil";
                }
                else  {                     
                echo '<a id="crear" class="col" href="./crearperfil.php?idcuenta='.$var.'">Crear nuevo perfil</a>';
                }?>
               

                <a id="" href="edit.php?idcuenta=<?php echo $var?>">Edita tu perfil</a>
               
            </div>
            <div class= "container-sm p-3 my-3 text-center">
                <h2><strong>Elige tu perfil:</strong></h2><br>
            </div>
         
            <div class="container mt-3">
        <div class="row">
            <?php
           
            while ($perfil = mysqli_fetch_assoc($rows)) {
                ?>
                <div class="col-lg-4 col-md-6 col-sm-12">
                    <div class="card">
                        <center>
                             <img src="img/perfil/<?php echo $perfil['rutaimagen']; ?>" class="card-img-top" alt="..." style="width: 150px; height: 100px;">
                        <div class="card-body">
                            <h5 class="card-title"><?php echo $perfil['usuario'] . " " . $row[1]; ?></h5>
                            <a href="./pag_princ.php?perfilid=<?php echo $perfil['id'];?>" class="btn btn-primary">Gooo</a>
                        </div> 
                    </center>
                    </div>
                </div>
            <?php
            }
            ?>
        </div>
    </div>

    
 </div>
        </section>
        <script src="https://code.jquery.com/jquery-3.3.1.min.js" integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=" crossorigin="anonymous"></script>
        <!-- Lógica del Frontend -->
        <script src="app.js"></script>

</body>
<br>
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