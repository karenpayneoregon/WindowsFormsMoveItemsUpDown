using System;
using ExceptionsLibrary;

namespace DataConnections
{
    public class BaseSqlServerConnection : BaseExceptionsHandler
    {
        /// <summary>
        /// This points to your database server
        /// </summary>
        protected string DatabaseServer = "KARENS-PC";
        /// <summary>
        /// Name of database containing required tables
        /// </summary>
        protected string DefaultCatalog = "";
        public string ConnectionString => $"Data Source={DatabaseServer};Initial Catalog={DefaultCatalog};Integrated Security=True";
        /// <summary>
        /// Determines if running on Karen Payne's computer
        /// </summary>
        public bool IsKarenMachine => Environment.UserName == "Karens";
        /// <summary>
        /// Determine if server name has been set from the default on Karen Payne's computer
        /// </summary>
        public bool IsKarensDatabaseServer => DatabaseServer == "KARENS-PC";
        /// <summary>
        /// If a developer other than the author runs this code without changing
        /// the database server name an exception is thrown. When an exception is
        /// thrown means you who are reading this must change the database 
        /// server name to your server name or .\SQLEXPRESS etc.
        /// </summary>
        public BaseSqlServerConnection()
        {
            if (!IsKarenMachine && IsKarensDatabaseServer)
            {
                mHasException = true;
                throw new Exception($"Please change the DatabaseServer from '{DatabaseServer}' to your server name!");
            }
        }

    }
}
