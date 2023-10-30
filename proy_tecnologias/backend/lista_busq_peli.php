<?php
    include_once __DIR__.'/database.php';
    $search=$_POST['search'];


    $data = array();

    

    if( isset($search) ) {
        $sql = "SELECT p.id, p.titulo, p.duracion, r.descripcion, g.nombre, c.clave, p.rutaportada FROM pelicula p, genero g, clasificacion c, region r WHERE g.id=p.idgenero AND c.id=p.idclasificacion AND r.id=p.idregion AND p.eliminado = 0 AND (p.id='{$search}' OR p.titulo LIKE '%{$search}%' OR g.nombre LIKE '%{$search}%' OR r.descripcion LIKE '%{$search}%' OR c.clave LIKE '%{$search}%')";
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