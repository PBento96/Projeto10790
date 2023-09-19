using System;
using System.IO;

namespace Loja10790.Data
{
    internal class DataPath
    {
        private static string FindPath(string fileName)
        {
            var parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.FullName;

            while (parentDirectory != null)
            {
                if (Directory.GetParent(parentDirectory)?.Name == "Loja10790")
                {
                    parentDirectory = Directory.GetParent(parentDirectory)?.FullName;
                    break;
                }

                parentDirectory = Directory.GetParent(parentDirectory)?.FullName;
            }

            if (parentDirectory != null)
            {
                return Path.Combine(Path.Combine(parentDirectory, "Data"), fileName);
            }
            else
            {
                throw new Exception("The 'Loja10790' directory was not found.");
            }
        }

        public static string DatabasePath
        {
            get
            {
                return FindPath("db_store.mdf");
            }
        }

        public static string JsonPath
        {
            get
            {
                return FindPath("saveduser.json");
            }
        }
    }
}
