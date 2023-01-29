using System;
using SqlUtilities;

namespace ConsoleApp1
{
    /// <summary>
    /// This code took a SQL-Server database table without a 
    /// row position field, added the field via 
    /// SQL-Server Management Studio, ran this code to set
    /// the row position field per category.
    /// 
    /// Secondary usage is to reset the row position marker
    /// field after tinkering with the code samples.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var ops = new RowPositionWorker();

            var (success, exception) = ops.RigSuppliersTable();

            if (success)
            {
                Console.WriteLine("Supplier table successfully has RowPosition");
            }
            else
            {
                Console.WriteLine($"{exception.Message}");
            }

            Console.ReadLine();

        }
        /// <summary>
        /// Consider this a reset to how the code sample was provided
        /// </summary>
        static void RigCategoryProducts()
        {
            var ops = new RowPositionWorker();

            var catIdentifiers = ops.CategoryIdentifiers();
            foreach (var id in catIdentifiers)
            {
                ops.ProductTable(id);
                Console.WriteLine(id);
            }
        }
    }
}
