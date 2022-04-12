CREATE TABLE Products
(
[Id] INT NOT NULL PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Categories
(
[Id] INT NOT NULL PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Connections
(
[Id] int NOT NULL PRIMARY KEY IDENTITY,
[ProductId] int FOREIGN KEY REFERENCES Products(Id),
[CategoriesId] int FOREIGN KEY REFERENCES Categories(Id)
)

INSERT INto Products(Name)
VALUES ('PC'), ('Sport Ball'), ('BMW'), ('Engine'), ('Cpu'), ('Boat');

INSERT INto Categories(Name)
VALUES ('Computers'), ('Sport'), ('Cars'), ('Components');

INSERT into Connections(ProductId, CategoriesId)
VALUES (1, 1), (2, 2), (3, 3), (4, 3), (4, 4), (5, 1), (5, 4), (6, NULL);

SELECT p."Name", c."Name"
FROM Connections as cn
LEFT JOIN Products as p on cn.ProductId=p.Id 
LEFT JOIN Categories as c on cn.CategoriesId=c.Id