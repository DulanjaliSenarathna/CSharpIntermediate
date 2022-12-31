using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)//inject the interface to constructor(Dependancy injection)
        {
            this._logger = logger;
        }
        public void Migrator()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            _logger.LogInfo("Migration finished at " + DateTime.Now);
           
        }
    }
}
