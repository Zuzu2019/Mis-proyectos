<?php
    include_once __DIR__.'/database.php';
    $data = array(
        'status'  => 'error',
        'message' => 'Ya existe un producto con ese nombre'
    );

    // SE OBTIENE LA INFORMACIÓN DEL PRODUCTO ENVIADA POR EL CLIENTE   
    if(isset($_POST['usuario'])) {

        $id = $_POST['id'];
        $usuario = $_POST['usuario']; 
        $idioma = $_POST['idioma'];
        $edad = $_POST['edad'];
        $imagen = $_POST['imagen'];      
           
            $sql = "UPDATE perfil SET usuario='$usuario', idioma='$idioma', edad='$edad', rutaimagen='$imagen' WHERE id='$id'";
            
            if($conexion->query($sql)){          
                 $data['status'] =  "success";
                 $data['message'] =  "Perfil actualizado";
            } else {
                echo "Error: " . $sql . "<br>" . mysqli_error($conexion);
               
            }    
           
    
        // Cierra la conexion
        $conexion->close();
        
    } 
    echo json_encode($data, JSON_PRETTY_PRINT);
?>