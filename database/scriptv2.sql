CREATE DATABASE `bd-324v2`;

USE `bd-324v2`;

CREATE TABLE persona(
    carnet varchar(50) PRIMARY KEY,
    nombre varchar(50),
    apellido varchar(50),
    departamento varchar(50)
);

CREATE TABLE usuario(
    id_usuario int PRIMARY KEY AUTO_INCREMENT,
    carnet varchar(50), 
    usuario varchar(50),
    contra varchar(50),
    FOREIGN KEY (carnet) REFERENCES persona(carnet)
);


CREATE TABLE cuenta(
    id_cuenta int PRIMARY KEY AUTO_INCREMENT,
    carnet varchar(50),
    tipo varchar(50),
    monto int,
    estado int,
    FOREIGN KEY(carnet) REFERENCES persona(carnet)
);


CREATE TABLE transaccion(
    id_transaccion int PRIMARY KEY AUTO_INCREMENT,
    id_cuenta int,
    tipo_transaccion varchar(50),
    monto_transaccion int,
    fecha_transaccion DATE,
    FOREIGN KEY(id_cuenta) REFERENCES cuenta(id_cuenta)
);