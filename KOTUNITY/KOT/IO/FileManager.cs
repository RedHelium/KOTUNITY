using System.Collections.Generic;
using System.IO;

namespace KOT.IO
{
    public static class FileManager
    {
        public static void CreateFile(string path)
        {

        }

        public static void Write(string path, FileMode mode = FileMode.Open)
        {

        }

        public static void WriteCollection<T>(ICollection<T> collection, string path, FileMode mode = FileMode.Open)
        {
            using FileStream fileStream = new FileStream(path, mode);
            using StreamWriter writer = new StreamWriter(fileStream);

            foreach (var item in collection)
            {
                writer.WriteLine(item);
            }
        }

        public static string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
