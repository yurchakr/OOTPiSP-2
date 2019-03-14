using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerializerInterface;
using System.Runtime.Serialization.Json;

namespace SerializerLibrary
{
    public class Json : ISerilizable
    {
        public T Deserialize<T>(OpenFileDialog openFile, string filter) where T : class
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(openFile.FileName, FileMode.Open))
                {
                    var formatter = new DataContractJsonSerializer(typeof(T));
                    try
                    {
                        return (T)formatter.ReadObject(fs);
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
                var formatter = new DataContractJsonSerializer(typeof(T));
                formatter.WriteObject(fs, obj);
            }
        }
    }
}
