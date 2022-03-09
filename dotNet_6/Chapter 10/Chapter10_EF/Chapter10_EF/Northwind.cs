using static System.Console;
using static EntFrame.Shared.ProjectConst;
using Microsoft.EntityFrameworkCore;

namespace EntFrame.Shared
{
    public class Northwind : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection;
            if (DbProvider == "SQLServer")
            {
                connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;" +
                             "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                             "MultiSubnetFailover=False";
            }
            else//other Db providers
            {
            }

            optionsBuilder.UseSqlServer(connection);
        }
    }
}
