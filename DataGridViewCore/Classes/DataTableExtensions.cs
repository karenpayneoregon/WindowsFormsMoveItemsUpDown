using System.Data;
using DataGridViewCore.Models;

namespace DataGridViewCore.Classes;
public static class DataTableExtensions
{
    public static List<RowItem> RowItems(this DataTable sender) =>
        sender.AsEnumerable()
            .Select((row, index) => new RowItem(index, row.Field<int>("ProductId"))).ToList();

    public static List<RowItem> RowItems(this DataTable sender, string columnName) =>
        sender.AsEnumerable()
            .Select((row, index) => new RowItem(index, row.Field<int>(columnName))).ToList();
}
