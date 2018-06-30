/*
	It's a good practice to write your SQL statements outside of code, test them 
	for desired results then use them in code.
*/

SELECT TOP 1 c.Id FROM dbo.Categories AS c ORDER BY NEWID();


DECLARE @ArtistIdentifier INT = 1;
DECLARE @AlbumIdentifier INT = 2;

SELECT  Artist.id ,
        Songs.Name AS Song ,
        Albums.id AS AlbumId ,
        Songs.id AS SongId
FROM    Artist
        INNER JOIN Albums ON Artist.id = Albums.ArtistId
        INNER JOIN Songs ON Albums.id = Songs.AlbumId
WHERE   ( Albums.id = @AlbumIdentifier )
        AND ( Artist.id = @ArtistIdentifier );


SELECT * FROM dbo.Products AS p WHERE p.CategoryID = 1 ORDER BY p.RowPosition

SELECT ORDINAL_POSITION,COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'Customers'

-- FormExample database

DECLARE @MaxSurrogateKey INT = -1;

UPDATE  IncrementDemo
SET     @MaxSurrogateKey = RowPosition = @MaxSurrogateKey + 1
WHERE   RowPosition IS NULL; 

SELECT  id ,
        FirstName ,
        LastName ,
        RowPosition
FROM    dbo.IncrementDemo;

--- For setting up Suppliers table

IF EXISTS 
(
    SELECT * 
    FROM INFORMATION_SCHEMA.COLUMNS 
    WHERE table_name = 'Suppliers' 
    AND column_name = 'RowPosition'
)
BEGIN
    ALTER TABLE Suppliers DROP COLUMN RowPosition
END

ALTER TABLE OrderingRows.dbo.Suppliers ADD [RowPosition] [INT] NULL

DECLARE @MaxSurrogateKey INT = 0;

UPDATE  dbo.Suppliers
SET     @MaxSurrogateKey = RowPosition = @MaxSurrogateKey + 1
WHERE   RowPosition IS NULL; 
SELECT * FROM Suppliers

