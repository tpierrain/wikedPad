namespace WikedPad.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// wiked! site template. Contains Markdown and Resource files.
    /// </summary>
    public class WikedSiteTemplate
    {
        private string workingDirRootUri;
        private string markdownRootDirectory;

        /// <summary>
        /// Initializes a new instance of the <see cref="WikedSiteTemplate" /> class.
        /// </summary>
        /// <param name="workingDirectoryRootUri">The URI of the working directory root.</param>
        /// <exception cref="System.InvalidOperationException">Could not find the pom.xml file for this wiked! site.</exception>
        public WikedSiteTemplate(string workingDirectoryRootUri)
        {
            this.workingDirRootUri = workingDirectoryRootUri;
            if (!Directory.Exists(workingDirectoryRootUri))
            {
                throw new InvalidOperationException("Could not find the pom.xml file for this wiked! site.");
            }

            this.markdownRootDirectory = Path.Combine(this.workingDirRootUri, @"src\site\markdown");
            DirectoryInfo directoryInfo = new DirectoryInfo(this.markdownRootDirectory);
            this.MarkdownFileSystemInfo = directoryInfo.GetFileSystemInfos();
        }

        /// <summary>
        /// Gets the markdown files of this wiked! site template.
        /// </summary>
        /// <value>
        /// The markdown files of this wiked! site template.
        /// </value>
        public FileSystemInfo[] MarkdownFileSystemInfo { get; private set; }
    }
}
