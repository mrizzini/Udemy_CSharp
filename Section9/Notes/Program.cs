using System;

namespace Notes
{
    class ProgramNotes9
    {
        static void Main(string[] args)
        {

            // Files and Directories

            // in .NET we have a namespace called System. IO where all
            // the clases that work with files and directories are 
            // located

            // File, FileInfo
            // Directory, DirectoryInfo
            // Path


            // File, FileInfo
            // both provide methods for creating, copying, deleting, moving and opening of files
            // similar interfaces
            // FileInfo - provides instance methods
            // File - provides static methods

            // if we have a small number of operations that say
            // get attributes about the file, its better to access
            // the static methods of the file class
            // but every time we call a static method some security checking
            // is done by the operating system to make sure the current user has access to the file
            // will affect performance if u have a lot of operations

            // in that case, more efficent to create a filing for class and access all its instance methods
            // security checking done only once during creation of fileinfo class

            // Create()
            // Copy()
            // Delete()
            // Exists()
            // GetAttributes()
            // Move()
            // ReadAllText()

            // Directory - provides static methods
            // DirectoryInfo - provides instance methods

            // CreateDirectory()
            // Delete()
            // Exists()
            // GetCurrentDirectory()
            // GetFiles() - set filters (all files, or JPT extension files)
            // Move()
            // GetLogicalDrives() 

            // Path
            // Provides methods to work with a string that contains a file or directory information

            // GetDirectoryName()
            // GetFileName()
            // GetExtension()
            // GetTempPath()

        }
    }
}


// THISISGOINTOBETHELONGESTWORDHEREOKAY