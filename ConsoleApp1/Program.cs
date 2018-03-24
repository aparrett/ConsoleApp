using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var dbmigrator = new DbMigrator(logger);
            var installer = new Installer(logger);

            dbmigrator.Migrate();
            installer.Install();

        }
    }
}
