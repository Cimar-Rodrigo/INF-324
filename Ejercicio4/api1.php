<?php
    $server = "localhost";
    $user = "root";
    $password = "";
    $database = "bdEjer4";
    $conexion = mysqli_connect($server, $user, $password, $database);

    $query = "SELECT * FROM persona";

    $resultado = mysqli_query($conexion, $query);
    $datos = array();

    while($fila = mysqli_fetch_assoc($resultado)){
        $datos[] = $fila;
    }

    mysqli_close($conexion);

    echo json_encode($datos, JSON_UNESCAPED_UNICODE);

    ?> 