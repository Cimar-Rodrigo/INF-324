<!--mostrar los datos-->
<!DOCTYPE html>
<html>
<head>
    <title>Director</title>
</head>
<body>
    <h1>Director</h1>
    <table>
        <tr>
            <th>Nombre</th>
            <th>Apellido </th>
            <th>correo</th>
        </tr>
        <tr>
            <td><?php echo $datos['nombre']; ?></td>
            <td><?php echo $datos ['apellido']; ?></td>
            <td><?php echo $datos ['correo']; ?></td>

        </tr>

        <!--mostrar la tabla de departamentos -->

        <tr>
            <th>Potosi</th>
            <th>La Paz</th>
            <th>Cochabamba</th>
            <th>Oruro</th>
            <th>Beni</th>
            <th>Tarija</th>
            <th>Chuquisaca</th>
            <th>Santa Cruz</th>
            <th>Pando</th>
        </tr>
        <tr>
            <td><?php echo $tabla['Potosi']; ?></td>
            <td><?php echo $tabla['La_Paz']; ?></td>
            <td><?php echo $tabla['Cochabamba']; ?></td>
            <td><?php echo $tabla['Oruro']; ?></td>
            <td><?php echo $tabla['Beni']; ?></td>
            <td><?php echo $tabla['Tarija']; ?></td>
            <td><?php echo $tabla['Chuquisaca']; ?></td>
            <td><?php echo $tabla['Santa_Cruz']; ?></td>
            <td><?php echo $tabla['Pando']; ?></td>
        </tr>
        
    </table>

</body>
</html>