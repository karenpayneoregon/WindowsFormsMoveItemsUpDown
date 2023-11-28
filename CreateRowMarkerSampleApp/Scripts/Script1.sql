--- 

IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'OrderDetails'
            AND COLUMN_NAME = 'RowPosition'
)
BEGIN
    ALTER TABLE dbo.OrderDetails DROP COLUMN RowPosition;
END;

ALTER TABLE dbo.OrderDetails ADD RowPosition INT NULL;

DECLARE @MaxSurrogateKey INT = 0;

UPDATE dbo.OrderDetails
SET @MaxSurrogateKey=RowPosition = @MaxSurrogateKey + 1
WHERE RowPosition IS NULL;
