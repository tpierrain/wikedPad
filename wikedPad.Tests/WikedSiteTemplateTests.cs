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
            const int NumberOfRootMarkdownFilesOrDirectories = 18;

            Assert.AreEqual(NumberOfRootMarkdownFilesOrDirectories, siteTemplate.MarkdownFileSystemInfo.Length);

            FileSystemHelper.TraceFileSystemInfoAndSubContent(siteTemplate.MarkdownFileSystemInfo);
        }

        [Test]
        public void RetrieveAllRootAlmostPlainTextFiles()
        {
            var siteTemplate = new WikedSiteTemplate(WikedTestSiteBaseUri);
            const int NumberOfRootAptFilesOrDirectories = 1;

            Assert.AreEqual(NumberOfRootAptFilesOrDirectories, siteTemplate.AptFileSystemInfo.Length);

            FileSystemHelper.TraceFileSystemInfoAndSubContent(siteTemplate.AptFileSystemInfo);
        }
    }
}
