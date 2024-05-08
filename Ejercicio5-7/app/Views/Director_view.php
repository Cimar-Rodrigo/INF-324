<!DOCTYPE html>
<html>
<head>
    <title>Director</title>
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
    </style>
</head>
<body>
    <h1>Director</h1>
    <table>
        <tr>
            <th>Nombre</th>
            <th>Apellido</th>
            <th>Correo</th>
        </tr>
        <tr>
            <td><?php echo $datos['nombre']; ?></td>
            <td><?php echo $datos['apellido']; ?></td>
            <td><?php echo $datos['correo']; ?></td>
        </tr>
    </table>

    <!-- Mostrar la tabla de departamentos -->
    <h2>Tabla de Departamentos</h2>
    <table>
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
