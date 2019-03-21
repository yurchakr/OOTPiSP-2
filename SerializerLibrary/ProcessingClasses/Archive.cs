using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace SerializerLibrary
{
    public static class Archive
    {
        public static void SaveArchive(string fileName, string safeFileName, string filter)
        {
            string zipFileName = Regex.Replace(fileName, filter, "zip");
            using (var fs = new FileStream(zipFileName, FileMode.Create))
            using (var archive = new ZipArchive(fs, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(fileName, safeFileName);
            }
            File.Delete(fileName);
        }
        public static OpenFileDialog InitializeOpenFile(string filter)
        {
            var file = new OpenFileDialog();
            file.Filter = $"{filter} |*.{filter}";
            file.AddExtension = true;
            file.Title = "Open file";
            return file;
        }
        public static void Unarchive(OpenFileDialog archive, string filter)
        {
            try
            {
                using (ZipArchive zip = ZipFile.Open(archive.FileName, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in zip.Entries)
                        if (entry.FullName.EndsWith($".{filter}", StringComparison.OrdinalIgnoreCase))
                        {
                            string path = archive.FileName;
                            path = (path.Replace(archive.SafeFileName, ""));
                            path = path.Remove(path.Length - 1, 1) + $"\\{entry.Name}";
                            entry.ExtractToFile(path);
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
