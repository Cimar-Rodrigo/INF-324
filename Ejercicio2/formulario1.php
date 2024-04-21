
<div class="container">
        <h1>Agregar cuenta</h1>
        <form action="procesar.php" method="post">
            <input type="hidden" name="accion" value="agregar">
            <div class="form-group">
                <label for="carnet">Carnet de identidad</label>
                <input type="text" id="carnet" name="carnet" required>
            </div>
            <div class="form-group">
                <label for="usuario">Usuario</label>
                <input type="text" id="usuario" name="usuario" required>
            </div>
            <div class="form-group">
                <label for="contrasena">Contraseña</label>
                <input type="password" id="contrasena" name="contrasena" required>
            </div>
            <div class="form-group">
                <label for="tipo_cuenta">Tipo de Cuenta</label>
                <select id="tipo_cuenta" name="tipo_cuenta">
                    <option value="corriente">Cuenta Corriente</option>
                    <option value="ahorro">Cuenta de Ahorro</option>
                    <option value="inversion">Cuenta de Inversión</option>
                </select>
            </div>
            <button type="submit">Enviar</button>
        </form>
</div>