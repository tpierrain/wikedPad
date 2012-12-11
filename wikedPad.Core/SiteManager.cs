namespace WikedPad.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Handles basic information about the wiked! site
    /// </summary>
    public class SiteManager
    {
        private string url;

        public SiteManager(string url)
        {
            this.url = url;
            if (!File.Exists(url))
            {
                throw new InvalidOperationException("Could not find the pom.xml file for this wiked! site.");
            }
        }
    }
}
