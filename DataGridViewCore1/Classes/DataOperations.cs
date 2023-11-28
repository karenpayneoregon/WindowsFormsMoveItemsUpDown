using System.Data;
using Newtonsoft.Json;


namespace DataGridViewCore1.Classes;
internal class DataOperations
{
    /// <summary>
    /// Use Bogus to create some records
    /// </summary>
    /// <returns></returns>
    public static DataTable Load()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add(new DataColumn()
            { ColumnName = "Id", DataType = typeof(int), 
                AutoIncrement = true,
                AutoIncrementSeed = 1, 
                ColumnMapping = MappingType.Hidden});

        dt.Columns.Add(new DataColumn() { ColumnName = "FirstName", DataType = typeof(string) });
        dt.Columns.Add(new DataColumn() { ColumnName = "LastName", DataType = typeof(string) });
        
        var data = BogusOperations.People();

        foreach (var human in data)
        {
            dt.Rows.Add(null, human.FirstName, human.LastName);
        }

        return dt;
    }
    /// <summary>
    /// Dump DataTable to json
    /// </summary>
    /// <param name="table"></param>
    /// <returns>json data formatted</returns>
    public static string DataTableToJson(DataTable table)
    {
        table.AcceptChanges();
        return JsonConvert.SerializeObject(table, Formatting.Indented);
    }
}
