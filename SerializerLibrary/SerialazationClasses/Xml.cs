using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using SerializerInterface;

namespace SerializerLibrary
{
    public class Xml : ISerilizable
    {
        public T Deserialize<T>(OpenFileDialog archive, string filter) where T : class
        {
            Archive.Unarchive(archive, filter);

            string encrFile = Regex.Replace(archive.FileName, "zip", filter);
            string decrFile = Regex.Replace(encrFile, "_encr", "_decr");
            Encrypt.DecryptFile(encrFile, decrFile);

            OpenFileDialog openFile = Archive.InitializeOpenFile(filter.ToLower());
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(openFile.FileName, FileMode.Open))
                {
                    var formatter = new XmlSerializer(typeof(T));
                    try
                    {
                        return (T)formatter.Deserialize(fs);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return null;
        }

        public void Serialize<T>(SaveFileDialog saveFile, T obj) where T : class
        {
            using (var fs = new FileStream(saveFile.FileName, FileMode.Create))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                formatter.Serialize(fs, obj);
            }
            string encrFile = Path.GetFileNameWithoutExtension(saveFile.FileName);
            encrFile = Regex.Replace(saveFile.FileName, encrFile, encrFile + "_encr");

            Encrypt.EncryptFile(saveFile.FileName, encrFile);

            Archive.SaveArchive(encrFile, encrFile, "xml");
        }
    }
}
