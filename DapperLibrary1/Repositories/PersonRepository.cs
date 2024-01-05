﻿using System.Data;
using System.Transactions;
using Dapper;
using DapperLibrary1.Classes;
using DapperLibrary1.Handlers;
using DapperLibrary1.Interfaces;
using DapperLibrary1.Models;
using Microsoft.Data.SqlClient;
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.

namespace DapperLibrary1.Repositories;

public class PersonRepository : IBaseRepository
{
    private IDbConnection cn;
    /// <summary>
    /// Setup for DateOnly handler and for creating a connection
    /// </summary>
    public PersonRepository()
    {
        cn = new SqlConnection(ConnectionString());
        SqlMapper.AddTypeHandler(new DapperSqlDateOnlyTypeHandler());
    }

    /// <summary>
    /// Get all records in the Person table synchronously
    /// </summary>
    public List<Person> GetAll() 
        => cn.Query<Person>(SqlStatements.ReadPeople).ToList();

    /// <summary>
    /// Get all records in the Person table asynchronously
    /// </summary>
    public async Task<List<Person>> GetAllAsync() 
        => (List<Person>)await cn.QueryAsync<Person>(SqlStatements.ReadPeople);

    /// <summary>
    /// Get a single person by id
    /// </summary>
    /// <param name="id">Existing primary key</param>
    /// <returns>A single person or null if not located</returns>
    public async Task<Person> Get(int id) 
        => (await cn.QueryFirstOrDefaultAsync<Person>(SqlStatements.Get, new { Id = id }))!;

    /// <summary>
    /// Perform a WHERE IN for identifiers
    /// </summary>
    /// <param name="ids">one or more identifiers</param>
    /// <returns>list of people</returns>
    public async Task<List<Person>> WhereIn(int[] ids)
    {
        IEnumerable<Person> result = await cn.QueryAsync<Person>(
            SqlStatements.WhereInClause, new
            {
                Ids = ids
            });

        return result.ToList();
    }

    /// <summary>
    /// Update an existing person
    /// </summary>
    /// <param name="person"></param>
    /// <returns>success and on failure an exception</returns>
    public async Task<(bool, Exception ex)> Update(Person person)
    {
        try
        {
            var affected = await cn.ExecuteAsync(SqlStatements.UpdatePerson, new
            {
                person.FirstName,
                person.LastName,
                person.BirthDate,
                person.Id
            });

            return (affected == 1, null);

        }
        catch (Exception localException)
        {
            return (false, localException);
        }
    }

    /// <summary>
    /// Add a single person
    /// </summary>
    /// <param name="person"></param>
    public async Task Add(Person person)
    {
        person.Id = await cn.QueryFirstAsync<int>(SqlStatements.InsertPeople, person);
    }
    /// <summary>
    /// Add list of person to the person table
    /// </summary>
    /// <param name="list">List of people</param>
    /// <returns>success and on failure an exception</returns>
    /// <remarks>
    /// Not great performance wise, for inserting a great deal of records see
    /// https://www.learndapper.com/bulk-operations/bulk-insert
    /// which for one developer is $999 per year.
    ///
    /// See also <seealso cref="AddRangeSlim"/>
    /// </remarks>
    public async Task<(bool, Exception ex)> AddRange(List<Person> list)
    {

        using TransactionScope transScope = new(TransactionScopeAsyncFlowOption.Enabled);

        try
        {
            foreach (var person in list)
            {
                await Add(person);
            }

            transScope.Complete();
            
            return (list.All(p => p.Id > 0), null);

        }
        catch (Exception localException)
        {
            return (false, localException);
        }
    }

    /// <summary>
    /// Slim down version of <seealso cref="AddRange"/>
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public async Task AddRangeSlim(List<Person> list)
    {
        await cn.ExecuteAsync(SqlStatements.InsertPeople, list);
    }
    /// <summary>
    /// Remove a single record
    /// </summary>
    /// <param name="person">Existing person</param>
    /// <returns>success of operation</returns>
    public async Task<bool> Remove(Person person)
    {
        var affected = await cn.ExecuteAsync(SqlStatements.RemovePerson, new { person.Id });
        return affected == 1;
    }

    #region For code samples

    public void Reset()
    {
        using SqlConnection cn = new(ConnectionString());

        cn.Execute("DELETE FROM dbo.Person");

        cn.Execute("DBCC CHECKIDENT (Person, RESEED, 0)");
    }

    public async Task<int> Count()
    {
        return await cn.ExecuteScalarAsync<int>(SqlStatements.CountOfPeople);
    }

    #endregion
}
