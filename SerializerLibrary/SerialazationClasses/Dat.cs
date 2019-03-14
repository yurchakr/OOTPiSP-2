using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerializerInterface;

namespace SerializerLibrary
{
    public class Dat : ISerilizable
    {
        public T Deserialize<T>(OpenFileDialog openFile, string filter) where T : class
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(openFile.FileName, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
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
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, obj);
            }
        }
    }
}
