CREATE TABLE CarImages (
    Id INT  NOT NULL PRIMARY KEY,
    CarId INT NOT NULL,
    ImagePath varchar(255),
    Date dateTime,
    CONSTRAINT fkCarId FOREIGN KEY(CarId) REFERENCES Car(CarId),
);
