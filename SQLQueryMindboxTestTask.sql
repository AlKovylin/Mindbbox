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

INSERT INTO Products VALUES(1, '�������'), (2, '���� ���������'), (3, '�������'), (4, '�����'), (5, '������'), (6, '������� 3,5�50'), (7, '���� 8�50');
INSERT INTO Category VALUES(1, '������ ����������'), (2, '�����������������');
INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 1), (4, 2), (5, 2), (6, 0), (7, 0);

SELECT 
	prod.name AS [�������],
	cat.name AS [���������]
FROM 
	Products prod
JOIN ProdCat prodcat ON prod.id = prodcat.ProdId
LEFT JOIN Category cat ON cat.id = prodcat.CatId;