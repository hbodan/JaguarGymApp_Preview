-- Crear la base de datos
CREATE DATABASE IF NOT EXISTS jaguarGym;
USE jaguarGym;

-- Tabla Usuario
CREATE TABLE Usuario (
    idUsuario INT AUTO_INCREMENT PRIMARY KEY,
    nombreUsuario VARCHAR(255) NOT NULL,
    correoElectronico VARCHAR(100) NOT NULL UNIQUE,
    clave VARCHAR(100) NOT NULL
);

-- Tabla Facultad
CREATE TABLE Facultad (
    idFacultad INT AUTO_INCREMENT PRIMARY KEY,
    nombreFacultad VARCHAR(150) NOT NULL
);

-- Tabla Carrera
CREATE TABLE Carrera (
    idCarrera INT AUTO_INCREMENT PRIMARY KEY,
    nombreCarrera VARCHAR(150) NOT NULL,
    idFacultad INT NOT NULL,
    FOREIGN KEY (idFacultad) REFERENCES Facultad(idFacultad)
);


-- Tabla Miembro
CREATE TABLE Miembro (
    idMiembro INT AUTO_INCREMENT PRIMARY KEY,
    identificacion VARCHAR(14) DEFAULT NULL,
    cif VARCHAR(10) DEFAULT NULL,
    nombres VARCHAR(50) NOT NULL,
    apellidos VARCHAR(50) NOT NULL,
    fechaNacimiento DATE NOT NULL,
    genero BOOLEAN NOT NULL,
    idCarrera INT DEFAULT NULL,
    idFacultad INT DEFAULT NULL,
    fechaExp DATE NOT NULL,
    interno BOOLEAN NOT NULL, 
    colaborador BOOLEAN NOT NULL,
    cargo VARCHAR(50) DEFAULT NULL,
    FOREIGN KEY (idCarrera) REFERENCES Carrera(idCarrera),
    FOREIGN KEY (idFacultad) REFERENCES Facultad(idFacultad) 
);

-- Tabla Pago
CREATE TABLE Pago (
    idPago INT AUTO_INCREMENT PRIMARY KEY,
    idTransaccion VARCHAR(50) NOT NULL UNIQUE,
    fechaRealizacion DATE NOT NULL,
    descripcion VARCHAR(100) NOT NULL,
    monto DECIMAL(10, 2) NOT NULL,
    observacion VARCHAR(255) DEFAULT NULL,
    idUsuario INT NOT NULL,
    idMiembro INT NOT NULL,
    FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario),
    FOREIGN KEY (idMiembro) REFERENCES Miembro(idMiembro)
);

-- Tabla Entrada
CREATE TABLE Entrada (
    idEntrada INT AUTO_INCREMENT PRIMARY KEY,
    idMiembro INT NOT NULL,
    fecha DATE NOT NULL,
    hora TIME NOT NULL,
    FOREIGN KEY (idMiembro) REFERENCES Miembro(idMiembro)
);

-- Tabla CodigoVerificacion
CREATE TABLE CodigoVerificacion (
    idCodigo INT AUTO_INCREMENT PRIMARY KEY,
    codigo VARCHAR(20) NOT NULL UNIQUE,
    idMiembro INT NOT NULL,
    FOREIGN KEY (idMiembro) REFERENCES Miembro(idMiembro)
);

ALTER TABLE Miembro MODIFY COLUMN idFacultad INT NULL;
ALTER TABLE Miembro MODIFY COLUMN idCarrera INT NULL;

-- Inserts para Facultades
INSERT INTO Facultad (nombreFacultad) VALUES 
('Facultad de Ciencias Médicas'),
('Facultad de Odontología'),
('Facultad de Ciencias Jurídicas, Humanidades y Relaciones Internacionales'),
('Facultad de Marketing, Diseño y Ciencias de la Comunicación'),
('Facultad de Ciencias Administrativas y Económicas'),
('Facultad de Ingeniería y Arquitectura'),
('UAM College'),
('Language Institute'),
('Postgrados UAM');




-- Inserts para Carreras de la Facultad de Ciencias Médicas
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Medicina', 1),
('Psicología', 1);

-- Inserts para Carreras de la Facultad de Odontología
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Odontología', 2);

-- Inserts para Carreras de la Facultad de Ciencias Jurídicas, Humanidades y Relaciones Internacionales
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Derecho', 3),
('Diplomacia y Relaciones Internacionales', 3);

-- Inserts para Carreras de la Facultad de Marketing, Diseño y Ciencias de la Comunicación
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Comunicación y Relaciones Públicas', 4),
('Diseño y Comunicación Visual', 4);

-- Inserts para Carreras de la Facultad de Ciencias Administrativas y Económicas
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Administración de Empresas', 5),
('Marketing y Publicidad', 5),
('Economía Empresarial', 5),
('Contabilidad y Finanzas', 5),
('Negocios Internacionales', 5);

-- Inserts para Carreras de la Facultad de Ingeniería y Arquitectura
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Arquitectura', 6),
('Ingeniería Industrial', 6),
('Ingeniería en Sistemas de Información', 6),
('Ingeniería Civil', 6);

-- Inserts para Carreras de UAM College
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Desarrollo Internacional', 7),
('Finanzas Globales', 7),
('Marketing Estratégico', 7),
('Gestión Global', 7);

-- Inserts para Carreras del Language Institute
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Inglés para Jóvenes y Adultos', 8),
('Cursos especializados para ejecutivos', 8);

-- Inserts para Carreras de Postgrados UAM
INSERT INTO Carrera (nombreCarrera, idFacultad) VALUES 
('Diplomado', 9),
('Maestría', 9),
('Doctorado', 9);


INSERT INTO Miembro (identificacion, cif, nombres, apellidos, fechaNacimiento, genero, idCarrera, idFacultad, fechaExp, interno, colaborador, cargo) VALUES
('0011112220000A', '23034754', 'Carlos', 'Martínez', '2002-05-15', 1, 1, 1, '2024-12-01', 1, 0, 'Estudiante'), -- Interno (estudiante)
('0021112230001B', '22098432', 'María', 'Lopez', '1998-07-20', 0, 2, 1, '2024-12-02', 1, 1, 'Psicóloga'), -- Interno y colaborador (trabajadora)
('0031112240002C', '24015678', 'Ana', 'González', '2000-03-10', 0, 3, 2, '2024-12-03', 0, 0, 'Externo'), -- Externo
('0041112250003D', '21047392', 'Pedro', 'Ramírez', '1995-09-25', 1, 4, 3, '2024-12-04', 1, 1, 'Abogado'), -- Interno y colaborador (trabajador)
('0051112260004E', '23098476', 'Luisa', 'Morales', '1997-01-18', 0, 5, 4, '2024-12-05', 1, 0, 'Estudiante'), -- Interno (estudiante)
('0061112270005F', '24075839', 'Jorge', 'Hernández', '1999-12-30', 1, 6, 5, '2024-12-06', 0, 0, 'Externo'), -- Externo
('0071112280006G', '22034678', 'Sofía', 'Castro', '2001-04-05', 0, 7, 6, '2024-12-07', 1, 0, 'Estudiante'), -- Interno (estudiante)
('0081112290007H', '23012987', 'Andrés', 'Alvarado', '1996-06-22', 1, 8, 7, '2024-12-08', 1, 1, 'Profesor'); -- Interno y colaborador (trabajador)

INSERT INTO Miembro (identificacion, cif, nombres, apellidos, fechaNacimiento, genero, idCarrera, idFacultad, fechaExp, interno, colaborador, cargo) VALUES
('0112222330002K', '24034567', 'Ana María', 'Gómez Rivera', '2002-07-19', 0, 4, 3, '2025-01-12', 1, 0, 'Estudiante'), -- Interno (estudiante)
('0122222340003L', '23056789', 'Carlos Alberto', 'Morales Jiménez', '1996-03-14', 1, 5, 4, '2025-01-25', 0, 0, 'Externo'); -- Externo



INSERT INTO Entrada (idMiembro, fecha, hora)
VALUES
(1, '2024-12-01', '08:30:00'),
(1, '2024-12-01', '18:45:00'),
(2, '2024-12-02', '09:00:00'),
(2, '2024-12-02', '20:15:00'),
(5, '2024-12-03', '10:00:00'),
(5, '2024-12-03', '14:30:00'),
(7, '2024-12-04', '07:45:00'),
(7, '2024-12-04', '17:00:00'),
(1, '2024-12-05', '12:00:00'),
(2, '2024-12-06', '19:30:00'),
(5, '2024-12-07', '08:00:00'),
(7, '2024-12-08', '13:30:00'),
(1, '2024-12-09', '15:15:00'),
(5, '2024-12-10', '11:00:00'),
(2, '2024-12-11', '09:45:00');


-- Insertar registros en la tabla Pago
INSERT INTO Pago (idTransaccion, fechaRealizacion, descripcion, monto, observacion, idUsuario, idMiembro)
VALUES
('TXN001', '2024-12-01', 'Pago mensual de membresía', 150.00, 'Pago regular para el mes de diciembre', 1, 1),
('TXN002', '2024-12-02', 'Pago de inscripción', 200.00, 'Inscripción al gimnasio para nuevo miembro', 1, 1),
('TXN003', '2024-12-05', 'Pago mensual de membresía', 150.00, NULL, 1, 1),
('TXN004', '2024-12-10', 'Pago por servicio adicional', 50.00, 'Pago por clases adicionales', 1, 1),
('TXN005', '2024-12-12', 'Pago mensual de membresía', 150.00, 'Pago regular para el mes de diciembre', 1, 1);