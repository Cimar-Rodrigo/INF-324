<div class="container">
        <h1>Eliminiar usuario</h1>
        
        <form action="procesar.php" method="post">
        <input type="hidden" name="accion" value="eliminar">
        <div class="form-group">
                <label for="carnet">Ingrese carnet de persona a eliminar</label>
                <input type="text" id="carnet" name="carnet" required>
            </div>
            
            <button type="submit">Enviar</button>
        </form>
</div>