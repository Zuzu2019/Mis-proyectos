<?php
    include_once __DIR__.'/database.php';

    $data = array();
    $jsondef=array();

    // SE REALIZA LA QUERY DE BÚSQUEDA Y AL MISMO TIEMPO SE VALIDA SI HUBO RESULTADOS
    if ( $result = $conexion->query("SELECT * FROM pelicula WHERE eliminado = 0") ) {
        // SE OBTIENEN LOS RESULTADOS
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
    } else {
        die('Query Error: '.mysqli_error($conexion));
    }
    //
    // SE HACE LA CONVERSIÓN DE ARRAY A JSON
    $jsonstr=json_encode($data, JSON_PRETTY_PRINT);
    
    
    $prueba=json_decode($jsonstr, true);
    foreach($prueba as $value){
            
        
        $idregion=$value['idregion'];
        $idgenero=$value['idgenero'];
        $idclasificacion=$value['idclasificacion'];
        $treg="";
        $tgen="";
        $tclas="";
        $sql1="SELECT * FROM region WHERE id={$idregion} AND eliminado = 0";
        $sql2="SELECT * FROM genero WHERE id={$idgenero} AND eliminado = 0";
        $sql3="SELECT * FROM clasificacion WHERE id={$idclasificacion} AND eliminado = 0";
        if($result1=$conexion->query($sql1)){
            $row=mysqli_fetch_array($result1);
            $treg=$row['descripcion'];
            $result1->free();
        }
        if($result2=$conexion->query($sql2)){
            $row=mysqli_fetch_array($result2);
            $tgen=$row['nombre'];
            $result2->free();
        }
        if($result3=$conexion->query($sql3)){
            $row=mysqli_fetch_array($result3);
            $tclas=$row['clave'];
            $result3->free();
        }
        $value['idregion']=$treg;
        $value['idgenero']=$tgen;
        $value['idclasificacion']=$tclas;
        //$jsondef+=$value;
        array_push($jsondef, $value);
    }
    $conexion->close();
    $jsonstrv=json_encode($jsondef, JSON_PRETTY_PRINT);
    echo $jsonstrv;
?>