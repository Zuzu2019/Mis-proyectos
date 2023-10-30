<?php
    include_once __DIR__.'/database.php';
   $id = $_GET['idcuenta'];
    $sql = "SELECT * FROM perfil";
    if ($result=mysqli_query($conexion,$sql)) {
        $rowcount=mysqli_num_rows($result);
    }

    $query = "SELECT * from perfil where eliminado = 0 and idcuenta='$id'";
    $result = mysqli_query($conexion, $query);
    if(!$result) {
      die('Query Failed'. mysqli_error($conexion));
    }
  
    $json = array();
    while($row = mysqli_fetch_array($result)) {
      $json[] = array(
        'usuario' => $row['usuario'],
        'rutaimagen' => $row['rutaimagen'],
        'id' => $row['id']
      );
    }
    $jsonstring = json_encode($json);
    echo $jsonstring;
?>