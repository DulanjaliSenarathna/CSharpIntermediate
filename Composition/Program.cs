using System;

namespace Composition
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger()); //one way to pass the logger object to constructor

            //another way to pass the logger object to constructor
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
