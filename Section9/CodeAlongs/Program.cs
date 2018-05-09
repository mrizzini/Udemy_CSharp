using System;
using System.IO;

namespace CodeAlongs
{
    class ProgramCodeAlongs9
    {
        static void Main(string[] args)
        {


            // FILE
            // provides static methods

            // COPY()
            // 2 parameters - source file, and destination. destination cant be a directory or existing file
            // File.Copy("c:\\temp\\myfile.jpg", "d:\\temp\\myfile.jpg");
            // OR USE VERBATIM STRING
            // and can add a bool to allow overwrite
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            
            // DELETE()
            // takes a path
            var path = @"c:\somefile.jpg";
            File.Delete(path);

            // EXISTS()
            if (File.Exists(path))
            {
                // run code
            }

            // READALLTEXT()
            // returns string
            var content = File.ReadAllText(path);


            // FILE INFO
            // provides instance methods

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete(); // no parameters

            // Exists is a property, not a method
            if(fileInfo.Exists)
            {
                // run code
            }

            // FileInfo does not have a read all




            // DIRECTORY
            // provides static methods

            // CreateDirectory()
            // use verbatim string. takes a path 
            Directory.CreateDirectory(@"c:\temp\folder1");

            // GetFiles()
            // the below returns all files in its directory and subdirectories. returns a string array
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                System.Console.WriteLine(file);
            }

            // GetDirectories()
            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                System.Console.WriteLine(directory);
            }

            // Exits()
            Directory.Exists("..."); // takes a path
            

            // DIRECTORY INFO
            // provides instance methods

            var directoryInfo = new DirectoryInfo("..."); // takes path

            // to get all files or all directorys inside this object
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();


            // PATH
            // we don't have to do string processing ourself

           var path1 = @"C:\Projects\CSharpFundamentals\HelloWord\HelloWorld.sln";

           // if we want to only extract the extension we can use path

           // GetExtension()
           // static method. takes path
           var extension = Path.GetExtension(path1);

           // can get the file name too
           var fileName = Path.GetFileName(path);

           // can get file name without extension

           var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path1);

           // get directory name
           var directoryName = Path.GetDirectoryName(path1);


        }
    }
}
