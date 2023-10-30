<?php
    include_once __DIR__.'/database.php';
    $pelic = file_get_contents('php://input');
    $data = array();

    //campos
    if(!empty($pelic)){
        
        $peli = json_decode($pelic);

        $userid=$peli->id;

        $perfilnombre="";

        $sql="SELECT * FROM perfil WHERE id = {$userid} AND eliminado=0";
        if(!$result=$conexion->query($sql)){
            echo $sql."\n";
            die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
            $data['status'] =  "error";
            $data['message'] =  "";
        }
        else{
            $rows = $result->fetch_all(MYSQLI_ASSOC);

            if(!is_null($rows)) {
                // SE CODIFICAN A UTF-8 LOS DATOS Y SE MAPEAN AL ARREGLO DE RESPUESTA
                foreach($rows as $num => $row) {
                    foreach($row as $key => $value) {
                        $data[$num][$key] = utf8_encode($value);
                    }
                }
            }
            $result->free();
        }
        
        
        $conexion->close();
        //$data['img']=$perfilimg;
        echo json_encode($data, JSON_PRETTY_PRINT);
    }
    else{
        
    }

    
?>