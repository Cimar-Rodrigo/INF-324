

<?php 
    include '../database/conexion.php';

    function sacarId($carnet, $conexion){
        //echo $carnet;
        $query = "SELECT id_usuario FROM usuario WHERE carnet = '$carnet'";
        $id_usuario = mysqli_query($conexion, $query);
        //recorrer la respuesta id_usuario

        while($fila = mysqli_fetch_assoc($id_usuario)){
            $id = $fila['id_usuario'];
        }

        return $id;
    }

    $accion = isset($_POST['accion']) ? $_POST['accion'] : '';

    
    
    if($accion == 'agregarNueva'){
        
        
        $carnet = (int) $_POST['carnet'];
        $nombre = $_POST['nombre'];
        $apellido = $_POST['apellido'];
        $departamento = $_POST['departamento'];
        $tipo_cuenta = $_POST['tipo_cuenta'];
        $usuario = $_POST['usuario'];
        $contrasena = $_POST['contrasena'];
 

        $sql1 = "INSERT INTO persona (carnet, nombre, apellido, departamento) VALUES ('$carnet', '$nombre', '$apellido', '$departamento')";
        $sql3 = "INSERT INTO usuario (carnet, usuario, contra) VALUES ('$carnet', '$usuario', '$contrasena')";
        
        $resultado1 = mysqli_query($conexion, $sql1);
        $resultado2 = mysqli_query($conexion, $sql3);

        $id = sacarId($carnet, $conexion);

        $sql2 = "INSERT INTO cuenta (id_usuario, tipo, monto, estado) VALUES('$id', '$tipo_cuenta', 0, 1)";
        $resultado3 = mysqli_query($conexion, $sql2);
        if($resultado1 && $resultado2 && $resultado3){
            
            echo "Registro agregado";

        }else{
            echo "Error: " . $sql1 . "<br>" . $conexion->error;
        }
        
    }

    elseif($accion == 'modificar'){

        $carnet = $_POST['carnet'];
        $nombre = $_POST['nombre'];
        $apellido = $_POST['apellido'];
        $departamento = $_POST['departamento'];
        $usuario = $_POST['usuario'];
        $contrasena = $_POST['contrasena'];

        $sql1 = "UPDATE persona SET nombre = '$nombre', apellido = '$apellido', departamento = '$departamento' WHERE carnet = '$carnet'";
        $sql2 = "UPDATE usuario SET usuario = '$usuario', contra = '$contrasena' WHERE carnet = '$carnet'";

        $resultado1 = mysqli_query($conexion, $sql1);
        $resultado2 = mysqli_query($conexion, $sql2);
        if($resultado1 && $resultado2){
            echo "Registro modificado";
        }else{
            echo "Error: " . $sql . "<br>" . $conexion->error;
        }
    }

    elseif($accion == 'eliminar'){

        $carnet = (int) $_POST['carnet'];
        $sql1 = "DELETE FROM persona WHERE carnet = '$carnet'";
        
        
        $id = sacarId($carnet, $conexion);
        $sql3 = "DELETE FROM cuenta WHERE id_usuario = '$id'";
        $sql2 = "DELETE FROM usuario WHERE carnet = '$carnet'";
        

        $resultado1 = mysqli_query($conexion, $sql3);
        $resultado2 = mysqli_query($conexion, $sql2);
        $resultado3 = mysqli_query($conexion, $sql1);

        if($resultado1 && $resultado2 && $resultado3){
            echo "Registro eliminado";
        }else{
            echo "Error: " . $sql . "<br>" . $conexion->error;
        }
    }

    elseif($accion == 'agregar'){
        echo $accion;
        $carnet = (int) $_POST['carnet'];
        $tipo_cuenta = $_POST['tipo_cuenta'];
        $usuario = $_POST['usuario'];
        $contrasena = $_POST['contrasena'];

        
        $sql1 = "INSERT INTO usuario (carnet, usuario, contra) VALUES ('$carnet', '$usuario', '$contrasena')";
        $resultado1  = mysqli_query($conexion, $sql1);

        $id = sacarId($carnet, $conexion);

        $sql2 = "INSERT INTO cuenta (id_usuario, tipo, monto, estado) VALUES('$id', '$tipo_cuenta', 0, 1)";
        $resultado2  = mysqli_query($conexion, $sql2);

        if($resultado1 && $resultado2){
            echo "Cuenta agregada al usuario";
        }else{
            echo "Error: " . $sql . "<br>" . $conexion->error;
        }
    }

    
?>
