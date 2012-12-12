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
    public class WikedSiteTemplateTests
    {
        [Test]
        public void RetrieveAllMarkdownFiles()
        {
            var workingDirUri = @"../../wikedSample";

            var siteTemplate = new WikedSiteTemplate(workingDirUri);
            
            Assert.AreEqual(17, siteTemplate.MarkdownFileSystemInfo.Length);

            // TODO: handle subdirectories
        }
    }
}
