
<div class="container">
        <h1>Modificar datos</h1>
        
        <form action="procesar.php" method="post">
        <input type="hidden" name="accion" value="modificar">
        <div class="form-group">
                <label for="carnet">Ingrese carnet de persona a modificar</label>
                <input type="text" id="carnet" name="carnet" required>
            </div>
            <div class="form-group">
                <label for="nombre">Nombre</label>
                <input type="text" id="nombre" name="nombre" required>
            </div>
            <div class="form-group">
                <label for="apellido">Apellido</label>
                <input type="text" id="apellido" name="apellido" required>
            </div>
            <div class="form-group">
                <label for="departamento">Departamento</label>
                <select id="departamento" name="departamento">
                    <option value="beni">Beni</option>
                    <option value="chuquisaca">Chuquisaca</option>
                    <option value="cochabamba">Cochabamba</option>
                    <option value="la_paz">La Paz</option>
                    <option value="oruro">Oruro</option>
                    <option value="pando">Pando</option>
                    <option value="potosi">Potosí</option>
                    <option value="santa_cruz">Santa Cruz</option>
                    <option value="tarija">Tarija</option>
                </select>
            </div>
            <div class="form-group">
                <label for="usuario">Usuario</label>
                <input type="text" id="usuario" name="usuario" required>
            </div>
            <div class="form-group">
                <label for="contrasena">Contraseña</label>
                <input type="password" id="contrasena" name="contrasena" required>
            </div>
            <button type="submit">Enviar</button>
        </form>
</div>