#region

using OpenQA.Selenium.PhantomJS;

#endregion

namespace InvisibleAdSense.Driver
{
    public class AdSenseDriver : PhantomJSDriver,  IAdSenseDriver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdSenseDriver"/> class.
        /// </summary>
        /// <param name="service">The <see cref="T:OpenQA.Selenium.PhantomJS.PhantomJSDriverService" /> used to initialize the driver.</param>
        public AdSenseDriver(PhantomJSDriverService service) : base(service)
        {
            
        }

        /// <summary>
        ///     Goes to.
        /// </summary>
        /// <param name="url">The URL.</param>
        public void GoTo(string url)
        {
            Url = url;
            Navigate();
        }
    }
}