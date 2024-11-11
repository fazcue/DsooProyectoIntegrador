DROP DATABASE IF EXISTS clubdeportivo10;
CREATE DATABASE clubdeportivo10;
USE clubdeportivo10;

# CREAR TABLAS
CREATE TABLE IF NOT EXISTS rol(
	id INT UNIQUE,
	nombre VARCHAR(30) UNIQUE,
	CONSTRAINT PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS usuario(
	id INT AUTO_INCREMENT,
	usuario VARCHAR(20) NOT NULL,
	clave VARCHAR(15) NOT NULL,
	activo BOOLEAN DEFAULT TRUE,
	id_rol INT NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY(id),
	CONSTRAINT fk_usuario_rol_id FOREIGN KEY(id_rol) REFERENCES rol(id)
);

CREATE TABLE IF NOT EXISTS cliente(
	id INT AUTO_INCREMENT,
	nombre VARCHAR(40) NOT NULL,
	apellido VARCHAR(40) NOT NULL,
	dni VARCHAR(10) UNIQUE NOT NULL,
	fecha_vencimiento_cuota DATE NOT NULL,
	CONSTRAINT pk_cliente PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS socio(
	id INT AUTO_INCREMENT,
	nro_carnet INT UNIQUE NOT NULL,
	id_cliente INT NOT NULL,
	CONSTRAINT pk_socio PRIMARY KEY(id),
	CONSTRAINT fk_socio_cliente_id FOREIGN KEY(id_cliente) REFERENCES cliente(id)
);

CREATE TABLE IF NOT EXISTS noSocio(
	id INT AUTO_INCREMENT,
	id_cliente INT NOT NULL,
	CONSTRAINT pk_noSocio PRIMARY KEY(id),
	CONSTRAINT fk_noSocio_cliente_id FOREIGN KEY(id_cliente) REFERENCES cliente(id)
);

# INSERTAR DATOS LOGIN ADMIN
INSERT INTO rol
VALUES (10,'Administrador');

INSERT INTO usuario (usuario, clave, id_rol)
VALUES ('admin', 'admin', 10);

# PROCEDURES
DELIMITER $$
CREATE PROCEDURE Login(usuario VARCHAR(20), clave VARCHAR(15))
BEGIN
  SELECT u.id_rol FROM usuario u
  WHERE CAST(u.usuario AS BINARY) = usuario
  AND CAST(u.clave AS BINARY) = clave
  AND u.id_rol = 10
  AND activo = 1;
END 
$$

CREATE PROCEDURE AltaCliente(tipo ENUM('socio', 'no socio'), nombre VARCHAR(40), apellido VARCHAR(40), dni VARCHAR(10), fecha_vencimiento_cuota DATE, OUT respuesta INT)
BEGIN
	# Variables
    DECLARE dniCliente VARCHAR(10) DEFAULT NULL;
    DECLARE idCliente INT;
    
    SET respuesta = 0;
    
    # Buscar dni del cliente
    SET dniCliente = (
		SELECT c.dni FROM cliente c
        WHERE c.dni = dni
	);
    
    # Si el dni no existe, insertar y cambiar valor de respuesta
	IF dniCliente IS NULL THEN
		# Datos cliente
		INSERT INTO cliente (nombre, apellido, dni, fecha_vencimiento_cuota)
        VALUES (nombre, apellido, dni, fecha_vencimiento_cuota);
        
        # id del cliente recién registrado
        SET idCliente = LAST_INSERT_ID();
        
        # Datos socio
        IF tipo = 'socio' THEN
			# por el momento, el nro_carnet es igual al idCliente
			INSERT INTO socio (nro_carnet, id_cliente)
			VALUES (idCLiente, idCliente);
        END IF;
        
        # Datos no socio
        IF tipo = 'no socio' THEN
			INSERT INTO noSocio (id_cliente)
			VALUES (idCliente);
        END IF;
        
        # Actualizo respuesta
        SET respuesta = 1;
	END IF;
END
$$
DELIMITER ;