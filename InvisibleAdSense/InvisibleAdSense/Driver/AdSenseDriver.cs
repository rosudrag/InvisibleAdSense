#region

using OpenQA.Selenium.PhantomJS;

#endregion

namespace InvisibleAdSense.Driver
{
    public class AdSenseDriver : IAdSenseDriver
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AdSenseDriver" /> class.
        /// </summary>
        /// <param name="aDriver">A driver.</param>
        public AdSenseDriver(PhantomJSDriver aDriver)
        {
            TheDriver = aDriver;
        }

        /// <summary>
        ///     Gets or sets the driver.
        /// </summary>
        /// <value>
        ///     The driver.
        /// </value>
        private PhantomJSDriver TheDriver { get; set; }

        /// <summary>
        ///     Closes this instance.
        /// </summary>
        public void Close()
        {
            TheDriver.Close();
            TheDriver.Dispose();
        }

        /// <summary>
        ///     Goes to.
        /// </summary>
        /// <param name="url">The URL.</param>
        public void GoTo(string url)
        {
            TheDriver.Url = url;
            TheDriver.Navigate();
        }
    }
}