using System;
using System.IO;

namespace Loja10790.Data
{
    internal class DataPath
    {
        public static string FilePath
        {
            get
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
                    return Path.Combine(Path.Combine(parentDirectory, "Data"), "db_store.mdf");
                }
                else
                {
                    throw new Exception("The 'Loja10790' directory was not found.");
                }
            }
        }
    }
}
