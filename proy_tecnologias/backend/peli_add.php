<?php
    include_once __DIR__.'/database.php';

    $pelic = file_get_contents('php://input');
    
    $data = array(
        'status'  => 'error',
        'message' => 'Ya existe un producto con ese nombre'
    );
    if(!empty($pelic)) {
        $peli = json_decode($pelic);
        
        $titulo=$peli->titulo;
        $duracion=$peli->duracion;
        $region=$peli->region;
        $genero=$peli->genero;
        $clasificacion=$peli->clasificacion;
        $rutaportada=$peli->rutaportada;

        $idreg=substr($region, -1);
        $idreg++;
        $idclas="";
        $idgen="";

        $sqlgen="SELECT * FROM genero WHERE nombre='{$genero}'";
        $sqlclas="SELECT * FROM clasificacion WHERE clave='{$clasificacion}'";

        if($res1=$conexion->query($sqlgen)){
            $row=mysqli_fetch_array($res1);
            $idgen=$row['id'];
            $res1->free();
        }
        else{
            echo $sqlgen;
            die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
        }
        if($res2=$conexion->query($sqlclas)){
            
            $row=mysqli_fetch_array($res2);
            $idclas=$row['id'];
            $res2->free();
        }
        else{
            echo $sqlclas;
            die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
        }

        $sql = "INSERT INTO pelicula VALUES (null, '{$titulo}', '{$duracion}', '{$rutaportada}', {$idreg}, {$idgen}, {$idclas},  0)";
	    
        if($conexion->query($sql)){
            $data['status'] =  "success";
            $data['message'] =  "Producto agregado";
        } else {
            echo $sql."\n\n";
            $data['message'] = "ERROR: No se ejecuto $sql. " . mysqli_error($conexion);
        }
        //$result->free();
        // Cierra la conexion
        $conexion->close();
    }
    else{
        echo "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
    }

    // SE HACE LA CONVERSIÓN DE ARRAY A JSON
    echo json_encode($data, JSON_PRETTY_PRINT);
?>