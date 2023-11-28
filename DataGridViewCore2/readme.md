# About

This project is an example of moving rows up/down in a DataGridView using a list where the other DataGridView samples use a DataTable of the source for a DataGridView.

## .NET versions

- This project is net8
- The class project DapperLibrary1 is net7

## Data operations

Use [Dapper](https://www.nuget.org/packages/Dapper/2.1.24?_src=template) for all operations.

## Instructions

- Create the database via script.sql in the scripts folder
- Build/Run
- Comment out `await InitialSetup();` in `Form1_Shown` as this is only need once to populate the database or keep it for new data via [Bogus](https://www.nuget.org/packages/Bogus) NuGet package.

## Notes

- Dapper does not support `DateOnly` so a handler is used in the repository code.