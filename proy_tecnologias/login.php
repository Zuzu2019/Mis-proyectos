<!-- Define que el documento esta bajo el estandar de HTML 5 -->
<!doctype html>

<!-- Representa la raíz de un documento HTML o XHTML. Todos los demás elementos deben ser descendientes de este elemento. -->
<html lang="es">
    
    <head>
        
        <meta charset="utf-8">
        
        <title> Formulario de Acceso </title>    
        
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        
        <meta name="author" content="Videojuegos & Desarrollo">
        <meta name="description" content="Ejemplo de formulario de acceso basado en HTML5 y CSS">
        <meta name="keywords" content="login,formulariode acceso html">
        
        <link href="https://fonts.googleapis.com/css?family=Nunito&display=swap" rel="stylesheet"> 
        
        <!-- Link hacia el archivo de estilos css -->
        <link rel="stylesheet" href="diseño.css">
        
        <style type="text/css">
            
        </style>
        
        <script type="text/javascript">
        
        </script>
        
    </head>
    
    <body>
    
        <div id="contenedor">
            
            <div id="contenedorcentrado">
                <div id="login">
                    <form id="login-form" class="form" action="backend/validar.php" method="post">
                        <label for="usuario">Usuario</label>
                        <input id="usuario" type="text" name="usuario" placeholder="Usuario" required>
                        
                        <label for="contraseña">Contraseña</label>
                        <input id="contraseña" type="password" placeholder="Contraseña" name="contraseña" required>
                        
                        <input id="botona" style="background-color:#CEF0EC " href="validar.php" type="submit" name="submit" class="btn btn-success btn-md" value="Iniciar sesión">
                    </form>
                    
                </div>
                <div id="derecho">
                    <div class="titulo">
                        Bienvenido
                    </div>
                    <div class="titulo">
                        Netfprime max+
                    </div>
                    <hr>
                    <div class="pie-form">
                        <a href="#">¿Perdiste tu contraseña?</a>
                        <a href="crearcuenta.php">¿No tienes Cuenta? Registrate</a>
                        <hr>
                        <a href="index.html">« Volver</a>
                    </div>
                </div>
            </div>
        </div>
        
    </body>
</html>


