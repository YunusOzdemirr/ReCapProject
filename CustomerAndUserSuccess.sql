CREATE TABLE Users (
    Id INT IDENTITY PRIMARY KEY NOT NULL,
    FirstName varchar(30),
	LastName varchar(30),
	Email varchar(100),
	Passwordd varchar(50),
);
CREATE TABLE Customer (
    UserId INT IDENTITY PRIMARY KEY NOT NULL,
    CompanyName varchar(50),
    CustomerId int,
    CONSTRAINT fkCustomerId FOREIGN KEY(CustomerId) REFERENCES Users(Id),
);
