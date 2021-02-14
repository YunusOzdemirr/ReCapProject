CREATE TABLE Customer (
    UserId INT  NOT NULL,
    CompanyName varchar(50),
    CONSTRAINT fkCustomerId FOREIGN KEY(UserId) REFERENCES Users(Id),
);
CREATE TABLE Users (
    Id INT IDENTITY PRIMARY KEY NOT NULL,
    FirstName varchar(30),
	LastName varchar(30),
	Email varchar(100),
	Passwordd varchar(50),
);