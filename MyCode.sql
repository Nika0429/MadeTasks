
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



