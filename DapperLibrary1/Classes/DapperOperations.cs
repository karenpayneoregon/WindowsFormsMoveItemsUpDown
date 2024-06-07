using Microsoft.Data.SqlClient;
using Dapper;

namespace DapperLibrary1.Classes;

/// <summary>
/// Not used, written for AI article
/// </summary>
internal class DapperOperations
{

    private string ConnectionString = "Data Source=.;Initial Catalog=NorthWind2020;Integrated Security=True";


    public async Task<List<int>> CategoryIdentifiersAsync()
    {
        await using SqlConnection cn = new() { ConnectionString = ConnectionString };
        return (await cn.QueryAsync<int>("""
                                        
                                         SELECT DISTINCT 
                                            CategoryID 
                                         FROM 
                                            dbo.Categories
                                         
                                         """)).AsList();
    }
}
