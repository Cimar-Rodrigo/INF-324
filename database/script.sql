CREATE TABLE persona(
    carnet PRIMARY KEY AUTO_INCREMENT,
    nombre varchar(50),
    apellido varchar(50),
    departamento varchar(50)
);

CREATE TABLE usuario(
    id_usuario PRIMARY KEY AUTO_INCREMENT,
    carnet int, 
    usuario varchar(50),
    contra varchar(50),
    FOREIGN KEY (carnet) REFERENCES persona(carnet)
);


CREATE TABLE cuenta(
    id_cuenta int PRIMARY KEY AUTO_INCREMENT,
    id_usuario int,
    tipo varchar(50),
    monto int,
    estado int
    FOREIGN KEY(id_usuario) REFERENCES usuario(id_usuario)
);


CREATE TABLE transaccion(
    id_transaccion PRIMARY KEY AUTO_INCREMENT,
    id_cuenta int,
    tipo_transaccion varchar(50),
    monto_transaccion int,
    fecha_transaccion DATE,
    FOREIGN KEY(id_cuenta) REFERENCES cuenta(id_cuenta)
);