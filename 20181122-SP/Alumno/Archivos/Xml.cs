using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T>: IArchivos<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextWriter escritor = null;
            try
            {
                escritor = new XmlTextWriter(archivo, null);
                serializador.Serialize(escritor, datos);
            }
            catch(Exception)
            {
            }
            
        }
    }
}
