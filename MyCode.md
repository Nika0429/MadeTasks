Исходный код:
```SQL
CREATE TABLE `Categories` (
	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`Name`	TEXT NOT NULL);

CREATE TABLE `Products` (
	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	`CategoryId`	INTEGER NOT NULL,
	`Name`	TEXT NOT NULL,
	`Price`	REAL NOT NULL,
	`Quantity`	INTEGER NOT NULL,
	`Rate`	INTEGER,
	FOREIGN KEY(CategoryId) REFERENCES Categories(Id));

INSERT INTO Categories (Id, Name)
VALUES (1, 'Food'),
	(2, 'Clothes'),
	(3, 'Electronics');
	
INSERT INTO Products (CategoryId, Name, Price, Quantity)
VALUES (1, 'Cucumber', 40, 100),
	(1, 'Banana', 50, 64),
	(1, 'Carot', 35, 86);
	
INSERT INTO Products (CategoryId, Name, Price, Quantity)
VALUES (2, 'Jeans', 1000, 25),
	(2, 'T-Shirt', 500, 70),
	(2, 'Skirt', 1200, 13);
	
INSERT INTO Products (CategoryId, Name, Price, Quantity)
VALUES (3, 'Washing machine', 3000, 3),
	(3, 'Kettle', 300, 5),
	(3, 'Hair dryer', 650, 4);
```
Мой код:
``` SQL
INSERT INTO Products (CategoryId, Name, Price, Quantity)
VALUES (1, 'Potato', 7, 200),
       (1, 'Orange', 22, 50),
		
       (2, 'Shues', 1000, 30),
       (2, 'Coat', 1000, 28), 
	   
       (3, 'SewingMachine', 3000, 7);
	  
SELECT SUM (Quantity) FROM Products; 
SELECT SUM (Price) FROM Products;

SELECT SUM (Quantity) FROM Products
GROUP BY CategoryID;

SELECT SUM (Price) FROM Products
GROUP BY CategoryID;

SELECT Name, MAX (Price) FROM Products;
SELECT Name, MAX (Quantity) FROM Products;

SELECT Name FROM Categories WHERE ID = (SELECT CategoryId FROM Products 
WHERE Price = (SELECT MAX (Price) FROM Products));

SELECT Name FROM Categories WHERE ID = (SELECT CategoryId FROM Products 
WHERE Quantity = (SELECT MAX (Quantity) FROM Products));
```
(https://github.com/Nika0429/MadeTasks/issues/9)[Ссылка на задачу]
