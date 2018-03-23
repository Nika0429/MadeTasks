Исходный код:
``` SQL
CREATE TABLE Food (Id integer NOT NULL, Name text NOT NULL, Price integer NOT NULL, Rate integer NULL, PRIMARY KEY (Id));
INSERT INTO Food (Id, Name, Price, Rate)
VALUES (1, 'Orange', 10, null),
        (2, 'Banana', 70, null),
	    (3, 'Risotto', 110, null),
	    (4, 'Pasta', 90, null)
```

Мой код:
``` SQL
SELECT Name FROM Food WHERE Price < 90;	
SELECT Name FROM Food WHERE Name is 'Pasta';
SELECT Name, Price FROM Food WHERE Name is 'Banana';
INSERT INTO Food (Id, Name, Price) VALUES (5, 'Steak', 130);
INSERT INTO Food (Id, Name, Price, Rate) VALUES (6, 'Apricot', 30, 65);
INSERT INTO Food (Id, Name, Price, Rate) VALUES (7, 'Egg', 30, 39);

INSERT INTO Food (Id, Name, Price, Rate) SELECT Id*8, Name || '-discounted', Price*0.9, Rate FROM Food;
```

[Ссылка на задачу](https://github.com/Nika0429/MadeTasks/issues/8)

Код в процессе урока 22.03.2018:
``` SQL
DELETE FROM Food WHERE Id > 7;
UPDATE Food SET Rate = 0 WHERE Rate IS NULL;
SELECT SUM (Price), MIN (Price), MAX (Price), AVG (Price) FROM Food;
SELECT COUNT (*) FROM Food;
UPDATE Food SET Rate = NULL WHERE Rate = 0;
SELECT SUM (Rate), MIN (Rate), MAX (Rate), AVG (Rate) FROM Food WHERE Rate IS NOT NULL;
SELECT * FROM Food;
```
