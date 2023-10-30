<?php
include_once __DIR__.'/database.php';

session_start();

    
if(isset($_POST['usuario'])) {
    $usuario = $_POST['usuario'];
    $contraseña = $_POST['contraseña'];

    $_SESSION['usuario'] = $usuario;
    $_SESSION['contraseña'] = $contraseña;


    //Seleccionar el idcuenta de un usuario
    $sql1 =  $conexion->query("SELECT * FROM usuario WHERE user='$usuario' and pass='$contraseña'");
    $rows1 = $sql1->fetch_all(MYSQLI_ASSOC);
    foreach($rows1 as $num => $registro)
    {           
        $id = $rows1[$num]['idcuenta'];  
    };
          
    //validar que el inicio de sesión sea correcto y redireccionar a la siguiente pagina
    $sql = "SELECT user, pass, idcuenta FROM usuario WHERE user='$usuario' and pass='$contraseña'";
    $result = mysqli_query($conexion, $sql);
    $rows = mysqli_num_rows($result);

    if ($rows>0 )
    {
        header("location: ../seleccionarperfil.php?idcuenta=$id");
    }
    else {
        echo "Error de autenticación";
    }

    mysqli_free_result($result);
    mysqli_close($conexion);
    
}        
  
?>