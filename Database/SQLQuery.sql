-- Bảng Categories - Quản lý loại hàng
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(200)
);

-- Bảng Products - Quản lý sản phẩm
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(100) NOT NULL,
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
    UnitPrice DECIMAL(18, 2) NOT NULL,
    PurchasePrice DECIMAL(18, 2),
    QuantityInStock INT DEFAULT 0,
    ReorderLevel INT DEFAULT 0,
    Description NVARCHAR(500),
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- Bảng Suppliers - Quản lý nhà cung cấp
CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY IDENTITY,
    SupplierName NVARCHAR(100) NOT NULL,
    ContactName NVARCHAR(100),
    Phone NVARCHAR(15),
    Address NVARCHAR(200)
);

-- Bảng Customers - Quản lý khách hàng
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    CustomerName NVARCHAR(100) NOT NULL,
    ContactName NVARCHAR(100),
    Phone NVARCHAR(15),
    Address NVARCHAR(200)
);

-- Bảng InventoryReceipts - Quản lý phiếu nhập kho
CREATE TABLE InventoryReceipts (
    ReceiptID INT PRIMARY KEY IDENTITY,
    SupplierID INT FOREIGN KEY REFERENCES Suppliers(SupplierID),
    ReceiptDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18, 2) DEFAULT 0
);

-- Bảng InventoryReceiptDetails - Chi tiết nhập kho
CREATE TABLE InventoryReceiptDetails (
    ReceiptDetailID INT PRIMARY KEY IDENTITY,
    ReceiptID INT FOREIGN KEY REFERENCES InventoryReceipts(ReceiptID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(18, 2) NOT NULL CHECK (UnitPrice >= 0),
    Total AS (Quantity * UnitPrice) PERSISTED
);

-- Bảng InventoryIssues - Quản lý phiếu xuất kho
CREATE TABLE InventoryIssues (
    IssueID INT PRIMARY KEY IDENTITY,
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    IssueDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18, 2) DEFAULT 0
);

-- Bảng InventoryIssueDetails - Chi tiết xuất kho
CREATE TABLE InventoryIssueDetails (
    IssueDetailID INT PRIMARY KEY IDENTITY,
    IssueID INT FOREIGN KEY REFERENCES InventoryIssues(IssueID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(18, 2) NOT NULL CHECK (UnitPrice >= 0),
    Total AS (Quantity * UnitPrice) PERSISTED
);

-- Bảng Users - Quản lý người dùng
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(200) NOT NULL,
    Role NVARCHAR(20) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- Tạo các chỉ mục bổ sung để tối ưu hóa truy vấn
CREATE INDEX idx_ProductName ON Products(ProductName);
CREATE INDEX idx_CategoryID ON Products(CategoryID);
CREATE INDEX idx_SupplierID ON InventoryReceipts(SupplierID);
CREATE INDEX idx_CustomerID ON InventoryIssues(CustomerID);