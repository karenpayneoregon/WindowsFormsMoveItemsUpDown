﻿using System.Data;
using System.Text.Json;
using DapperLibrary1.Models;

namespace DapperLibrary1.Extensions;

public static class BindingSourceExtensions
{
    /// <summary>
    /// Move row up by one, tied to a specific class
    /// </summary>
    /// <param name="sender">BindingSource</param>
    public static void MoveRowUp(this BindingSource sender)
    {

        if (!string.IsNullOrWhiteSpace(sender.Sort))
        {
            sender.Sort = "";
        }

        var newIndex = Convert.ToInt32((sender.Position == 0) ? 
            0 : 
            sender.Position - 1);

        var source = (List<Person>)sender.DataSource;
        
        Person? rowToMove = ((Person)sender.Current);


        Person? newRow = ((Person)sender.Current);
        source.RemoveAt(sender.Position);
        source.Insert(newIndex, newRow);

        sender.Position = newIndex;
        sender.ResetBindings(false);

    }
    /// <summary>
    ///  Move row up by one
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <param name="sender">BindingSource</param>
    public static void MoveRowUp<T>(this BindingSource sender)
    {

        if (!string.IsNullOrWhiteSpace(sender.Sort))
        {
            sender.Sort = "";
        }

        var newIndex = Convert.ToInt32((sender.Position == 0) ?
            0 :
            sender.Position - 1);

        var source = (List<T>)sender.DataSource;

        T? rowToMove = ((T)sender.Current);


        T? newRow = ((T)sender.Current);
        source.RemoveAt(sender.Position);
        source.Insert(newIndex, newRow);

        sender.Position = newIndex;
        sender.ResetBindings(false);

    }

    /// <summary>
    /// Move row down by one, tied to a specific type
    /// </summary>
    /// <param name="sender"></param>
    public static void MoveRowDown(this BindingSource sender)
    {

        if (!string.IsNullOrWhiteSpace(sender.Sort))
        {
            sender.Sort = "";
        }

        var upperLimit = sender.Count - 1;
        var newIndex = Convert.ToInt32((sender.Position + 1 >= upperLimit) ? 
            upperLimit : 
            sender.Position + 1);


        var source = (List<Person>)sender.DataSource;

        Person? rowToMove = ((Person)sender.Current);

        var newRow = (Person)rowToMove.Clone();
        source.RemoveAt(sender.Position);
        source.Insert(newIndex, newRow);

        sender.Position = newIndex;
        sender.ResetBindings(false);
    }

    public static void MoveRowDown<T>(this BindingSource sender)
    {

        if (!string.IsNullOrWhiteSpace(sender.Sort))
        {
            sender.Sort = "";
        }

        var upperLimit = sender.Count - 1;
        var newIndex = Convert.ToInt32((sender.Position + 1 >= upperLimit) ?
            upperLimit :
            sender.Position + 1);


        var source = (List<T>)sender.DataSource;

        T? rowToMove = ((T)sender.Current);


        T? newRow = ((T)sender.Current);
        source.RemoveAt(sender.Position);
        source.Insert(newIndex, newRow);

        sender.Position = newIndex;
        sender.ResetBindings(false);
    }

    public static void ToJsonFile(this BindingSource sender, string fileName = "people.json")
    {
        var serializerOptions = new JsonSerializerOptions { WriteIndented = true };
        var list = (List<Person>)sender.DataSource;
        File.WriteAllText(fileName, JsonSerializer.Serialize(list, serializerOptions));
    }

    public static DataTable DataTable(this BindingSource pBindingSource)
    {
        return (DataTable)pBindingSource.DataSource;
    }
    public static DataRow CurrentRow(this BindingSource pBindingSource)
    {
        return ((DataRowView)pBindingSource.Current).Row;
    }

}