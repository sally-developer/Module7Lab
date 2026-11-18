SELECT CompanyName, Phone FROM Shippers ORDER BY CompanyName DESC;

SELECT ContactName, Country FROM Customers WHERE Country = 'Argentina' ORDER BY ContactName;

SELECT c.ContactName, o.OrderDate FROM Customers AS c JOIN Orders AS o ON c.CustomerID = o.CustomerID WHERE c.CustomerID = 'ALFKI';

INSERT INTO Customers (CustomerID, ContactName, CompanyName, Country) VALUES ('BOB01', 'Bob Baker', 'Baker Brothers', 'USA');
SELECT * FROM Customers WHERE CustomerID = 'BOB01';
UPDATE Customers SET ContactName = 'Robert Baker' WHERE CustomerID = 'BOB01';
SELECT CustomerID, ContactName FROM Customers WHERE CustomerID = 'BOB01';
DELETE FROM Customers WHERE CustomerID = 'BOB01';
SELECT * FROM Customers WHERE CustomerID = 'BOB01';

SELECT OrderID, OrderDate, ShipCity FROM Orders WHERE CustomerID = 'ALFKI' ORDER BY OrderDate DESC;

SELECT c.CompanyName, o.OrderID FROM Customers AS c JOIN Orders AS o ON c.CustomerID = o.CustomerID WHERE c.CompanyName = 'QUICK-Stop' LIMIT 3;

INSERT INTO Customers (CustomerID, ContactName, CompanyName, Country) VALUES ('MYCUS', 'Salma Ahmed', 'North Star Solutions', 'USA');
SELECT * FROM Customers WHERE CustomerID = 'MYCUS';
UPDATE Customers SET Country = 'Canada' WHERE CustomerID = 'MYCUS';
SELECT CustomerID, ContactName, CompanyName, Country FROM Customers WHERE CustomerID = 'MYCUS';
DELETE FROM Customers WHERE CustomerID = 'MYCUS';
SELECT * FROM Customers WHERE CustomerID = 'MYCUS';
