using System;
using System.Reflection;

namespace DapperLibrary1.Extensions;
public static class ListExtensions
{
    public static List<T> ReorderPositionMarker<T>(this List<T> sender)
    {
        if (!typeof(T).GetProperties().Select(x => x.Name).Contains("RowPosition")) return sender;
        int indexer = 1;
        for (int index = 0; index < sender.Count; index++)
        {
            PropertyInfo propertyInfo = sender[index]!.GetType().GetProperty("RowPosition")!;
            propertyInfo.SetValue(sender[index], Convert.ChangeType(indexer, propertyInfo.PropertyType), null);
            indexer += 1;
        }

        return sender;

    }

}
