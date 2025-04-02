CREATE DATABASE IMS;

USE IMS;

-- Table 1

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1, 1),
    ProductName VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Quantity INT NOT NULL
);

-- Table 2

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    CustomerName VARCHAR(100) NOT NULL UNIQUE,
    CustomerEmail VARCHAR(200) NOT NULL,
    CustomerContact VARCHAR(15) NOT NULL
);

-- Table 3

CREATE TABLE Sellers (
    SellerID INT PRIMARY KEY IDENTITY,
    SellerName VARCHAR(100) NOT NULL UNIQUE,
    SellerEmail VARCHAR(200) NOT NULL,
    SellerContact VARCHAR(15) NOT NULL
);

-- Table 4

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY,
    CustomerID INT NOT NULL,
    ProductID INT NOT NULL,
    OrderDate DATE NOT NULL,
    Quantity INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Table 5

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY,
    Username VARCHAR(100) NOT NULL UNIQUE,
    UserPassword VARCHAR(50) NOT NULL
);

-- Procedure 1

CREATE PROCEDURE displayAllCustomers
AS
BEGIN
	SELECT * FROM Customers;
END;

-- Procedure 2

CREATE PROCEDURE emptyEntireDatabase
AS
BEGIN
	TRUNCATE TABLE Sellers;
	TRUNCATE TABLE Orders;
    TRUNCATE TABLE Users;
	DELETE FROM Products;
	DELETE FROM Customers;
	DBCC CHECKIDENT('Customers', RESEED, 0);
	DBCC CHECKIDENT('Products', RESEED, 0);
END;

-- Procedure 3

CREATE PROCEDURE addNewCustomer
	@Name VARCHAR(100),
	@Email VARCHAR(200),
	@Phone VARCHAR(15)
AS
BEGIN
	INSERT INTO 
	Customers
	(CustomerName, CustomerEmail, CustomerContact)
	VALUES
	(@Name, @Email, @Phone);
END;

-- Procedure 4

CREATE PROCEDURE deleteCustomerRecord
    @Id INT
AS
BEGIN
    DELETE FROM Customers WHERE CustomerID = @Id;
END;

-- Procedure 5

CREATE PROCEDURE deleteAllCustomerRecords
AS
BEGIN
    DELETE FROM Customers;
    DBCC CHECKIDENT('Customers', RESEED, 0);
END;

-- Procedure 6

CREATE PROCEDURE searchCustomerByName
    @Name VARCHAR(100)
AS
BEGIN
    SELECT * FROM Customers WHERE CustomerName LIKE @Name;
END;

-- Procedure 7

CREATE PROCEDURE getCustomerById
    @Id INT
AS
BEGIN
    SELECT * FROM Customers WHERE CustomerID = @Id;
END;

-- Procedure 8

CREATE PROCEDURE updateCustomer
    @Id INT,
    @Name VARCHAR(100),
	@Email VARCHAR(200),
	@Phone VARCHAR(15)
AS
BEGIN
    UPDATE Customers
    SET
    CustomerName = @Name,
    CustomerEmail = @Email,
    CustomerContact = @Phone
    WHERE
    CustomerID = @Id;
END;   

-- Procedure 9

CREATE PROCEDURE verifyUserLogin
	@Username VARCHAR(100),
	@Password VARCHAR(50)
AS
BEGIN
	SELECT * FROM Users WHERE Username = @Username AND UserPassword = @Password;
END;

-- Procedure 10

CREATE PROCEDURE addNewSeller
	@Name VARCHAR(100),
	@Email VARCHAR(200),
	@Contact VARCHAR(15)
AS
BEGIN
	INSERT INTO Sellers 
	(SellerName, SellerEmail, SellerContact) 
	VALUES 
	(@Name, @Email, @Contact);
END;

-- Procedure 11

CREATE PROCEDURE displayAllSellers
AS
BEGIN
	SELECT * FROM Sellers;
END;

-- Procedure 12

CREATE PROCEDURE addNewSellerRecord
	@Name VARCHAR(100),
	@Email VARCHAR(200),
	@Contact VARCHAR(15)
AS
BEGIN
	INSERT INTO Sellers
	(SellerName, SellerEmail, SellerContact)
	VALUES
	(@Name, @Email, @Contact);
END;

-- Procedure 13

CREATE PROCEDURE deleteAllSellerRecords
AS
BEGIN
	TRUNCATE TABLE Sellers;
END;

-- Procedure 14

CREATE PROCEDURE searchSellerByName
    @Name VARCHAR(100)
AS
BEGIN
    SELECT * FROM Sellers WHERE SellerName LIKE @Name;
END;

-- Procedure 15

CREATE PROCEDURE deleteSellerRecord
    @Id INT
AS
BEGIN
    DELETE FROM Sellers WHERE SellerID = @Id;
END;

-- Procedure 16

CREATE PROCEDURE getSellerById
    @Id INT
AS
BEGIN
    SELECT * FROM Sellers WHERE SellerID = @Id;
END;

-- Procedure 17

CREATE PROCEDURE updateSeller
    @Id INT,
    @Name VARCHAR(100),
	@Email VARCHAR(200),
	@Phone VARCHAR(15)
AS
BEGIN
    UPDATE Sellers
    SET
    SellerName = @Name,
    SellerEmail = @Email,
    SellerContact = @Phone
    WHERE
    SellerID = @Id;
END;

-- Procedure 18

CREATE PROCEDURE displayAllProducts
AS
BEGIN
	SELECT * FROM Products;
END;

-- Procedure 19

CREATE PROCEDURE addNewProduct
	@Name VARCHAR(100),
	@Price DECIMAL(10, 2),
	@QTY INT
AS
BEGIN
	INSERT INTO Products
	(ProductName, Price, Quantity)
	VALUES
	(@Name, @Price, @QTY);
END;

-- Procedure 20

CREATE PROCEDURE deleteAllProductRecords
AS
BEGIN
	DELETE FROM Products;
	DBCC CHECKIDENT('Products', RESEED, 0);
END;

-- Procedure 21

CREATE PROCEDURE searchProductByName
    @Name VARCHAR(100)
AS
BEGIN
    SELECT * FROM Products WHERE ProductName LIKE @Name;
END;

-- Procedure 22

CREATE PROCEDURE getProductById
    @Id INT
AS
BEGIN
    SELECT * FROM Products WHERE ProductID = @Id;
END;

-- Procedure 23

CREATE PROCEDURE updateProduct
    @Id INT,
    @Name VARCHAR(100),
    @Price DECIMAL(10, 2),
    @QTY INT
AS
BEGIN
    UPDATE Products
    SET
        ProductName = @Name,
        Price = @Price,
        Quantity = @QTY
    WHERE
        ProductID = @Id;
END;

-- Procedure 24

CREATE PROCEDURE deleteProductRecord
    @Id INT
AS
BEGIN
    DELETE FROM Products WHERE ProductID = @Id;
END;

-- Procedure 25

CREATE PROCEDURE displayUserRecord
    @Username VARCHAR(100)
AS
BEGIN
    SELECT * FROM Users WHERE Username = @Username;
END;

-- Procedure 26

CREATE PROCEDURE deleteUserRecord
    @Username VARCHAR(100)
AS
BEGIN
    DELETE FROM Users WHERE Username = @Username;
END;

-- Procedure 27

CREATE PROCEDURE udpateUserRecord
    @Id INT,
    @Name VARCHAR(100),
    @Password VARCHAR(50)
AS
BEGIN
    UPDATE Users 
    SET
    Username = @Name,
    UserPassword = @Password
    WHERE 
    UserId = @Id;
END;

-- Procedure 28

CREATE PROCEDURE displayAllOrders
AS
BEGIN
    SELECT 
        Orders.OrderID,
        Orders.OrderDate,
        Customers.CustomerName,
        Products.ProductName,
        Orders.Quantity,
        Products.Price,
        (Orders.Quantity * Products.Price) AS TotalPrice
    FROM 
        Orders
    INNER JOIN 
        Customers ON Orders.CustomerID = Customers.CustomerID
    INNER JOIN 
        Products ON Orders.ProductID = Products.ProductID;
END;

-- Procedure 29

CREATE PROCEDURE deleteOrderRecord
    @Id INT
AS
BEGIN
    DELETE FROM Orders WHERE OrderID = @Id;
END;

-- Procedure 30

CREATE PROCEDURE createNewOrder
    @CustomerID INT,
    @ProductID INT,
    @OrderDate DATE,
    @Quantity INT
AS
BEGIN
    INSERT INTO Orders 
    (CustomerID, ProductID, OrderDate, Quantity)
    VALUES
    (@CustomerID, @ProductID, @OrderDate, @Quantity);
END;

-- Procedure 31

CREATE PROCEDURE decrementProductQuantity
	@q INT,
	@p INT
AS
BEGIN
	UPDATE Products SET Quantity = Quantity - @q WHERE ProductID = @p;
END;

-- Procedure 31

CREATE PROCEDURE deleteAllOrders
AS
BEGIN
	TRUNCATE TABLE Orders;
END;