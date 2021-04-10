Drop table Car
Drop table Color
Drop table Brand


CREATE TABLE Brands(
    BrandId INT IDENTITY PRIMARY KEY NOT NULL,
    Name varchar(50),
);

CREATE TABLE Colors (
    ColorId INT IDENTITY PRIMARY KEY NOT NULL,
    Name varchar(30),

);
CREATE TABLE Cars (
    CarId INT IDENTITY PRIMARY KEY NOT NULL,
    ModelYear int,
	BrandId int,
	ColorId int,
    DailyPrice decimal,
    Description varchar(100),
	CONSTRAINT fkBrand FOREIGN KEY(BrandId) REFERENCES Brand(BrandId),
	CONSTRAINT fkColor FOREIGN KEY(ColorId) REFERENCES Color(ColorId),
);


INSERT INTO Brands VALUES('Fiat');
INSERT INTO Brands VALUES('Mercedes');
INSERT INTO Brands VALUES('Volvo');
INSERT INTO Brands VALUES('Audi');
INSERT INTO Brands VALUES('Ford');

INSERT INTO Colors VALUES('Mavi');
INSERT INTO Colors VALUES('Sarı');
INSERT INTO Colors VALUES('Yeşil');
INSERT INTO Colors VALUES('Kırmızı');
INSERT INTO Colors VALUES('Beyaz');

INSERT INTO Cars VALUES(2010,1,1,500,'Hızlı araç');
INSERT INTO Cars VALUES(2011,1,1,600,'Yavaş araç');
INSERT INTO Cars VALUES(2012,2,3,700,'Lüks araç');
INSERT INTO Cars VALUES(2013,2,3,800,'Ucuz araç');
INSERT INTO Cars VALUES(2014,3,2,900,'Pahalı araç');
INSERT INTO Cars VALUES(2015,3,2,1000,'Benzinli araç');
INSERT INTO Cars VALUES(2016,4,5,1200,'Dizel araç');
INSERT INTO Cars VALUES(2017,4,4,1400,'Hızlı ve Konforlu araç');
INSERT INTO Cars VALUES(2018,5,4,1500,'Ekstra Lüks araç');