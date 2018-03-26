﻿using System;

namespace ConsoleApp1
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            _logger.LogInfo("Migration finished.");
        }
    }
}