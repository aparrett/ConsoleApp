using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var dbMigrator2 = new DbMigrator(new FileLogger("C:\\Log\\log.txt"));
            dbMigrator2.Migrate();


        }
    }
}
