using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
   public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing "); 
        }
    }
}
