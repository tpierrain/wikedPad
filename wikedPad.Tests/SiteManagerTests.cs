namespace WikedPad.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using WikedPad.Core;

    [TestFixture]
    public class SiteManagerTests
    {
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThowInvalidOperationExceptionIfPomIsNotFound()
        {
            var url = @"../../wikedSample";

            var siteManager = new SiteManager(url);
        }
    }
}
