Drop table Car
Drop table Color
Drop table Brand


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






INSERT INTO Brand VALUES('Fiat');
INSERT INTO Brand VALUES('Mercedes');
INSERT INTO Brand VALUES('Volvo');
INSERT INTO Brand VALUES('Audi');
INSERT INTO Brand VALUES('Ford');

INSERT INTO Color VALUES('Mavi');
INSERT INTO Color VALUES('Sarı');
INSERT INTO Color VALUES('Yeşil');
INSERT INTO Color VALUES('Kırmızı');
INSERT INTO Color VALUES('Beyaz');

INSERT INTO Car VALUES(2010,1,1,500,'Hızlı araç');
INSERT INTO Car VALUES(2011,1,1,600,'Yavaş araç');
INSERT INTO Car VALUES(2012,2,3,700,'Lüks araç');
INSERT INTO Car VALUES(2013,2,3,800,'Ucuz araç');
INSERT INTO Car VALUES(2014,3,2,900,'Pahalı araç');
INSERT INTO Car VALUES(2015,3,2,1000,'Benzinli araç');
INSERT INTO Car VALUES(2016,4,5,1200,'Dizel araç');
INSERT INTO Car VALUES(2017,4,4,1400,'Hızlı ve Konforlu araç');
INSERT INTO Car VALUES(2018,5,4,1500,'Ekstra Lüks araç');