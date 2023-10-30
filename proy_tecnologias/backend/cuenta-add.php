<?php
    include_once __DIR__.'/database.php';

    // SE OBTIENE LA INFORMACIÓN DEL PRODUCTO ENVIADA POR EL CLIENTE
    $data = array(
        'status'  => 'error',
        'message' => 'Ya existe este correo con 1 cuenta'
    );

    if(isset($_POST['nombre'])) {
        
        $nombre = $_POST['nombre'];
        $apellido1 = $_POST['apellido1'];
        $apellido2 = $_POST['apellido2'];
        $correo = $_POST['correo'];
        $tipo = $_POST['tipo'];
        $pais = $_POST['pais'];
        $tarjeta = $_POST['numtarjeta'];
        $pago = $_POST['pago'];
        $usuario = $_POST['usuario'];
        $contraseña = $_POST['contraseña'];
       
        date_default_timezone_set('America/Mexico_City');      
        $date= date("Y-m-d");
        $time=date("H:m");
       $datetime=$date."T".$time;
        

            $query = "SELECT correo FROM cuenta WHERE correo = '$correo' ";
            $consulta = mysqli_query($conexion,$query);


            if($consulta->num_rows > 0)
            {
                $data['Status'] =  "Error";
                $data['Message'] =  "Ya existe correo con 1 cuenta";
            } else {
                 $sql = "INSERT INTO cuenta(nombre, apellido1, apellido2,correo,tipo,pais,numtarjeta,periodicidad,fechacreacion) 
                    VALUES ('$nombre','$apellido1', '$apellido2', '$correo', '$tipo','$pais', '$tarjeta', '$pago', '$datetime')";  
                    if($conexion->query($sql)){
                        $data['status'] =  "Success";
                        $data['message'] =  "Cuenta Agregada";                
                    } else {
                        echo "Error: " . $sql . "<br>" . mysqli_error($conexion);
                    
                    }
                   
                    }   
                     //consulta para conseguir el ultimo registro de la cuenta
                    $sql1="SELECT id FROM cuenta order by id DESC LIMIT 1";

                    if( $consultaID = $conexion->query($sql1)){
                        $rows1 = mysqli_fetch_array($consultaID);      
                        $id = $rows1['id'];
                    }
                    else {
                        die('Consulta fallida'.mysqli_error($conexion));
                    }
                 
                    $sql2 = "INSERT INTO usuario (user, pass, idcuenta) VALUES ('$usuario','$contraseña', '$id')";
                     if($conexion->query($sql2)){
                                  
                    } else {
                        echo "Error: " . $sql2 . "<br>" . mysqli_error($conexion);
                    
                    }     
        // Cierra la conexion
        $conexion->close();
    }

    echo json_encode($data, JSON_PRETTY_PRINT);
        
  
?>