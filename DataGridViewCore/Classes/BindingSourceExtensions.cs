using System.Data;

namespace DataGridViewCore.Classes;

public static class BindingSourceExtensions
{
    public static DataTable DataTable(this BindingSource pBindingSource) => (DataTable)pBindingSource.DataSource;
}