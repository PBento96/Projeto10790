using System.IO;

namespace Loja10790.Data
{
    internal class DataPath
    {
        public static string FilePath
        {
            get
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = Path.Combine(currentDirectory, "Data", "db_store.mdf");

                return filePath;
            }
        }
    }
}
