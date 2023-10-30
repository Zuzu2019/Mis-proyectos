<?php
    include_once __DIR__.'/database.php';
    $search=$_POST['search'];


    $data = array();

    

    if( isset($search) ) {
        $sql = "SELECT s.id, s.titulo, s.numtemporadas, s.totalcapitulos, r.descripcion, g.nombre, c.clave, s.rutaportada FROM serie s, genero g, clasificacion c, region r WHERE g.id=s.idgenero AND c.id=s.idclasificacion AND r.id=s.idregion AND s.eliminado = 0 AND (s.id='{$search}' OR s.titulo LIKE '%{$search}%' OR g.nombre LIKE '%{$search}%' OR r.descripcion LIKE '%{$search}%' OR c.clave LIKE '%{$search}%')";
        if ( $result = $conexion->query($sql) ) {
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
		$conexion->close();
    } 
    echo json_encode($data, JSON_PRETTY_PRINT);
?>