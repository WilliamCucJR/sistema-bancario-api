--SISTEMA-BANCARIO-API---
-- Creacion de las tablas
CREATE TABLE Tipo_Cuenta (
    ID NUMBER PRIMARY KEY,
    Tipo_de_cuenta VARCHAR2(50) NOT NULL,
    Fecha_de_creacion DATE NOT NULL
);

CREATE TABLE Moneda (
    ID NUMBER PRIMARY KEY,
    Tipo_moneda VARCHAR2(20) NOT NULL,
    Tasa_de_cambio NUMBER(10, 4) NOT NULL
);

CREATE TABLE Departamento (
    ID NUMBER PRIMARY KEY,
    Nombre_del_departamento VARCHAR2(50) NOT NULL
);

CREATE TABLE Municipio (
    ID NUMBER PRIMARY KEY,
    Nombre_del_Municipio VARCHAR2(50) NOT NULL,
    ID_Departamento NUMBER NOT NULL,
    CONSTRAINT fk_departamento FOREIGN KEY (ID_Departamento) REFERENCES Departamento(ID)
);

CREATE TABLE Banco (
    ID_Banco NUMBER PRIMARY KEY,
    Nombre_Banco VARCHAR2(100) NOT NULL,
    fecha_de_creacion DATE NOT NULL,
    ID_usuario NUMBER NOT NULL
);

CREATE TABLE Cuenta_Bancaria (
    ID_Cuenta NUMBER(8) PRIMARY KEY,
    Banco_ID NUMBER NOT NULL,
    No_de_cuenta VARCHAR2(20) NOT NULL,
    Tipo_de_cuenta_ID NUMBER NOT NULL,
    Nombre_cuantahabiente VARCHAR2(100) NOT NULL,
    DPI VARCHAR2(15) NOT NULL,
    NIT VARCHAR2(15) NOT NULL,
    Telefono VARCHAR2(15) NOT NULL,
    Correo VARCHAR2(50) NOT NULL,
    Direccion VARCHAR2(200) NOT NULL,
    Zona VARCHAR2(50) NOT NULL,
    Departamento_ID NUMBER NOT NULL,
    Municipio_ID NUMBER NOT NULL,
    Moneda_ID NUMBER NOT NULL,
    Saldo NUMBER(10, 2) NOT NULL,
    CONSTRAINT fk_Banco_ID FOREIGN KEY (Banco_ID) REFERENCES Banco(ID_Banco),
    CONSTRAINT fk_Tipo_de_cuenta_ID FOREIGN KEY (Tipo_de_cuenta_ID) REFERENCES Tipo_Cuenta(ID),
    CONSTRAINT fk_Departamento_ID FOREIGN KEY (Departamento_ID) REFERENCES Departamento(ID),
    CONSTRAINT fk_Municipio_ID FOREIGN KEY (Municipio_ID) REFERENCES Municipio(ID),
    CONSTRAINT fk_Moneda_ID FOREIGN KEY (Moneda_ID) REFERENCES Moneda(ID)
);

CREATE TABLE Tipo_Documento (
    ID NUMBER PRIMARY KEY,
    Nombre_Documento VARCHAR2(50),
    Descripcion VARCHAR2(100),
    Operacion NUMBER(1) NOT NULL
);

CREATE TABLE Movimientos (
    ID_Movimiento NUMBER PRIMARY KEY,
    ID_Cuenta NUMBER NOT NULL,
    ID_Documento NUMBER,
    Descripcion VARCHAR2(100),
    Fecha DATE,
    No_Documento VARCHAR2(50),
    Tipo_Documento_ID NUMBER,
    Monto NUMBER(10, 2) NOT NULL,
    Documento_Contable VARCHAR2(50),
    CONSTRAINT fk_ID_Cuenta FOREIGN KEY (ID_Cuenta) REFERENCES Cuenta_Bancaria(ID_Cuenta),
    CONSTRAINT fk_ID_Documento FOREIGN KEY (ID_Documento) REFERENCES Tipo_Documento(ID)
);

-- Crear secuencias para las tablas que necesitan llaves primarias auto incrementales
CREATE SEQUENCE seq_tipo_cuenta START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_moneda START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_departamento START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_municipio START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_banco START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_cuenta_bancaria START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_tipo_documento START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE seq_movimientos START WITH 1 INCREMENT BY 1;

-- Crear los disparadores (triggers) para asignar automáticamente los valores de las llaves primarias
CREATE OR REPLACE TRIGGER trg_tipo_cuenta
BEFORE INSERT ON Tipo_Cuenta
FOR EACH ROW
BEGIN
    SELECT seq_tipo_cuenta.NEXTVAL
    INTO :NEW.ID
    FROM dual;
END;
/

CREATE OR REPLACE TRIGGER trg_moneda
BEFORE INSERT ON Moneda
FOR EACH ROW
BEGIN
    SELECT seq_moneda.NEXTVAL
    INTO :NEW.ID
    FROM dual;
END;
/

CREATE OR REPLACE TRIGGER trg_departamento
BEFORE INSERT ON Departamento
FOR EACH ROW
BEGIN
    SELECT seq_departamento.NEXTVAL
    INTO :NEW.ID
    FROM dual;
END;
/

CREATE OR REPLACE TRIGGER trg_municipio
BEFORE INSERT ON Municipio
FOR EACH ROW
BEGIN
    SELECT seq_municipio.NEXTVAL
    INTO :NEW.ID
    FROM dual;
END;
/

CREATE OR REPLACE TRIGGER trg_banco
BEFORE INSERT ON Banco
FOR EACH ROW
BEGIN
    SELECT seq_banco.NEXTVAL
    INTO :NEW.ID_Banco
    FROM dual;
END;
/

CREATE OR REPLACE TRIGGER trg_cuenta_bancaria
BEFORE INSERT ON Cuenta_Bancaria
FOR EACH ROW
BEGIN
    SELECT seq_cuenta_bancaria.NEXTVAL
    INTO :NEW.ID_Cuenta
    FROM dual;
END;
/

CREATE OR REPLACE TRIGGER trg_tipo_documento
BEFORE INSERT ON Tipo_Documento
FOR EACH ROW
BEGIN
    SELECT seq_tipo_documento.NEXTVAL
    INTO :NEW.ID
    FROM dual;
END;
/

CREATE OR REPLACE TRIGGER trg_movimientos
BEFORE INSERT ON Movimientos
FOR EACH ROW
BEGIN
    SELECT seq_movimientos.NEXTVAL
    INTO :NEW.ID_Movimiento
    FROM dual;
END;
/