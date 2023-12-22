using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CreateRowMarkerSampleApp.Classes;

public class Operations
{
    private readonly IDbConnection _cn = 
        new SqlConnection(DataConnections.Instance.MainConnection);

    public async Task ConfigureOrderDetailsForRowPosition()
    {
        await _cn.ExecuteAsync(SqlStatements.OrderDetailsConfiguration);
        await _cn.ExecuteAsync(SqlStatements.OrderDetailsPopulateRowPosition,
            new { MaxSurrogateKey = 0 });
    }
}