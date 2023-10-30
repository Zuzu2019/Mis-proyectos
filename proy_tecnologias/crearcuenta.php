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
    <link rel="stylesheet" href="css/mdb.min.css" />
    <link rel="stylesheet" href="diseño.css" />

</head>
 <!-- <header id="header" class="fixed-top bg-success pt-3 pb-3">
        <div class="container-fluid">     
            <div class="row justify-content-center">
                <div class="col-xl-11 d-flex align-items-center">
                   <img class="rounded-circle" src="logo5.jpg" alt="" height="90px" width="130px">
                    <h1 class=" mr-auto text-light">Subee el mauuus</h1>
                    <nav class="nav-menu d-none d-lg-block">
                        <ul>
                            <li><a href="index.html">Inicio</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </header> -->
    <header>
    <nav class="navbar navbar-expand-sm">
        <div class="container">
            <div class="navbar-header">
                <h1 class="logo" href="" text-align="left">Sube el maus!</a>
            </div>
            <div class="btn-group">
                <a href="index.html" type="button" class="btn btn-danger">Ir a inicio</a>
              </div>
        </div>
    </nav>

</header>

<body>
    <section class="espacio pt-3">
    <div class="container">
        <h3><strong>Crear una cuenta:</strong></h3><br>
        <form id="cuenta-form" class="pb-5">
            <div id="cuenta-result" class="card text-white bg-danger my-4 d-none">

            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Nombre:<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="nombre" name="nombre" placeholder="Nombre completo" required>
                </div>
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Apellido materno:<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="apellido1" name="apellidom" placeholder="Apellido materno" required>
                </div>
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Apellido paterno:<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="apellido2" name="apellidop" placeholder="Apellido paterno" required>
                </div>
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Correo<span class="text-danger font-weight-bold"></span></label>
                    <input type="email" class="form-control" id="correo" name="correo" placeholder="Correo" required>
                </div>
            </div><br>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Tipo:<span class="text-danger font-weight-bold">
                        <select name="size" id = "tipo" size="1">
                            <option value="free">Free</option>
                            <option value="familiar">Familiar</option>
                            <option selected="premium" value="premium">Premium</option>
                        </select>
                </div>
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Pais: <span class="text-danger font-weight-bold"></label>
                    <input type="text" name="pais" id="pais" class="form-control" placeholder="" required>
                </div>
            </div><br>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Número de tarjeta:<span class="text-danger font-weight-bold"></span></label>
                    <input type="number" id="numtarjeta" class="form-control" name="numtarjeta" placeholder="" required>
                </div>
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Periocidad de pago:<span class="text-danger font-weight-bold"></span></label>
                    <select name="size" id="pago" size="1">
                        <option value="mensual">Mensual</option>
                        <option value="anual">Anual</option>
                    </select>
                </div>
                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Usuario:<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="usuario" name="usuario" placeholder="" required>
                </div>


                <div class="form-group col-md-6">
                    <label class="font-weight-bold">Contraseña:<span class="text-danger font-weight-bold"></span></label>
                    <input type="text" class="form-control" id="contraseña" name="contraseña" placeholder="Una contraseña " required>
                </div>
            </div><br>
            <button type="submit" class="btn btn-primary float-center">Guardar</button>
            <button type="reset" class="btn btn-danger float-center">Cancelar</button>


        </form>
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