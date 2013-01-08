namespace WikedPad.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// wiked! site template. Contains Markdown, APT, and Resource files.
    /// </summary>
    public class WikedSiteTemplate
    {
        private const string RootSiteTemplateDirectory = @"src\site\";
        private string workingDirRootUri;

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

            this.MarkdownFileSystemInfo = SetupFileSystemInfo(this.workingDirRootUri, "markdown");
            this.AptFileSystemInfo = SetupFileSystemInfo(this.workingDirRootUri, "apt");
        }

        /// <summary>
        /// Gets the markdown files and related directories of this wiked! site template.
        /// </summary>
        /// <value>
        /// The markdown files of this wiked! site template and related directories.
        /// </value>
        public FileSystemInfo[] MarkdownFileSystemInfo { get; private set; }

        /// <summary>
        /// Gets the APT files and related directories of this wiked! site template.
        /// </summary>
        /// <value>
        /// The APT files of this wiked! site template and related directories.
        /// </value>
        public FileSystemInfo[] AptFileSystemInfo { get; private set; }

        private static FileSystemInfo[] SetupFileSystemInfo(string workingDirRootUri, string specificFileTypedirectoryName)
        {
            var specificFileTypeRootDirectory = Path.Combine(workingDirRootUri, RootSiteTemplateDirectory + specificFileTypedirectoryName);
            return new DirectoryInfo(specificFileTypeRootDirectory).GetFileSystemInfos();
        }
    }
}
