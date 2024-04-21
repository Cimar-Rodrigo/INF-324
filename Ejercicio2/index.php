<?php include 'header.php';?>

<?php include '../database/conexion.php';?>


<div class = 'container'>
    
    <h2>El usuario tiene una cuenta?</h2>
    
    <form method="post">
        <select name="tieneCuenta">
            <option value="seleccione">Seleccione una opción</option>
            <option value="si">Si</option>
            <option value="no">No</option>
        </select>
    

        <button>Confirmar</button>
    </form>


    <?php
        $respuesta = isset($_POST['tieneCuenta']) ? $_POST['tieneCuenta'] : '';

        
        if($respuesta == 'si'){
            include 'formulario1.php';
            include 'formulario3.php';
            include 'formulario4.php';
        }
        if($respuesta == 'no'){
            include 'formulario2.php';
        }

    ?>



</div>

<?php include 'footer.php';?>