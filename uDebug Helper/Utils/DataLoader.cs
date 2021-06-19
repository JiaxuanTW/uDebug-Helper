using System;
using System.IO;

namespace uDebug_Helper.Utils
{
    class DataLoader
    {
        public static string LoadFromAppData(string fileName)
        {
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData)
                + "\\uDebug Helper\\" + fileName;
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return null;
        }

        public static void SaveToAppData(string fileName, string data)
        {
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData) + "\\uDebug Helper";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += "\\" + fileName;
            File.WriteAllText(path, data);
        }
    }
}
