<!-- haz un html para el cliente, que permita ver su cuenta -->

<!DOCTYPE html>
<html>
<head>
    <title>Cliente</title>
</head>
<body>
    <h1>Cliente</h1>
    <p>Nombre: <?php echo $cliente['nombre']; ?></p>
    <p>Apellido: <?php echo $cliente['apellido']; ?></p>
    <p>Correo: <?php echo $cliente['correo']; ?></p>
    <p>Departamento: <?php echo $cliente['departamento']; ?></p>
</body>
</html>

