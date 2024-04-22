<!-- aqui mostraremos los datos de la tabla cuenta -->

<!DOCTYPE html>
<html>
<head>
    <title>Mostrar Datos</title>
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