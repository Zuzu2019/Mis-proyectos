<?php
    include_once __DIR__.'/database.php';

    $seri = file_get_contents('php://input');
    
    $data = array(
        'status'  => 'error',
        'message' => 'Ya existe un producto con ese nombre'
    );
    if(!empty($seri)) {
        $ser = json_decode($seri);
        
        $titulo=$ser->titulo;
        $numtemporadas=$ser->numtemporadas;
        $region=$ser->region;
        $totalcapitulos=$ser->totalcapitulos;
        $genero=$ser->genero;
        $clasificacion=$ser->clasificacion;
        $rutaportada=$ser->rutaportada;

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

        $sql = "INSERT INTO serie VALUES (null, '{$titulo}', '{$numtemporadas}', {$totalcapitulos}, '{$rutaportada}', {$idreg}, {$idgen}, {$idclas},  0)";
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