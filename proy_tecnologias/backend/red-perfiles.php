<?php
include "./database.php";
$id = $_GET['perfilid'];
    $sql1 = "SELECT * from perfil where id='$id'";
      if( $consultaID = $conexion->query($sql1)){
        $rows1 = mysqli_fetch_array($consultaID);      
        echo $idcuenta = $rows1['idcuenta'];
        header("Location: ../seleccionarperfil.php?idcuenta=$idcuenta");
        exit();
    }
    else {
        die('Consulta fallida'.mysqli_error($conexion));
    }
       
?>