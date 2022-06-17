using System;

namespace exercise_31
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigartor = new DbMigrator(new Logger());
            var installer = new Installer(new Logger());

            dbMigartor.Migrate();
            installer.Intsall();

        }
    }
}
