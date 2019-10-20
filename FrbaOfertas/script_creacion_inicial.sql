--seteo la base de datos a utilizar
use gd2c2019
GO

--creo el nuevo schema
IF NOT EXISTS ( SELECT * FROM sys.schemas WHERE name = N'DEFAULT_NAME' )
    EXEC('CREATE SCHEMA [DEFAULT_NAME] AUTHORIZATION [gdCupon2019]');
GO

--se crea la tabla funcionalidad, se elimina previamente si ya existe
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Funcionalidad' AND type = 'U') 
begin
	--primero borramos las foreign keys
	ALTER TABLE [DEFAULT_NAME].[Funcionalidad_Por_Rol] DROP CONSTRAINT [FK_FUNCIONALIDADROL_FUNCIONALIDAD]
	--luego eliminamos la tabla
	DROP TABLE [DEFAULT_NAME].[Funcionalidad];
end
CREATE TABLE [DEFAULT_NAME].[Funcionalidad]
(
	Id_Funcionalidad int IDENTITY(1,1) PRIMARY KEY,
    Detalle_func varchar(255) NOT NULL,
)

--se crea la tabla de roles, se elimina si ya existe previamente, 
--se setea el nombre como unico, y el estado en bit para activar o desactivar el rol
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Rol' AND type = 'U') 
Begin
	--primero borramos la foreign key
	ALTER TABLE [DEFAULT_NAME].[Funcionalidad_Por_Rol] DROP CONSTRAINT [FK_FUNCIONALIDADROL_ROL]
	ALTER TABLE [DEFAULT_NAME].[Rol_Por_Cuenta] DROP CONSTRAINT [FK_ROLCUENTA_ROL]
	--luego borramos la tabla
	DROP TABLE [DEFAULT_NAME].[Rol]
end
CREATE TABLE [DEFAULT_NAME].[Rol]
(
	Id_Rol int IDENTITY(1,1) PRIMARY KEY,
    Nombre_rol varchar(255) NOT NULL unique,
	Estado_rol bit NOT NULL,
)

--creamos la tabla de funcionalidades por rol, si la misma ya existia la eliminamos del sistema.
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Funcionalidad_Por_Rol' AND type = 'U') DROP TABLE [DEFAULT_NAME].[Funcionalidad_Por_Rol]
CREATE TABLE [DEFAULT_NAME].[Funcionalidad_Por_Rol]
(
	Id_Rol int NOT NULL,
    Id_Funcionalidad  int NOT NULL,
	CONSTRAINT PK_Funcionalidad_Por_Rol Primary Key (Id_Rol,Id_Funcionalidad)
)

--creacion de tabla cuentas
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Cuenta' AND type = 'U') 
Begin
	--primero borramos la foreign key
	ALTER TABLE [DEFAULT_NAME].[Rol_Por_Cuenta] DROP CONSTRAINT [FK_ROLCUENTA_CUENTA]
	ALTER TABLE [DEFAULT_NAME].[Cliente] DROP CONSTRAINT [FK_CLIENTE_CUENTA]
	ALTER TABLE [DEFAULT_NAME].[Proveedor] DROP CONSTRAINT [FK_PROVEEDOR_CUENTA]
	--luego borramos la tabla
	DROP TABLE [DEFAULT_NAME].[Cuenta]
end
CREATE TABLE [DEFAULT_NAME].[Cuenta]
(
	Id_Usuario int IDENTITY(1,1) PRIMARY KEY,
    Usuario_Cuenta varchar(20) NOT NULL unique,
	Contra_Cuenta varbinary(100) NOT NULL,
	Cant_Ingresos_Cuenta int NOT NULL default(0),
	Estado_Cuenta int NOT NULL,
)

--creamos la tabla de de roles para l cuenta, si la misma ya existia la eliminamos del sistema.
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Rol_Por_Cuenta' AND type = 'U') DROP TABLE [DEFAULT_NAME].[Rol_Por_Cuenta]
CREATE TABLE [DEFAULT_NAME].[Rol_Por_Cuenta]
(
	Id_Rol int NOT NULL,
    Id_Usuario  int NOT NULL,
	CONSTRAINT PK_Rol_Por_Cuenta Primary Key (Id_Rol,Id_Usuario)
)


--CREAMOS LA TABLA DOMICILIOS, LA MISMA NO TIENE FK CONTRA CLIENTES Y PROVEEDORES
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Direccion' AND type = 'U') DROP TABLE [DEFAULT_NAME].[Direccion]
CREATE TABLE [DEFAULT_NAME].[Direccion]
(
	Id_Direccion int IDENTITY(1,1) PRIMARY KEY,
	Id_Objeto int NOT NULL,
	Tipo_Objeto int NOT NULL, --1 cliente, 2 proveedor
    Numero_Dir varchar(8),
	Piso_Dir varchar(3),
	Depto_Dir varchar(3),
	Localidad_Dir varchar(100),
	Ciudad_Dir varchar(100),
	Calle_Dir varchar(100),
	Codigo_Postal_Dir varchar(10),
)


--se agrega la tabla clientes. se borra la misma si existia previamente
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Cliente' AND type = 'U') 
begin
	--eliminamos foreign keys antes de eliminar tabla
	ALTER TABLE [DEFAULT_NAME].[Cliente] DROP CONSTRAINT [FK_CLIENTE_CLIENTE_DEST]
	ALTER TABLE [DEFAULT_NAME].[Credito] DROP CONSTRAINT [FK_CREDITO_CLIENTE]
	ALTER TABLE [DEFAULT_NAME].[Compra] DROP CONSTRAINT [FK_COMPRA_CLIENTE]
	DROP TABLE [DEFAULT_NAME].[Cliente]
end
CREATE TABLE [DEFAULT_NAME].[Cliente]
(
	Id_Cliente int IDENTITY(1,1) PRIMARY KEY,
	Id_Cuenta  int NOT NULL,
	Id_Cliente_Dest int NULL,
	Nombre_Clie varchar(100),
	Apellido_Clie varchar(100),
	DNI_Clie int,
	Mail_Clie varchar(100),
	Tel_Clie varchar(13),
	Fecha_Nac_Clie dateTime,
	Monto_Total_cred_Clie Decimal(12,2)
)

--se agrega tabla creditos, se eliminara la misma si ya existia.
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Credito' AND type = 'U') DROP TABLE [DEFAULT_NAME].[Credito]
CREATE TABLE [DEFAULT_NAME].[Credito]
(
	Id_Credito int IDENTITY(1,1) PRIMARY KEY,
	Id_Cliente  int NOT NULL,
	Carga_Fecha Datetime,
	Carga_Cred decimal(12,2),
	Tarjeta varchar(16),
	Detalle varchar(100),
	Tipo_Pago int
)

--proveedor. se borra la tabla si existia previamente
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Proveedor' AND type = 'U') 
begin
	--eliminamos foreign keys antes de eliminar tabla
	ALTER TABLE [DEFAULT_NAME].[Oferta] DROP CONSTRAINT [FK_OFERTA_PROVEEDOR]
	ALTER TABLE [DEFAULT_NAME].[Compra] DROP CONSTRAINT [FK_COMPRA_PROVEEDOR]
	ALTER TABLE [DEFAULT_NAME].[Factura] DROP CONSTRAINT [FK_FACTURA_PROVEEDOR]
	DROP TABLE [DEFAULT_NAME].[Proveedor]
end
CREATE TABLE [DEFAULT_NAME].[Proveedor]
(
	Id_Proveedor int IDENTITY(1,1) PRIMARY KEY,
	Id_Cuenta  int NOT NULL,
	Mail_Proveedor varchar(100),
	Telefono_Prov varchar(13),
	Cuit_Prov varchar(13),
	Rubro_Prov varchar(100),
	Nom_Contacto_Prov varchar(100),
	Razon_Social_Prov varchar(100),
)

--oferta se borra la tabla si existia previamente
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Oferta' AND type = 'U') 
begin
	--eliminamos foreign keys antes de eliminar tabla
	ALTER TABLE [DEFAULT_NAME].[Compra] DROP CONSTRAINT [FK_COMPRA_OFERTA]
	DROP TABLE [DEFAULT_NAME].[Oferta]
end
CREATE TABLE [DEFAULT_NAME].[Oferta]
(
	Id_Oferta int IDENTITY(1,1) PRIMARY KEY,
	Id_Proveedor  int NOT NULL,
	Descripcion_Of varchar(500),
	Fecha_Publi_Of Datetime,
	Fecha_Venc_Of Datetime,
	Precio_Oferta decimal(12,2),
	Precio_Lista decimal(12,2),
	Cant_Disp_Oferta int,
	Codigo_Of int,
	Precio_fict_Of decimal(12,2),
)


--compra, se borra la tabla si existia previamente
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Compra' AND type = 'U') 
begin
	--eliminamos foreign keys antes de eliminar tabla
	ALTER TABLE [DEFAULT_NAME].[Detalle] DROP CONSTRAINT [FK_DETALLE_COMPRA]
	DROP TABLE [DEFAULT_NAME].[Compra]
end
CREATE TABLE [DEFAULT_NAME].[Compra]
(
	Id_Compra int IDENTITY(1,1) PRIMARY KEY,
	Id_Cliente int NOT NULL,
	Id_Proveedor  int NOT NULL,
	Id_Oferta int NOT NULL,
	Fecha_Compra Datetime,
	Fecha_Entrega Datetime,
	Codigo_Cupon varchar(10),
	Estado_Cupon int,
)

--factura, se borra la tabla si existia previamente
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Factura' AND type = 'U') 
begin
	ALTER TABLE [DEFAULT_NAME].[Detalle] DROP CONSTRAINT [FK_DETALLE_FACTURA]
	DROP TABLE [DEFAULT_NAME].[Factura]
end
CREATE TABLE [DEFAULT_NAME].[Factura]
(
	Id_Factura int IDENTITY(1,1) PRIMARY KEY,
	Id_Proveedor  int NOT NULL,
	Numero_Fact varchar(13),
	Tipo_Fact char(1),
	Total_Fact decimal(14,2),
	Fecha_Fact datetime,
)

--detalle, se borra la tabla si existia previamente
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'Detalle' AND type = 'U') 
begin

	DROP TABLE [DEFAULT_NAME].[Detalle]
end
CREATE TABLE [DEFAULT_NAME].[Detalle]
(
	Id_Detalle int IDENTITY(1,1) PRIMARY KEY,
	Id_Factura  int NOT NULL,
	Id_Compra int NOT NULL,
	Monto decimal(12,2),
	Cantidad int,
	
)



--agrego las foreign key para todas las tablas en orden de creación de las tablas.
ALTER TABLE [DEFAULT_NAME].[Funcionalidad_Por_Rol] ADD CONSTRAINT FK_FUNCIONALIDADROL_ROL FOREIGN KEY (Id_Rol) REFERENCES [DEFAULT_NAME].[Rol](Id_Rol);
ALTER TABLE [DEFAULT_NAME].[Funcionalidad_Por_Rol] ADD CONSTRAINT FK_FUNCIONALIDADROL_FUNCIONALIDAD FOREIGN KEY (Id_Funcionalidad) REFERENCES [DEFAULT_NAME].[Funcionalidad](Id_Funcionalidad);
ALTER TABLE [DEFAULT_NAME].[Rol_Por_Cuenta] ADD CONSTRAINT FK_ROLCUENTA_ROL FOREIGN KEY (Id_Rol) REFERENCES [DEFAULT_NAME].[Rol](Id_Rol);
ALTER TABLE [DEFAULT_NAME].[Rol_Por_Cuenta] ADD CONSTRAINT FK_ROLCUENTA_CUENTA FOREIGN KEY (Id_Usuario) REFERENCES [DEFAULT_NAME].[Cuenta](Id_Usuario);
ALTER TABLE [DEFAULT_NAME].[Cliente] ADD CONSTRAINT FK_CLIENTE_CUENTA FOREIGN KEY (Id_Cuenta) REFERENCES [DEFAULT_NAME].[Cuenta](Id_Usuario);
ALTER TABLE [DEFAULT_NAME].[Cliente] ADD CONSTRAINT FK_CLIENTE_CLIENTE_DEST FOREIGN KEY (Id_Cliente_Dest) REFERENCES [DEFAULT_NAME].[Cliente](Id_Cliente);
ALTER TABLE [DEFAULT_NAME].[Credito] ADD CONSTRAINT FK_CREDITO_CLIENTE FOREIGN KEY (Id_Cliente) REFERENCES [DEFAULT_NAME].[Cliente](Id_Cliente);
ALTER TABLE [DEFAULT_NAME].[Proveedor] ADD CONSTRAINT FK_PROVEEDOR_CUENTA FOREIGN KEY (Id_Cuenta) REFERENCES [DEFAULT_NAME].[Cuenta](Id_Usuario);
ALTER TABLE [DEFAULT_NAME].[Oferta] ADD CONSTRAINT FK_OFERTA_PROVEEDOR FOREIGN KEY (Id_Proveedor) REFERENCES [DEFAULT_NAME].[Proveedor](Id_Proveedor);
ALTER TABLE [DEFAULT_NAME].[Compra] ADD CONSTRAINT FK_COMPRA_CLIENTE FOREIGN KEY (Id_Cliente) REFERENCES [DEFAULT_NAME].[Cliente](Id_Cliente);
ALTER TABLE [DEFAULT_NAME].[Compra] ADD CONSTRAINT FK_COMPRA_PROVEEDOR FOREIGN KEY (Id_Proveedor) REFERENCES [DEFAULT_NAME].[Proveedor](Id_Proveedor);
ALTER TABLE [DEFAULT_NAME].[Compra] ADD CONSTRAINT FK_COMPRA_OFERTA FOREIGN KEY (Id_Proveedor) REFERENCES [DEFAULT_NAME].[Oferta](Id_Oferta);
ALTER TABLE [DEFAULT_NAME].[Factura] ADD CONSTRAINT FK_FACTURA_PROVEEDOR FOREIGN KEY (Id_Proveedor) REFERENCES [DEFAULT_NAME].[Proveedor](Id_Proveedor);
ALTER TABLE [DEFAULT_NAME].[Detalle] ADD CONSTRAINT FK_DETALLE_FACTURA FOREIGN KEY (Id_Factura) REFERENCES [DEFAULT_NAME].[Factura](Id_Factura);
ALTER TABLE [DEFAULT_NAME].[Detalle] ADD CONSTRAINT FK_DETALLE_COMPRA FOREIGN KEY (Id_Compra) REFERENCES [DEFAULT_NAME].[Compra](Id_Compra);



--CREACION DE DATOS 
--creamos los roles
INSERT INTO [DEFAULT_NAME].[Rol] ([Nombre_rol],[Estado_rol])
     VALUES
           ('Administrador General', 1),
           ('Cliente', 1),
		   ('Proveedor', 1)

declare @IdAdmin int;
select @IdAdmin = Id_Rol from [DEFAULT_NAME].[Rol] where [Nombre_rol] = 'Administrador General';

--creamos las funcionalidades
INSERT INTO [DEFAULT_NAME].[Funcionalidad] ([Detalle_func])
     VALUES
           ('ABM de Rol'),
           ('Registro De Usuarios'),
           ('ABM de Cliente'),
           ('ABM de Proveedor'),
           ('Cargar Crédito'),
		   ('Comprar Oferta'),
		   ('Confección y publicación de ofertas'),
		   ('Facturación a Proveedor'),
		   ('Listado Estadístico')

--asignamos todas las funcionalidades al administrador
INSERT INTO [DEFAULT_NAME].[Funcionalidad_Por_Rol]
SELECT @IdAdmin,Id_Funcionalidad FROM [DEFAULT_NAME].[Funcionalidad]

--creamos un usuario administrador
INSERT INTO [DEFAULT_NAME].[Cuenta]
           ([Usuario_Cuenta],[Contra_Cuenta],[Cant_Ingresos_Cuenta],[Estado_Cuenta])
     VALUES
           ('admin'
           ,CONVERT(VARBINARY(100), 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
           ,0
           ,1)

declare @UserId int = @@Identity;

INSERT INTO [DEFAULT_NAME].[Rol_Por_Cuenta]
           ([Id_Rol],[Id_Usuario])
     VALUES
           (@IdAdmin,@UserId)

--IMPORTACION DESDE TABLA
