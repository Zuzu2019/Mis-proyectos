<?php
    include_once __DIR__.'/database.php';
    $data = array(
        'status'  => 'error',
        'message' => 'No se inserto perfil'
    );

    // SE OBTIENE LA INFORMACIÓN DEL PRODUCTO ENVIADA POR EL CLIENTE   
    if(isset($_POST['usuario'])) {
       $id = $_POST['idcuenta'];
        $usuario = $_POST['usuario']; 
        $idioma = $_POST['idioma'];
        $edad = $_POST['edad'];       
        $foto = $_POST['foto'];
        
            $conexion->set_charset("utf8");
           
            $sql = "INSERT INTO perfil(usuario, idioma, edad, rutaimagen, idcuenta) 
            VALUES ('$usuario','$idioma', '$edad', '$foto','$id')";
            
            if($conexion->query($sql)){
                $data['status'] =  "success";
                $data['message'] =  "Perfil insertado";
                
            } else {
                echo "Error: " . $sql . "<br>" . mysqli_error($conexion);
               
            }        
        // Cierra la conexion
        $conexion->close(); 
        echo json_encode($data, JSON_PRETTY_PRINT);
    }
   
  
?>