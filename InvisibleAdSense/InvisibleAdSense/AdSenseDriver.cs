using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.PhantomJS;

namespace InvisibleAdSense
{
    public class AdSenseDriver : IAdSenseDriver
    {
        private PhantomJSDriver TheDriver { get; set; }

        public AdSenseDriver(PhantomJSDriver aDriver)
        {
            TheDriver = aDriver;
        }
    }
}
