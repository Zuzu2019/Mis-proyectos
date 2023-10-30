
<?php
include_once __DIR__.'/database.php';
if( isset($_POST['id']) ) {
    $id = $_POST['id'];
    // SE REALIZA LA QUERY DE BÚSQUEDA Y AL MISMO TIEMPO SE VALIDA SI HUBO RESULTADOS
    $sql = "UPDATE perfil SET eliminado=1 WHERE id = {$id}";
    if ( $conexion->query($sql) ) {
        echo('Se elimino perfil');
    } else {
        echo "Error: " . $sql . "<br>" . mysqli_error($conexion);
    }
    $conexion->close();
} 
?>