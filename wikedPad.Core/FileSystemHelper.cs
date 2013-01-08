namespace WikedPad.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Helper class related to the File System.
    /// </summary>
    public static class FileSystemHelper
    {
        /// <summary>
        /// Traces the content of a file system info array, including its sub content.
        /// </summary>
        /// <param name="fileSystemInfos">The file system info.</param>
        public static void TraceFileSystemInfoAndSubContent(IEnumerable<FileSystemInfo> fileSystemInfos)
        {
            foreach (var fileSystemInfo in fileSystemInfos)
            {
                var isADirectory = Directory.Exists(fileSystemInfo.FullName);

                Console.Out.WriteLine("Name: {0}. Is a directory? {1}.", fileSystemInfo.Name, isADirectory);
                if (isADirectory)
                {
                    TraceFileSystemInfoAndSubContent(new DirectoryInfo(fileSystemInfo.FullName).GetFileSystemInfos());
                }
            }
        }
    }
}
