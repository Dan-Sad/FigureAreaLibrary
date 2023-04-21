-- Tabels
CREATE TABLE Product (
  Id INT PRIMARY KEY,
  Name TEXT NOT NULL
);
CREATE TABLE Category (
  Id INT PRIMARY KEY,
  Name TEXT NOT NULL
);
CREATE TABLE ProductsCategories (
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL,
	FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
	FOREIGN KEY (ProductId) REFERENCES Products(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

-- Init tabels
INSERT INTO Product VALUES ('1', 'Car'), ('2','Board');
INSERT INTO Category VALUES ('1', 'First'), ('2', 'Second');
INSERT INTO ProductsCategories VALUES ('1', '1'), ('1', '2');

-- Require
SELECT Product.Name, Category.Name 
FROM Product 
LEFT JOIN ProductsCategories ON ProductId = Product.Id
LEFT JOIN Category ON CategoryId = Category.Id;