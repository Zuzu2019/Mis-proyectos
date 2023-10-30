<!DOCTYPE html>
<html lang="es">
<head>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
<link rel="stylesheet" href="diseño_header.css" />  
   <style type="text/css">
        body{
            padding: 20px;
            
        }
        .ocult1{
            position: relative;
            width: 300px;
            left:100px;
        }
        .ocult2{
            position: relative;
            width: 300px;
            left: 600px;
        }
        .adds{
            float: right;
        }
        table { box-shadow: 10px 10px 5px #888; }
    </style>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Administrador</title>
</head>
<header>
    <nav class="navbar navbar-expand-sm">
        <div class="container">
            <div class="navbar-header">
                <h1 class="logo" href="" text-align="left">Sube el maus!</a>
            </div>
            <div class="btn-group">
            <form class="form-inline">
                <input class="form-control mr-sm-2" id="search" type="search" placeholder="Busqueda (id, titulo)" aria-label="Search">
            </form>
                <div class="btn-group">
                  <a href="cerrarsesion.php" type="button" class="btn btn-dark">Cerrar sesión</a>
                </div>
              </div>
        </div>
    </nav>

</header>
<body>
    <br>
<nav class="navbar navbar-light bg-light justify-content-between">
  <a href="./pag_princ.php?perfilid=1" class="navbar-brand"></a>
  <a class="addp btn btn-primary" role="button">Añadir una nueva pelicula</a>
</nav>
    <div class="ocult1">
        <form id="peli-form" method="post">
            <div class="form-group">
            <input class="form-control" type="text" name="idp" id="idp">
                <label for="">Titulo</label>
                <input class="form-control" type="text" name="titup" id="titup" required>
                <label for="">Duracion</label>
                <input class="form-control" type="text" name="durap" id="durap" required>
                
                <label for="">Region</label>
                <select class="form-control" id="regp">
                    <option value="Region 0">Region 0</option>
                    <option value="Region 1">Region 1</option>
                    <option value="Region 2">Region 2</option>
                    <option value="Region 3">Region 3</option>
                    <option value="Region 4">Region 4</option>
                    <option value="Region 5">Region 5</option>
                    <option value="Region 6">Region 6</option>
                    <option value="Region 7">Region 7</option>
                    <option value="Region 8">Region 8</option>
                </select>
                <label for="">Genero</label>
                <select class="form-control" id="genp">
                    <option value="comedia">comedia</option>
                    <option value="terror">terror</option>
                    <option value="drama">drama</option>
                    <option value="accion">accion</option>
                    <option value="???">???</option>
                </select>
                <label for="">Clasificacion</label>
                <select class="form-control" id="clasp">
                    <option value="AA">AA</option>
                    <option value="A">A</option>
                    <option value="B">B</option>
                    <option value="B15">B15</option>
                    <option value="C">C</option>
                    <option value="D">D</option>
                </select>
                <label for="">Ruta de imagen: img/</label>
                <input class="form-control" type="text" name="imagp" id="imagp" required>
                <input class="btn btn-primary float-center" id="sub1" type="submit" value="Editar pelicula">
                <input class="btn btn-danger float-center" id="canc" type="reset" value="Cancelar">
                
            </div>
        </form>
    </div>
    <div class="ocult2">
        <form id="seri-form" action="" method="post">
            <div class="form-group">
            <input class="form-control" type="text" name="ids" id="ids">
                <label for="">Titulo</label>
                <input class="form-control" type="text" name="titus" id="titus" required>
                <label for="">Temporadas</label>
                <input class="form-control" type="number" name="temps" id="temps" required>
                <label for="">Capitulos totales</label>
                <input class="form-control" type="number" name="capis" id="capis" required>
                <label for="">Region</label>
                <select class="form-control" id="regs">
                    <option value="Region 0">Region 0</option>
                    <option value="Region 1">Region 1</option>
                    <option value="Region 2">Region 2</option>
                    <option value="Region 3">Region 3</option>
                    <option value="Region 4">Region 4</option>
                    <option value="Region 5">Region 5</option>
                    <option value="Region 6">Region 6</option>
                    <option value="Region 7">Region 7</option>
                    <option value="Region 8">Region 8</option>
                </select>
                <label for="">Genero</label>
                <select class="form-control" id="gens">
                    <option value="comedia">comedia</option>
                    <option value="terror">terror</option>
                    <option value="drama">drama</option>
                    <option value="accion">accion</option>
                    <option value="???">???</option>
                </select>
                <label for="">Clasificacion</label>
                <select class="form-control" id="class">
                    <option value="AA">AA</option>
                    <option value="A">A</option>
                    <option value="B">B</option>
                    <option value="B15">B15</option>
                    <option value="C">C</option>
                    <option value="D">D</option>
                </select>
                <label for="">Ruta de imagen: img/</label>
                <input class="form-control" type="text" name="imags" id="imags" required>
                
                <input class="btn btn-primary float-center" id="sub2" type="submit" value="Editar pelicula">
                <input class="btn btn-danger float-center" id="canc" type="reset" value="Cancelar">
                
            </div>
        </form>
    </div>
    <h1>Todas las peliculas</h1>
    <br>
    <table class="table table-dark table-striped" id="pelic">
        <thead>
            <tr>
                <th scope="col">ID</th>
                <th scope="col">Titulo</th>
                <th scope="col">Duracion</th>
                <th scope="col">Region</th>
                <th scope="col">Genero</th>
                <th scope="col">Clasificacion</th>
                <th scope="col">Caratula</th>
                <th scope="col">Editar</th>
                <th scope="col">Eliminar</th>
            </tr>
        </thead>
        <tbody id="pelics">
        </tbody>
    </table>
    <br>
    <br>
    <h1>Todas las series </h1>
    <a class="adds btn btn-primary" role="button">Añadir una nueva serie</a>
    <br>
    <br>
    <table class="table table-dark table-striped" id="ser">
        <thead>
            <tr>
                <th scope="col">ID</th>
                <th scope="col">Titulo</th>
                <th scope="col">Temporadas</th>
                <th scope="col">Capitulos totales</th>
                <th scope="col">Region</th>
                <th scope="col">Genero</th>
                <th scope="col">Clasificacion</th>
                <th scope="col">Caratula</th>
                <th scope="col">Editar</th>
                <th scope="col">Eliminar</th>
            </tr>
        </thead>
        <tbody id="sers">

        </tbody>
    </table>
    <footer class="w-100 py-4 flex-shrink-0">
        <div class="container py-4">
            <div class="row gy-4 gx-5">
                <div class="col-lg-4 col-md-6">
                    <h5 class="h1 text-white">Sube el maus!</h5>
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
<script src="https://code.jquery.com/jquery-3.3.1.min.js"
      integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8="
      crossorigin="anonymous"></script>
<script src="jq.js"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
</body>
</html>