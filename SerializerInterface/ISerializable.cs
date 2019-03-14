using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializerInterface
{
    public interface ISerilizable
    {
        void Serialize<T>(SaveFileDialog saveFile, T obj) where T : class;
        T Deserialize<T>(OpenFileDialog openFile, string filter) where T : class;
    }
}
