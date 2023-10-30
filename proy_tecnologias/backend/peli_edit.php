<?php
    include_once __DIR__.'/database.php';
    $pelic = file_get_contents('php://input');
    $data = array(
        'status'  => 'error',
        'message' => 'Ya existe un producto con ese nombre'
    );

    //campos
    if(!empty($pelic)){
        
        $peli = json_decode($pelic);

        $id=$peli->id;
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

        $sql="UPDATE pelicula SET titulo='{$titulo}', duracion='{$duracion}', rutaportada='{$rutaportada}', idregion={$idreg}, idgenero={$idgen}, idclasificacion={$idclas} WHERE id={$id}";
        
        /*
        $id=$_POST['id'];
        echo "aaaaaaa";
        $nombre=$_POST['nombre'];
        $marca=$_POST['marca'];
        $modelo=$_POST['modelo'];
        $precio=$_POST['precio'];
        $detalles=$_POST['detalles'];
        $unidades=$_POST['unidades'];
        $imagen=$_POST['imagen'];
*/
        
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