namespace Paths.IO
{
    using System;
    using System.IO;

    public static class Storage
    {
        private const string EndOfCommand = "\n---------------------------------------\n";

        public static void SaveToFile(string fileName, string fileContent)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine(
                    "File {0} created.\n",
                    fileName);
            }

            fileContent = string.Format(
                fileContent
                + @"*** End of current save. ***

");

            File.AppendAllText(fileName, fileContent);

            Console.WriteLine(
                "New contents have been added and saved into the file: {0}.\n{1}",
                fileName,
                EndOfCommand);
        }

        public static void LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new ArgumentException(
                    "No file.\n{0}",
                    EndOfCommand);
            }

            string fileContent = File.ReadAllText(fileName);

            Console.WriteLine(
                "File: {0}\nContents:\n{1}\n{2}",
                fileName,
                fileContent,
                EndOfCommand);
        }

        public static void ReplaceFileContent(string fileName, string newFileContent)
        {
            if (!File.Exists(fileName))
            {
                throw new ArgumentException(
                    "No file.\n{0}",
                    EndOfCommand);
            }

            string content = newFileContent;

            content = string.Format(
                content
                + @"*** End of content-replacement save. ***

");

            File.WriteAllText(fileName, content);

            Console.WriteLine(
                "New content has replaced the contents of file {0} and file is saved.\n{1}",
                fileName,
                EndOfCommand);
        }

        public static void DeleteFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new ArgumentException(
                    "No file.\n{0}",
                    EndOfCommand);
            }

            File.Delete(fileName);

            Console.WriteLine(
                "File {0} deleted.\n{1}",
                fileName,
                EndOfCommand);
        }
    }
}
