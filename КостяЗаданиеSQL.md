![Food](https://user-images.githubusercontent.com/36271602/37728342-b23847c4-2d42-11e8-9269-44960060e8ea.png)

![FoodNew](https://user-images.githubusercontent.com/36271602/37728370-c548d1e4-2d42-11e8-95c2-02d839405f1d.png)

``` SQL
CREATE TABLE Food (Id integer NOT NULL, Name text NOT NULL, Price integer NOT NULL, Rate integer NULL, PRIMARY KEY (Id));
INSERT INTO Food (Id, Name, Price, Rate)
VALUES (1, 'Orange', 10, null),
        (2, 'Banana', 70, null),
	    (3, 'Risotto', 110, null),
	    (4, 'Pasta', 90, null);

SELECT Name FROM Food WHERE Price < 90;	
SELECT Name FROM Food WHERE Name is 'Pasta';
SELECT Name, Price FROM Food WHERE Name is 'Banana';
INSERT INTO Food (Id, Name, Price) VALUES (5, 'Steak', 130);
INSERT INTO Food (Id, Name, Price, Rate) VALUES (6, 'Apricot', 30, 65);
INSERT INTO Food (Id, Name, Price, Rate) VALUES (7, 'Egg', 30, 39);

CREATE TABLE FoodNew (Id integer NOT NULL, Name text NOT NULL, Price integer NOT NULL, Rate integer NULL, PRIMARY KEY (Id));
INSERT INTO FoodNew (Id, Name, Price, Rate) SELECT Id, Name || '-discounted', Price*0.9, Rate FROM Food;
```
