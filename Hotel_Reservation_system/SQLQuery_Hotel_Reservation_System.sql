





CREATE TABLE Client_Table
(
	Client_ID INT IDENTITY(1,1) NOT NULL,
	Client_Firstname VARCHAR(150) NOT NULL,
	Client_Lastname VARCHAR(150) NOT NULL,
	Client_PhoneNo VARCHAR(15) NOT NULL,
	CONSTRAINT Client_Table_Client_ID_PK PRIMARY KEY (Client_ID) 
);

INSERT INTO Client_Table VALUES
('John', 'Doe', '0722345678');


CREATE TABLE Room_Table
(
	Room_Number INT IDENTITY (1,1) NOT NULL,
	Room_Type VARCHAR (10) NOT NULL,
	Room_Phone VARCHAR (15) UNIQUE NOT NULL,
	Room_Free VARCHAR (3) NOT NULL,
	CONSTRAINT Room_Table_Room_Number_PK PRIMARY KEY (Room_Number) 
);
INSERT INTO Room_Table VALUES
('Single', '0723456789', 'Yes'),
('Family', '0723456780', 'No');


CREATE TABLE Reservation_Table (
    Reservation_ID INT IDENTITY(1,1) PRIMARY KEY,
    Client_Name VARCHAR(255) NOT NULL,
    Room_Number VARCHAR(50) NOT NULL,
    Room_Type VARCHAR(100) NOT NULL,
    Room_Reservation VARCHAR(255) NOT NULL
);


INSERT INTO Reservation_Table VALUES
('Grace', 'Single', '431', 'Yes');


SELECT * FROM User_Table;
