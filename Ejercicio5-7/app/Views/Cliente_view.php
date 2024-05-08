<!DOCTYPE html>
<html>
<head>
    <title>Cliente</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        h1 {
            text-align: center;
            margin-top: 20px;
        }
        p {
            margin: 10px;
            padding: 5px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
    </style>
</head>
<body>
    <h1>Cliente</h1>
    <p>Nombre: <?php echo $cliente['nombre']; ?></p>
    <p>Apellido: <?php echo $cliente['apellido']; ?></p>
    <p>Correo: <?php echo $cliente['correo']; ?></p>
    <p>Departamento: <?php echo $cliente['departamento']; ?></p>
</body>
</html>
