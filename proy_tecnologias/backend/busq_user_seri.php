<?php
    include_once __DIR__.'/database.php';
    $pelic = file_get_contents('php://input');
    $data = array();

    //campos
    if(!empty($pelic)){
        
        $peli = json_decode($pelic);

        $userid=$peli->id;
        $busq=$peli->search;
        $cuentaid="";
        $perfilnombre="";
        $perfiledad="";
        $perfilimg="";

        $cuentapais="";
        $nivrest=2;
        $idregion="";

        $quser="SELECT * FROM perfil WHERE id={$userid}";
        

        if($sqluser=$conexion->query($quser)){
            $row=mysqli_fetch_array($sqluser);
            $cuentaid=$row['idcuenta'];
            $perfilnombre=$row['usuario'];
            $perfiledad=$row['edad'];
            $perfilimg=$row['rutaimagen'];
            $sqluser->free();
        }
        else{
            echo $quser;
            die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
        }
        $qcuenta="SELECT * FROM cuenta WHERE id={$cuentaid}";
        if($res2=$conexion->query($qcuenta)){
            
            $row=mysqli_fetch_array($res2);

            $cuentapais=$row['pais'];
            $res2->free();
        }
        else{
            echo $qcuenta;
            die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
        }
        $qregion="SELECT * FROM region WHERE descripcion LIKE '%{$cuentapais}%' LIMIT 1";
        if($resc=$conexion->query($qcuenta)){
            
            $row=mysqli_fetch_array($resc);

            $idregion=$row['id'];
            $resc->free();
        }
        else{
            echo $qregion;
            die("Consulta fallida!. Motivo: ".mysqli_error($conexion));
        }

        switch ($perfiledad) {
            case ($perfiledad<12 && $perfiledad>=1):
                $nivrest=2;
                break;
            case ($perfiledad>=12 && $perfiledad<15):
                $nivrest=3;
                break;
            case ($perfiledad>=15 && $perfiledad<18):
                $nivrest=4;
                break;
            case ($perfiledad>=18 && $perfiledad<=100):
                $nivrest=6;
                break;
            default:
                $nivrest=2;
                break;
        }

        if ($userid==1) {
            $sql="SELECT s.titulo, s.numtemporadas, s.totalcapitulos, s.rutaportada, g.nombre, c.clave FROM serie s, genero g, clasificacion c WHERE s.idclasificacion <= {$nivrest} AND s.eliminado=0 AND g.id=s.idgenero AND c.id=s.idclasificacion AND (s.titulo LIKE '%{$busq}%' OR g.nombre LIKE '%{$busq}%')";
        }
        else{
            $sql="SELECT s.titulo, s.numtemporadas, s.totalcapitulos, s.rutaportada, g.nombre, c.clave FROM serie s, genero g, clasificacion c WHERE s.idregion={$idregion} AND s.idclasificacion <= {$nivrest} AND s.eliminado=0 AND g.id=s.idgenero AND c.id=s.idclasificacion AND (s.titulo LIKE '%{$busq}%' OR g.nombre LIKE '%{$busq}%')";
        }

        
        
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
        echo json_encode($data, JSON_PRETTY_PRINT);

    }
    else{
        
    }

    
?>