<?php 

// tienes que hacer el login para buscar que tipo de usuario es con el correo

// si es admin lo mandas a la vista de admin
// si es usuario lo mandas a la vista de usuario
// si no es ninguno de los dos lo mandas a la vista de login
// haz el html del login

?>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Login</title>

    <style>
        form {
            display: flex;
            flex-direction: column;
            width: 200px;
            margin: 0 auto;
            margin-top: 100px;
        }

        input {
            margin-bottom: 10px;
            padding: 5px;
        }

        button {
            padding: 5px;
        }
    </style>
</head>
<body>
    <form action="sesion" method="post">
        <input type="email" name="correo" placeholder="Email">
        <button type="submit">Login</button>
    </form>
</body>
</html>


