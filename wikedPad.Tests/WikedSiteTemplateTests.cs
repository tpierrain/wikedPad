namespace WikedPad.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using WikedPad.Core;

    [TestFixture]
    public class WikedSiteTemplateTests
    {
        private const string WikedTestSiteBaseUri = @"../../wikedSample";

        [Test]
        public void RetrieveAllRootMarkdownFiles()
        {
            var siteTemplate = new WikedSiteTemplate(WikedTestSiteBaseUri);
            var numberOfRootMarkdownFilesOrDirectories = 18;

            Assert.AreEqual(numberOfRootMarkdownFilesOrDirectories, siteTemplate.MarkdownFileSystemInfo.Length);

            FileSystemHelper.TraceFileSystemInfoAndSubContent(siteTemplate.MarkdownFileSystemInfo);
        }

        [Test]
        public void RetrieveAllRootAlmostPlainTextFiles()
        {
            var siteTemplate = new WikedSiteTemplate(WikedTestSiteBaseUri);
            var numberOfRootAptFilesOrDirectories = 1;

            Assert.AreEqual(numberOfRootAptFilesOrDirectories, siteTemplate.AptFileSystemInfo.Length);

            FileSystemHelper.TraceFileSystemInfoAndSubContent(siteTemplate.AptFileSystemInfo);
        }
    }
}
