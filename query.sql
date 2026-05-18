Create Database SedapMakanDatabase
use SedapMakanDatabase


CREATE TABLE Users (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100)	,
	Role NVARCHAR(50),
    Password NVARCHAR(100) NOT NULL,
	Email NVARCHAR(50),
	Nationality NVARCHAR(50),
	DOB DATE,
	Phone NVARCHAR(15),
	EWalletBalance DECIMAL(10, 2) NOT NULL DEFAULT 0.00 
);


INSERT INTO Users (Name, Password,Role, Email, Nationality, DOB, Phone, EWalletBalance) VALUES 
('yaya', '000','Chef','yaya@gmail.com','American','1999-01-01','1111111', 12.00),
('ibrahim', '000','Customer','ibrahim@gmail.com','American','1999-01-01','22222222', 15.00),
('charlie', '000','Manager','charlie@gmail.com','American','1999-01-01','22222222', 10.00),
('taux', '000','Admin','taux@gmail.com','American','1999-01-01','22222222', 8.00);


CREATE TABLE MenuItems (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    ImagePath NVARCHAR(255), 
    Price DECIMAL(10, 2),
    Category NVARCHAR(50),
    Availability NVARCHAR(50)
);

INSERT INTO MenuItems (Name,Price,ImagePath, Category, Availability) VALUES 
('Burger', 10.00,'Resources\burger.jpg', 'MainCourse', '1'),
('Ceaser Salad', 11.00,'Resources\salad.jpg', 'Appetizer', '1'),
('Orange Juice', 12.00,'Resources\orange.jpg', 'Beverage', '1'),
('Cheesecake', 13.00,'Resources\cheesecake.jpg', 'Dessert', '1');



CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,    
    CustomerID INT NOT NULL,              
    Quantity INT NOT NULL CHECK (Quantity > 0),
    TotalPrice DECIMAL(10, 2) NOT NULL,       
    Status NVARCHAR(50) NOT NULL DEFAULT 'Pending', 
    OrderDate DATETIME NOT NULL DEFAULT GETDATE(), 
    FOREIGN KEY (CustomerID) REFERENCES Users(ID),
);


INSERT INTO Orders (CustomerID,Quantity, TotalPrice, Status, OrderDate)
VALUES 
(1, 1, 25.00, 'Completed', GETDATE() - 5),
(2, 3, 10.00, 'In Progress', GETDATE() - 2),
(3, 2, 15.00, 'Pending', GETDATE());

create table OrderItems (
	OrderID INT foreign key references Orders (OrderID),
	MenuItemID INT foreign key references MenuItems(Id),
	Quantity int,
	Remark nvarchar(255),
	Status NVARCHAR(50) NOT NULL DEFAULT 'Pending', 
	primary key(OrderID, MenuItemID)
)

insert into OrderItems (OrderID,MenuItemID, Quantity, Remark, Status) VALUES
(1, 1, 1, 'spicy','Completed'),
(2, 2, 2, 'No spice','In Progress'),
(3,3,3, 'hot', 'Pending');

select * from OrderItems

CREATE TABLE Feedback (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY, 
    CustomerID INT NOT NULL,                 
    Message NVARCHAR(MAX) NOT NULL,           
    SubmittedDate DATETIME NOT NULL DEFAULT GETDATE(), 
    FOREIGN KEY (CustomerID) REFERENCES Users(ID),
	Reply  nvarchar(255)
);
INSERT INTO Feedback (CustomerID, Message, SubmittedDate)
VALUES 
(1, 'Great food and service!', GETDATE() - 3),
(2, 'The tacos were amazing!', GETDATE() - 1),
(3, 'Please add more vegetarian options.', GETDATE());


create table Discount (
	DiscountID int identity(1,1) primary key,
	Type nvarchar(50),
	Code nvarchar(50),
	Value decimal(10,2),
	Availability int);

INSERT INTO Discount (Type, Code, Value, Availability)
VALUES 
('Percentage', 'SAVE10', 10.00, 100),
('Fixed', 'WELCOME5', 5.00, 50),
('Percentage', 'SUMMER20', 20.00, 25);


create table TopUpHistory (
	TopupID int identity(1,1) primary key,
	UserID int foreign key references Users(ID),
	Amount decimal(10,2),
	Method nvarchar(50)
)

INSERT INTO TopUpHistory (UserID, Amount, Method)
VALUES  ('1', '80', 'Cash')
INSERT INTO TopUpHistory (UserID, Amount, Method)
VALUES  ('2', '100', 'Cash')
INSERT INTO TopUpHistory (UserID, Amount, Method)
VALUES  ('3', '20', 'Cash')
INSERT INTO TopUpHistory (UserID, Amount, Method)
VALUES  ('4', '70', 'Cash')



create table RefundRequest (
	ID int identity(1,1) primary key,
	UserID int foreign key references Users(ID),
	OrderID int foreign key references Orders(OrderID),
	DateIssued datetime,
	Message nvarchar(255),
	Status nvarchar(50),
	StatusReason nvarchar(255),
)
INSERT INTO RefundRequest (UserID, OrderID, DateIssued, Message, Status, StatusReason)
VALUES 
(1, 1, GETDATE(), 'Not nice', 'Pending', 'Under review by staff'),
(2, 2, DATEADD(DAY, -3, GETDATE()), 'Wrong item delivered', 'Approved', 'Approved by manager'),
(3, 3, DATEADD(DAY, -1, GETDATE()), 'Changed my mind', 'Rejected', 'Return policy does not cover this reason');

