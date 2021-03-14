CREATE TABLE Brand(
    BrandId INT IDENTITY PRIMARY KEY NOT NULL,
    Name varchar(50),
);

CREATE TABLE Color (
    ColorId INT IDENTITY PRIMARY KEY NOT NULL,
    Name varchar(30),
	
);
CREATE TABLE Car (
    CarId INT IDENTITY PRIMARY KEY NOT NULL,
    ModelYear int,
	BrandId int,
	ColorId int,
    DailyPrice decimal,
    Description varchar(100),
	CONSTRAINT fkBrand FOREIGN KEY(BrandId) REFERENCES Brand(BrandId),
	CONSTRAINT fkColor FOREIGN KEY(ColorId) REFERENCES Color(ColorId),
);
