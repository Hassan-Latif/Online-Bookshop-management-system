SELECT * FROM Books

ALTER TABLE Books ALTER COLUMN Id VARCHAR(29);

DROP TABLE Books

CREATE TABLE Books(
	Name VARCHAR(30),
	Id Varchar (20) PRIMARY KEY,
	Publisher VARCHAR(30),
	No_of_Copies VARCHAR(20),
	Genre VARCHAR(30),
	Edition VARCHAR(20),
	Price VARCHAR(20),
	Author VARCHAR(30)
)

INSERT INTO Books VALUES('The Alchemist','12','HarperCollins','300','Drama Novel','2010','400','Paulo Coelho');
INSERT INTO Books VALUES('The Pilgrimage','11','HarperCollins','200','Drama Novel','2011','300','Paulo Coelho');
INSERT INTO Books VALUES('The Zahir','14','HarperCollins','500','Drama Novel','2012','500','Paulo Coelho');
INSERT INTO Books VALUES('The Prada','10','HarperCollins','350','Drama Novel','2014','250','Paulo Coelho');
INSERT INTO Books VALUES('The Alchemist','15','HarperCollins','300','Drama Novel','2010','350','Paulo Coelho');

CREATE TABLE Members(
Name VARCHAR(30),
Email VARCHAR(30) PRIMARY KEY ,
Contact_no VARCHAR(20),
Passwordd VARCHAR(30)

)

CREATE TABLE Admin(
Name VARCHAR(30),
Email VARCHAR (30) PRIMARY KEY,
Contact VARCHAR(30),
Passwordd VARCHAR(20)
)

CREATE TABLE Cart(
Cart_Id INT PRIMARY KEY IDENTITY(1,1),
Item_Id INT,
Item_name VARCHAR(30),
item_price INT 
)


