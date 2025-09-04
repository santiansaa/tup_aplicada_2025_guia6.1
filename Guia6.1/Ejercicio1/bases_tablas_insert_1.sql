use master
Go
drop DATABASE IF EXISTS guia6_1_Ejercicio1_dB

GO
CREATE DATABASE guia6_1_Ejercicio1_dB
GO

USE guia6_1_Ejercicio1_dB

GO

create table Figuras(
id int PRIMARY KEY IDENTITY(1,1),
Tipo int NOT NULL,
Area decimal (18,2),
Ancho DECIMAL (18,2),
Largo decimal (18,2),
Radio DECIMAL (18,2));



INSERT INTO Figuras (Tipo,Ancho,Largo,Radio)
VALUES
(1,1,1,NULL),
(1,1,2,NULL),
(2,1,2,NULL),
(2,NULL,NULL,2.1);

SELECT f.Id,
       TIPO=case when f.Tipo=1 then 'Rectangulo'
       when f.Tipo=2 then 'Circulo'
       ELSE 'NO Identificado'
       End,
       f.Area,
       f.Ancho,
       f.Largo
FROM Figuras f