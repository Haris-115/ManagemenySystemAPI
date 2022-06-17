using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_31
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("We are migrating db");
        }
    }
}
