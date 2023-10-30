<?php
    include_once __DIR__.'/database.php';
    $id=$_POST['id'];
    $sql="SELECT p.id, p.titulo, p.duracion, r.clave as rclave, g.nombre, c.clave as cclave, p.rutaportada FROM pelicula p, region r, genero g, clasificacion c WHERE p.id=$id AND r.id=p.idregion AND g.id=p.idgenero AND c.id=p.idclasificacion AND p.eliminado=0";
    if(!$result=$conexion->query($sql)){
        die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
    }
    $json=array();
    while($row=mysqli_fetch_array($result)){
        $json[]=array(
            'id'=>$row['id'],
            'titulo' => $row['titulo'],
            'duracion' => $row['duracion'],
            'idregion' => "Region ".$row['rclave'],
            'idgenero' => $row['nombre'],
            'idclasificacion' => $row['cclave'],
            'rutaportada' => $row['rutaportada']
        );
    }
    $jsonstring=json_encode($json[0], JSON_PRETTY_PRINT);
    echo $jsonstring;
?>