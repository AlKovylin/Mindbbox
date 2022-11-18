CREATE TABLE Products(
	id INT PRIMARY KEY, 
	name VARCHAR(100) NOT NULL
	);
CREATE TABLE Category(
	id INT PRIMARY KEY, 
	name VARCHAR(100) NOT NULL
	);
CREATE TABLE ProdCat ( 
	ProdId INT NOT NULL, 
	CatId INT NOT NULL, 
	);

INSERT INTO Products VALUES(1, 'Молоток'), (2, 'Ключ разводной'), (3, 'Ножовка'), (4, 'Дрель'), (5, 'Лобзик'), (6, 'Саморез 3,5х50'), (7, 'Винт 8х50');
INSERT INTO Category VALUES(1, 'Ручной инструмент'), (2, 'Электроинструмент');
INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 1), (4, 2), (5, 2), (6, 0), (7, 0);

SELECT 
	prod.name AS [Продукт],
	cat.name AS [Категория]
FROM 
	Products prod
JOIN ProdCat prodcat ON prod.id = prodcat.ProdId
LEFT JOIN Category cat ON cat.id = prodcat.CatId;