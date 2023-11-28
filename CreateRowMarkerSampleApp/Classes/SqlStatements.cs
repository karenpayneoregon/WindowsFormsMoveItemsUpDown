namespace CreateRowMarkerSampleApp.Classes;

public class SqlStatements
{
    /// <summary>
    /// Add column RowPosition to OrderDetails, if exists
    /// at time method is called RowPosition is dropped than added
    /// back in.
    /// </summary>
    public static string OrderDetailsConfiguration =>
        """
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
        """;
    /// <summary>
    /// Populate each row from 1 to last record
    /// </summary>
    public static string OrderDetailsPopulateRowPosition =>
        """
        UPDATE dbo.OrderDetails
        SET @MaxSurrogateKey=RowPosition = @MaxSurrogateKey + 1
        WHERE RowPosition IS NULL;
        """;
}