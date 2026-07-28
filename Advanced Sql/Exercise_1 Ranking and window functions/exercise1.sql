CREATE DATABASE OnlineRetailStore;
USE OnlineRetailStore;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Products VALUES
(1,'iPhone 15','Electronics',1200),
(2,'Samsung S24','Electronics',1100),
(3,'MacBook Pro','Electronics',2500),
(4,'Dell XPS','Electronics',2200),
(5,'Sony TV','Electronics',1800),
(6,'Office Chair','Furniture',350),
(7,'Wooden Table','Furniture',500),
(8,'Luxury Sofa','Furniture',1500),
(9,'Bookshelf','Furniture',700),
(10,'Dining Table','Furniture',1500),
(11,'Nike Shoes','Fashion',120),
(12,'Adidas Shoes','Fashion',120),
(13,'Leather Jacket','Fashion',250),
(14,'Watch','Fashion',500),
(15,'Handbag','Fashion',450);

SELECT * FROM Products;


SELECT *
FROM (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS Row_Num
    FROM Products
) AS RankedProducts
WHERE Row_Num <= 3;