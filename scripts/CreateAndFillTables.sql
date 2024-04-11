-- Tworzenie tabeli User
CREATE TABLE [User] (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL
);

-- Tworzenie tabeli Place
CREATE TABLE Place (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(200) NOT NULL
);
-- Tworzenie tabeli Export
CREATE TABLE Export (
    Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(100) NOT NULL,
    Time DATETIME,
    UserId INT NOT NULL,
	PlaceId INT NOT NULL,
    FOREIGN KEY (UserId) REFERENCES [User](Id),
	FOREIGN KEY (PlaceId) REFERENCES Place(Id)
);

DECLARE @i INT = 1;
WHILE @i <= 10
BEGIN
    INSERT INTO [User] (Name) VALUES ('U¿ytkownik ' + CAST(@i AS NVARCHAR(10)));
    SET @i = @i + 1;
END;

SET @i = 1;
WHILE @i <= 5
BEGIN
    INSERT INTO Place (Name) VALUES ('Lokal ' + CAST(@i AS NVARCHAR(10)));
    SET @i = @i + 1;
END;

SET @i = 1;
WHILE @i <= 2000
BEGIN
    DECLARE @randomPlace INT = CAST(RAND() * 5 + 1 AS INT);
	DECLARE @randomUser INT = CAST(RAND() * 10 + 1 AS INT);
    
    INSERT INTO [Export] (
		Name,
		Time,
		UserId,
		PlaceId) 
	VALUES (
	'Eksport ' + CAST(@i AS NVARCHAR(10)),
	DATEADD(HOUR, -1 * @i, GETDATE()),
	@randomUser,
	@randomPlace);

    SET @i = @i + 1;
END;