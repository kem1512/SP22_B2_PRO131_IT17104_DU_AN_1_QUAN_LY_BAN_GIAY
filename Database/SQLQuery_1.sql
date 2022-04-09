CREATE DATABASE QuanLyBanGiay
GO

USE QuanLyBanGiay
GO

CREATE TABLE Product
(
    ProductId VARCHAR(9) PRIMARY KEY,
    ProductName NVARCHAR(250) NOT NULL,
    Description NVARCHAR(250),
    ProductImage VARCHAR(250) NOT NULL,
    Barcode VARCHAR(13),
    Status BIT NOT NULL,
)

CREATE TABLE Color
(
    ColorId VARCHAR(9) PRIMARY KEY,
    ColorName NVARCHAR(25) NOT NULL
)

CREATE TABLE Size
(
    SizeId VARCHAR(9) PRIMARY KEY,
    SizeName VARCHAR(9) NOT NULL
)

CREATE TABLE Brand
(
    BrandId VARCHAR(9) PRIMARY KEY,
    BrandName VARCHAR(100) NOT NULL
)

CREATE TABLE Material
(
    MaterialId VARCHAR(9) PRIMARY KEY,
    MaterialName NVARCHAR(100) NOT NULL
)

CREATE TABLE Category
(
    CategoryId VARCHAR(9) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
)

CREATE TABLE ProductDetail
(
    ProductId VARCHAR(9) FOREIGN KEY REFERENCES Product(ProductId),
    ColorId VARCHAR(9) FOREIGN KEY REFERENCES Color(ColorId),
    SizeId VARCHAR(9) FOREIGN KEY REFERENCES Size(SizeId),
    BrandId VARCHAR(9) FOREIGN KEY REFERENCES Brand(BrandId),
    MaterialId VARCHAR(9) FOREIGN KEY REFERENCES Material(MaterialId),
    CategoryId VARCHAR(9) FOREIGN KEY REFERENCES Category(CategoryId),
    UnitPrice FLOAT NOT NULL,
    CONSTRAINT PK_ProductDetail PRIMARY KEY (ProductId)
)


CREATE TABLE Inventory
(
    ProductId VARCHAR(9) FOREIGN KEY REFERENCES ProductDetail(ProductId) PRIMARY KEY,
    Amount INT NOT NULL
)

CREATE TABLE Roles
(
    RoleId VARCHAR(9) PRIMARY KEY,
    RoleName NVARCHAR(25) NOT NULL
)

CREATE TABLE Employee 
(
    EmployeeId VARCHAR(9) PRIMARY KEY,
    FullName NVARCHAR(250) NOT NULL,
    Email NVARCHAR(250) NOT NULL,
    Pass VARCHAR(9) NOT NULL,
    Phone VARCHAR(12) NOT NULL,
    Gender BIT NOT NULL,
    Address NVARCHAR(250) NOT NULL,
    EmployeeImage VARCHAR(250) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Status BIT NOT NULL,
    RoleId VARCHAR(9) FOREIGN KEY REFERENCES Roles(RoleId)
)

CREATE TABLE Shipper
(
    ShipperId VARCHAR(9) PRIMARY KEY,
    ShipperName NVARCHAR(250) NOT NULL,
    ShipperPhone VARCHAR(12) NOT NULL,
    RoleId VARCHAR(9) FOREIGN KEY REFERENCES Roles(RoleId),
    ShipperStatus BIT NOT NULL
)

CREATE TABLE Customer
(
    CustomerId VARCHAR(9) PRIMARY KEY,
    CustomerName NVARCHAR(250) NOT NULL,
    Phone VARCHAR(12) NOT NULL,
    Address NVARCHAR(250) NOT NULL,
    ShoppingCount INT NOT NULL,
    Status BIT NOT NULL,
)

CREATE TABLE Invoice
(
    InvoiceId VARCHAR(9) PRIMARY KEY,
    CustomerId VARCHAR(9) FOREIGN KEY REFERENCES Customer(CustomerId),
    EmployeeId VARCHAR(9) FOREIGN KEY REFERENCES Employee(EmployeeId),
    ShipperId VARCHAR(9) FOREIGN KEY REFERENCES Shipper(ShipperId),
    ShipCost FLOAT,
    DateCreate DATETIME NOT NULL,
    GuestPayments FLOAT,
    InvoiceStatus BIT NOT NULL,
    Description NVARCHAR(250)
)

CREATE TABLE InvoiceDetail
(
    InvoiceId VARCHAR(9),
    ProductId VARCHAR(9),
    Quantity INT NOT NULL,
    Price FLOAT NOT NULL,
    TotalPrice FLOAT NOT NULL,
    CONSTRAINT PK_Invoice PRIMARY KEY (InvoiceId, ProductId),
    CONSTRAINT FK_Invoice FOREIGN KEY (InvoiceId) REFERENCES Invoice(InvoiceId),
    CONSTRAINT FK_ProductDetail FOREIGN KEY (ProductId) REFERENCES ProductDetail(ProductId)
)

INSERT INTO Roles VALUES('R1', N'Quản Lý')
INSERT INTO Roles VALUES('R2', N'Nhân Viên')
INSERT INTO Roles VALUES('R3', N'Shipper')
INSERT INTO Shipper VALUES('SP1', N'Hải Đăng', '0357503628', 'R3', 0)
INSERT INTO Shipper VALUES('SP2', N'Trần Nam', '0123456789', 'R3', 0)
INSERT INTO Customer VALUES('CT1', 'Vivi', '03575121','Hà Nội',0,1)
INSERT INTO Employee VALUES('EM1', N'Hải Đăng', '123','123','123',0,'123','123','2002/01/01',1,'R1')
INSERT INTO Customer VALUES('CT1', 'Vivi', '03575121',N'Hà Nội',0,1)
INSERT INTO Employee VALUES('EM1', N'Hải Đăng', '123','123','123',0,'123','123','2002/01/01',0,'R1')
INSERT INTO Color VALUES('CL1',N'Đỏ')
INSERT INTO Color VALUES('CL2',N'Vàng')
INSERT INTO Size VALUES('S1','38')
INSERT INTO Size VALUES('S2','39')
INSERT INTO Material VALUES('MT1',N'Giày Da')
INSERT INTO Material VALUES('MT2',N'Giày cao su')
INSERT INTO Category VALUES('CT1',N'Giày công sở')
INSERT INTO Category VALUES('CT2', N'Giày nam')
INSERT INTO Brand VALUES('BR1','Adidas')
INSERT INTO Brand VALUES('BR2','Nike')
