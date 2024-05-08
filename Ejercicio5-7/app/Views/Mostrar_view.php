<!DOCTYPE html>
<html>
<head>
    <title>Mostrar Datos</title>
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
        table {
            width: 80%;
            margin: 20px auto;
            border-collapse: collapse;
            background-color: #fff;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.1);
        }
        th, td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
        th {
            background-color: #f2f2f2;
        }
        tr:hover {
            background-color: #f2f2f2;
        }
        form {
            text-align: center;
            margin-top: 20px;
        }
        label {
            display: block;
            margin-bottom: 5px;
        }
        input[type="text"], input[type="submit"] {
            padding: 8px;
            margin-bottom: 10px;
            border: 1px solid #ddd;
            border-radius: 4px;
        }
        input[type="submit"] {
            background-color: #4caf50;
            color: white;
            border: none;
            cursor: pointer;
        }
        input[type="submit"]:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <h1>Mostrar Datos</h1>
    <table border="1">
        <tr>
            <th>id_cuenta</th>
            <th>carnet</th>
            <th>monto</th>
            <th>tipo</th>
            <th>estado</th>
        </tr>
        <?php foreach ($cuenta as $row) : ?>
        <tr>
            <td><?php echo $row['id_cuenta']; ?></td>
            <td><?php echo $row['carnet']; ?></td>
            <td><?php echo $row['monto']; ?></td>
            <td><?php echo $row['tipo']; ?></td>
            <td><?php echo $row['estado']; ?></td>
        </tr>
        <?php endforeach; ?>
    </table>

    <!-- agrega un campo para poder eliminar un dato ingresando el id del dato -->
    <form action="eliminar" method="post">
        <label for="id_cuenta">Ingrese el id de la cuenta a eliminar:</label><br>
        <input type="text" id="id_cuenta" name="id_cuenta"><br>
        <input type="submit" value="Eliminar">
    </form>

    <!-- agrega un boton para ir al login -->
    <form action="login" method="post">
        <input type="submit" value="Login">
    </form>
    

</body>
</html>
