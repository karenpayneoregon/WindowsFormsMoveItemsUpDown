While working on this article, figured my NorthWind2022, NorthWind2023 and NorthWind2024 could use the ability to remember row positions so here is one example for the Products table.

```sql
IF EXISTS
(
    SELECT *
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'Products'
          AND COLUMN_NAME = 'RowPosition'
)
BEGIN
    ALTER TABLE dbo.Products DROP COLUMN RowPosition;
END;

ALTER TABLE dbo.Products ADD [RowPosition] [INT] NULL;

DECLARE @MaxSurrogateKey AS INT = 0;
UPDATE dbo.Products
SET @MaxSurrogateKey=RowPosition = @MaxSurrogateKey + 1
WHERE RowPosition IS NULL;
```