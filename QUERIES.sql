--TABLAS
CREATE TABLE items(
cod_item INT PRIMARY KEY,
desc_item NVARCHAR(60),
precio DECIMAL (18,2),
fecha_vto DATE)

CREATE TABLE depositos(
nro_deposito INT PRIMARY KEY,
nombre_deposito NVARCHAR(60))

CREATE TABLE items_depositos(
cod_item INT FOREIGN KEY REFERENCES items(cod_item),
nro_deposito INT FOREIGN KEY REFERENCES depositos(nro_deposito),
cantidad INT
PRIMARY KEY(cod_item,nro_deposito))

CREATE TABLE usuarios(
usario NVARCHAR(10) PRIMARY KEY,
clave INT)

--STORE PROCEDURES

--ITEMS DEPOSITOS
CREATE PROCEDURE spu_cargar_items_deposito
@cod_item INT,
@nro_deposito INT,
@cantidad INT
AS
INSERT INTO items_depositos
VALUES(@cod_item, @nro_deposito, @cantidad);

CREATE PROCEDURE spu_update_items_depositos
@cod_item INT,
@nro_deposito INT,
@cantidad INT
AS
UPDATE items_depositos SET cantidad = @cantidad WHERE (cod_item = @cod_item AND nro_deposito = @nro_deposito)

CREATE PROCEDURE spu_eliminar_items_depositos
@cod_item INT,
@nro_deposito INT
AS
DELETE FROM items_depositos WHERE (cod_item = @cod_item AND nro_deposito = @nro_deposito)

CREATE PROCEDURE spu_mostrar_items_depositos
AS
SELECT * FROM items_depositos

CREATE PROCEDURE dbo.spu_mostrar_itemsdepositos_x_items
@cod_item INT
AS
SELECT * FROM items_depositos WHERE cod_item = @cod_item

CREATE PROCEDURE dbo.spu_mostrar_itemsdepositos_x_depositos
@num_dep INT
AS
SELECT * FROM items_depositos WHERE nro_deposito = @num_dep

CREATE PROCEDURE dbo.spu_mostrar_itemsdepositos_x_dos
@cod_item INT,
@num_dep INT
AS
SELECT * FROM items_depositos WHERE cod_item = @cod_item AND nro_deposito = @num_dep

EXEC spu_mostrar_itemsdepositos_x_dos 1,2


SELECT id.cod_item,
       i.desc_item,
       id.nro_deposito,
       d.nombre_deposito,
       id.cantidad
FROM dbo.items_depositos AS id
INNER JOIN dbo.items   AS i ON id.cod_item     = i.cod_item
INNER JOIN dbo.depositos AS d ON id.nro_deposito = d.nro_deposito;

--USUARIOS
CREATE PROCEDURE spu_login_usuarios
    @usuario NVARCHAR(50),
    @psw NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM usuarios
    WHERE usario = @usuario AND clave = @psw;
END


--DEPOSITOS
CREATE PROCEDURE spu_cargar_depositos	
@nro_deposito INT,
@nombre_deposito NVARCHAR(60)
AS
INSERT INTO depositos
VALUES(@nro_deposito, @nombre_deposito);

CREATE PROCEDURE spu_modificar_deposito
@nro_deposito INT,
@nombre_deposito NVARCHAR(60)
AS
UPDATE depositos SET nombre_deposito = @nombre_deposito WHERE nro_deposito = @nro_deposito;

CREATE PROCEDURE spu_eliminar_deposito
@nro_deposito INT
AS
DELETE FROM depositos WHERE nro_deposito = @nro_deposito

CREATE PROCEDURE spu_mostrar_depositos
AS
SELECT * FROM depositos

CREATE PROCEDURE dbo.spu_Obtener_ID_Deposito
    @NextID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @next INT;

    SELECT @next = ISNULL(MAX(nro_deposito), 0) + 1
    FROM dbo.depositos;

    -- Asignar al parámetro OUTPUT correctamente
    SET @NextID = @next;
END;

DECLARE @id INT;                                  -- 1) declarar variable
EXEC dbo.spu_Obtener_ID_Deposito @NextID = @id OUTPUT;  -- 2) ejecutar y pasar OUTPUT
SELECT @id AS siguiente;                          -- 3) ver el valor


--ITEMS
CREATE PROCEDURE spu_cargar_items
@cod_item INT,
@desc_item NVARCHAR(60),
@precio DECIMAL (18,2),
@fecha_vto DATE
AS
INSERT INTO items
VALUES(@cod_item, @desc_item, @precio, @fecha_vto);

CREATE PROCEDURE spu_modificar_items
@cod_item INT,
@desc_item NVARCHAR(60),
@precio DECIMAL (18,2),
@fecha_vto DATE
AS
UPDATE items SET desc_item = @desc_item, precio = @precio, fecha_vto = @fecha_vto WHERE cod_item = @cod_item;

CREATE PROCEDURE spu_eliminar_items
@cod_item INT
AS
DELETE FROM items WHERE cod_item = @cod_item

CREATE PROCEDURE spu_mostrar_items
AS
SELECT * FROM items

CREATE PROCEDURE dbo.spu_Obtener_codItem
    @NextID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @next INT;

    SELECT @next = ISNULL(MAX(cod_item), 0) + 1
    FROM dbo.items;

    -- Asignar al parámetro OUTPUT correctamente
    SET @NextID = @next;
END;

DECLARE @id INT;                                  -- 1) declarar variable
EXEC spu_obtespu_Obtener_codItem @NextID = @id OUTPUT;  -- 2) ejecutar y pasar OUTPUT
SELECT @id AS siguiente;                          -- 3) ver el valor

--BACKUP

CREATE PROCEDURE spu_backup
AS
DECLARE @MyFileName VARCHAR(1000)
SELECT @MyFileName = (SELECT 'C:\Users\EZEQUIELEITOR\source\repos\PARCIAL 2025\BACKUP'+ CONVERT (VARCHAR(500),GETDATE(),112)+'.bak') 
BACKUP DATABASE [Parcial2025]
TO DISK = @MyFileName

--USUARIOS
CREATE PROCEDURE spu_mostrar_usuarios
AS
SELECT * FROM usuarios

--INSERTAR VALORES
INSERT INTO usuarios
VALUES('eze', 123)


EXEC spu_mostrar_items_depositos


SELECT * FROM items_depositos

EXEC spu_eliminar_items_depositos 2,1

EXEC spu_update_items_depositos 2,3,500

EXEC spu_mostrar_itemsdepositos_x_depositos 3

EXEC spu_mostrar_itemsdepositos_x_items 2