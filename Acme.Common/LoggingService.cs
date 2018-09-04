using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public static class LoggingService
    {
        #region Methods

        public static void WriteToFile(List<ILoggable> changedItems)
        {
            foreach (var item in changedItems)
            {
                Console.WriteLine(item.Log());
            }
        }

        #endregion
    }
}
