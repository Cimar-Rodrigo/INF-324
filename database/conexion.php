<?php
// Datos de conexión a la base de datos
$host = "localhost"; // Cambia esto si tu base de datos está en un servidor diferente
$usuario = "root";
$contrasena = "";
$base_datos = "bd-324";

$conexion = new mysqli($host, $usuario, $contrasena, $base_datos);

if($conexion->connect_error){
    die("Error en la conexión: " . $conexion->connect_error);
}

?>