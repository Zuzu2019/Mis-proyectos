<?php
    include_once __DIR__.'/database.php';
    $serie = file_get_contents('php://input');
    $data = array(
        'status'  => 'error',
        'message' => 'Ya existe un producto con ese nombre'
    );

    //campos
    if(!empty($serie)){
        
        $seri = json_decode($serie);

        $id=$seri->id;
        $titulo=$seri->titulo;
        $numtemporadas=$seri->numtemporadas;
        $totalcapitulos=$seri->totalcapitulos;
        $region=$seri->region;
        $genero=$seri->genero;
        $clasificacion=$seri->clasificacion;
        $rutaportada=$seri->rutaportada;

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

        $sql="UPDATE serie SET titulo='{$titulo}', numtemporadas={$numtemporadas}, totalcapitulos={$totalcapitulos}, rutaportada='{$rutaportada}', idregion={$idreg}, idgenero={$idgen}, idclasificacion={$idclas} WHERE id={$id}";
        

        
        if(!$result=$conexion->query($sql)){
            echo $sql."\n";
            die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
            $data['status'] =  "error";
            $data['message'] =  "Producto no Editado";
        }
        else{
            $data['status'] =  "Conseguido";
            $data['message'] =  "Producto Editado";
        }
        $conexion->close();
        echo json_encode($data, JSON_PRETTY_PRINT);

    }
    else{
        
    }

    
?>