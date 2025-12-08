CREATE TABLE [User] (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150),
    Address NVARCHAR(255),
    PhoneNumber NVARCHAR(20),
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50)
);

CREATE TABLE Category (
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE Product (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(150) NOT NULL,
    ProductCode NVARCHAR(50),
    Description NVARCHAR(255),
    CategoryId INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    CostPrice DECIMAL(10,2) NOT NULL,
    StockQuantity INT NOT NULL,
    CriticalStockLevel INT NOT NULL,
    ProductImage NVARCHAR(255),
    CONSTRAINT FK_Product_Category FOREIGN KEY (CategoryId)
        REFERENCES Category(CategoryId)
);

CREATE TABLE Supplier (
    SupplierId INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName NVARCHAR(150) NOT NULL,
    ContactPerson NVARCHAR(100),
    Address NVARCHAR(255),
    Email NVARCHAR(150)
);

CREATE TABLE [Transaction] (
    TransactionId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    TransactionDate DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    TotalAmount DECIMAL(10,2) NOT NULL,
    Status NVARCHAR(50),
    CONSTRAINT FK_Transaction_User FOREIGN KEY (UserId)
        REFERENCES [User](UserId)
);

CREATE TABLE TransactionItem (
    TransactionItemId INT IDENTITY(1,1) PRIMARY KEY,
    TransactionId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    Subtotal AS (Quantity * UnitPrice) PERSISTED,
    CONSTRAINT FK_TransactionItem_Transaction FOREIGN KEY (TransactionId)
        REFERENCES [Transaction](TransactionId),
    CONSTRAINT FK_TransactionItem_Product FOREIGN KEY (ProductId)
        REFERENCES Product(ProductId)
);

CREATE TABLE StockMovement (
    MovementId INT IDENTITY(1,1) PRIMARY KEY,
    ProductId INT NOT NULL,
    QuantityChanged INT NOT NULL,
    Type NVARCHAR(50),   -- IN / OUT / ADJUSTMENT
    SupplierId INT,
    Date DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    PerformedBy INT,
    CONSTRAINT FK_StockMovement_Product FOREIGN KEY (ProductId)
        REFERENCES Product(ProductId),
    CONSTRAINT FK_StockMovement_Supplier FOREIGN KEY (SupplierId)
        REFERENCES Supplier(SupplierId),
    CONSTRAINT FK_StockMovement_User FOREIGN KEY (PerformedBy)
        REFERENCES [User](UserId)
);

CREATE TABLE PurchaseOrder (
    PurchaseOrderId INT IDENTITY(1,1) PRIMARY KEY,
    SupplierId INT NOT NULL,
    Date DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    Status NVARCHAR(50),
    TotalCost DECIMAL(10,2),
    CONSTRAINT FK_PurchaseOrder_Supplier FOREIGN KEY (SupplierId)
        REFERENCES Supplier(SupplierId)
);

CREATE TABLE PurchaseOrderItem (
    PurchaseOrderItemId INT IDENTITY(1,1) PRIMARY KEY,
    PurchaseOrderId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    CostPrice DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_POItem_PO FOREIGN KEY (PurchaseOrderId)
        REFERENCES PurchaseOrder(PurchaseOrderId),
    CONSTRAINT FK_POItem_Product FOREIGN KEY (ProductId)
        REFERENCES Product(ProductId)
);







