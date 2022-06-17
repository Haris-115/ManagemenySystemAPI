using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_31
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Intsall()
        {
            _logger.Log("We have successfully installed");
        }
    }
}
