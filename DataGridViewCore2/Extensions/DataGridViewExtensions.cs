using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DataGridViewCore2.Extensions;

/// <summary>
/// Methods to move current row up/down
/// </summary>
public static class DataGridViewExtensions
{
    /// <summary>
    /// Set each column width to the widest data in a column
    /// </summary>
    /// <param name="source"></param>
    /// <param name="sizable"></param>
    [DebuggerStepThrough]
    public static void ExpandColumns(this DataGridView source, bool sizable = true)
    {
        foreach (DataGridViewColumn col in source.Columns)
        {
            if (col.ValueType.Name != "ICollection`1")
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        if (!sizable) return;

        for (int index = 0; index <= source.Columns.Count - 1; index++)
        {
            int columnWidth = source.Columns[index].Width;

            source.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Set Width to calculated AutoSize value:
            source.Columns[index].Width = columnWidth;
        }
    }
    /// <summary>
    /// Split on uppercase letters
    /// </summary>
    /// <param name="source"></param>
    [DebuggerStepThrough]
    public static void FixHeaders(this DataGridView source)
    {

        for (int index = 0; index < source.Columns.Count; index++)
        {
            source.Columns[index].HeaderText = SplitCamelCase(source.Columns[index].HeaderText);
        }
    }

    [DebuggerStepThrough]
    public static string SplitCamelCase(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        Span<char> result = stackalloc char[input.Length * 2];
        var resultIndex = 0;

        for (var index = 0; index < input.Length; index++)
        {
            var currentChar = input[index];

            if (index > 0 && char.IsUpper(currentChar))
            {
                result[resultIndex++] = ' ';
            }

            result[resultIndex++] = currentChar;
        }

        return result[..resultIndex].ToString();
    }

    /// <summary>
    /// Disable all columns sorting
    /// </summary>
    /// <param name="source"></param>
    [DebuggerStepThrough]
    public static void DisableSorting(this DataGridView source)
    {
        source.Columns
            .Cast<DataGridViewColumn>()
            .ToList()
            .ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
    }
    [DebuggerStepThrough]
    public static void EnableSorting(this DataGridView source)
    {
        source.Columns
            .Cast<DataGridViewColumn>()
            .ToList()
            .ForEach(f => f.SortMode = DataGridViewColumnSortMode.Automatic);
    }
}