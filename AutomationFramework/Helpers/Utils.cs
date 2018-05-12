using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Helpers
{
    class Utils
    {
        public static void Wait(double waitTimeSec)
        {
            App.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitTimeSec);
        }

    }
}
