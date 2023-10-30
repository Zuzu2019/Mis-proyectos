<?php
    include_once __DIR__.'/database.php';
    $id=$_POST['id'];
    $sql="SELECT s.id, s.titulo, s.numtemporadas, s.totalcapitulos, r.clave as rclave, g.nombre, c.clave as cclave, s.rutaportada FROM serie s, region r, genero g, clasificacion c WHERE s.id=$id AND r.id=s.idregion AND g.id=s.idgenero AND c.id=s.idclasificacion AND s.eliminado=0";
    if(!$result=$conexion->query($sql)){
        die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
    }
    $json=array();
    while($row=mysqli_fetch_array($result)){
        $json[]=array(
            'id'=>$row['id'],
            'titulo' => $row['titulo'],
            'numtemporadas' => $row['numtemporadas'],
            'totalcapitulos' => $row['totalcapitulos'],
            'idregion' => "Region ".$row['rclave'],
            'idgenero' => $row['nombre'],
            'idclasificacion' => $row['cclave'],
            'rutaportada' => $row['rutaportada']
        );
    }
    $jsonstring=json_encode($json[0], JSON_PRETTY_PRINT);
    echo $jsonstring;
?>