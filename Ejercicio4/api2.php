<?php
//    $server = "localhost";
//    $user = "root";
//    $password = "";
//    $database = "bdEjer4";
//    $conexion = mysqli_connect($server, $user, $password, $database);
//
//    $query = "SELECT * FROM cuenta";
//
//    $resultado = mysqli_query($conexion, $query);
//    $datos = array();
//
//    while($fila = mysqli_fetch_assoc($resultado)){
//        $datos[] = $fila;
//    }
//
//    mysqli_close($conexion);
//
//    echo json_encode($datos, JSON_UNESCAPED_UNICODE);

    ?> 



<!-- haz un form basico con nombre y edad en html -->

<form action="http://localhost:8080/EjerJAVA/MyServlet" method="POST">
    <label for="nombre">Nombre:</label>
    <input type="text" id="nombre" name="nombre"><br><br>
    <label for="edad">Edad:</label>
    <input type="text" id="edad" name="edad"><br><br>
    <input type="submit" value="Submit">
</form>
