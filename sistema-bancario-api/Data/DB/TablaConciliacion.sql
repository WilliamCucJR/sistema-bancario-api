
CREATE TABLE Conciliacion (
    ID NUMBER PRIMARY KEY,
    Cuenta VARCHAR2(10),
    Mes NUMBER(2),
    Anio NUMBER(4),
    Documento NUMBER(10),
    Descripcion VARCHAR2(30),
    Fecha DATE,
    No_Documento NUMBER(10),
    Monto NUMBER(12, 2), 
    Correlativo_Contable NUMBER(12),
    Estado NUMBER
);

-- Crear la secuencia
CREATE SEQUENCE seq_conciliacion
START WITH 1
INCREMENT BY 1;

-- Crear el disparador (trigger) para asignar automáticamente los valores de las llaves primarias
CREATE OR REPLACE TRIGGER trg_conciliacion
BEFORE INSERT ON Conciliacion
FOR EACH ROW
BEGIN
    SELECT seq_conciliacion.NEXTVAL
    INTO :NEW.ID
    FROM dual;
END;
/
