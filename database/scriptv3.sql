CREATE DATABASE `bdEjer4`;

USE `bdEjer4`;

CREATE TABLE persona(
    carnet varchar(50) PRIMARY KEY,
    nombre varchar(50),
    apellido varchar(50),
    departamento varchar(50),
    correo varchar(50),
    tipo varchar(50)
);



INSERT INTO persona(carnet, nombre, apellido, departamento, correo, tipo) VALUES('123456', 'Juan', 'Perez', 'La Paz', 'juan@gmail.com', 'cliente');
INSERT INTO persona(carnet, nombre, apellido, departamento, correo, tipo) VALUES('123457', 'Pedro', 'Mamani', 'Cochabamba', 'pedro@gmail.com', 'cliente');
INSERT INTO persona(carnet, nombre, apellido, departamento, correo, tipo) VALUES('123458', 'Maria', 'Gomez', 'Santa Cruz', 'maria@gmail.com', 'cliente');
INSERT INTO persona(carnet, nombre, apellido, departamento, correo, tipo) VALUES('123459', 'Jose', 'Lopez', 'Oruro', 'jose@gmail.com', 'cliente');
INSERT INTO persona(carnet, nombre, apellido, departamento, correo, tipo) VALUES('123460', 'Carlos', 'Quispe', 'Potosi', 'carlos@gmail.com', 'cliente');
INSERT INTO persona(carnet, nombre, apellido, departamento, correo, tipo) VALUES('123461', 'Marcelo', 'Perez', 'La Paz', 'marcelo@gmail.com', 'director_bancario');



INSERT INTO cuenta(carnet, tipo, monto, estado) VALUES('123456', 'ahorro', 1000, 1);
INSERT INTO cuenta(carnet, tipo, monto, estado) VALUES('123457', 'corriente', 2000, 1);
INSERT INTO cuenta(carnet, tipo, monto, estado) VALUES('123458', 'ahorro', 3000, 1);
INSERT INTO cuenta(carnet, tipo, monto, estado) VALUES('123459', 'corriente', 4000, 1);
INSERT INTO cuenta(carnet, tipo, monto, estado) VALUES('123460', 'cheques', 5000, 1);




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