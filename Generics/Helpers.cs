using System;
using System.IO;
using System.Xml.Serialization;

namespace Generics
{
    public static class Helpers
    {
        public static string XmlSerializerObject<T>(this T valor)
        {
            XmlSerializer xml = new XmlSerializer(valor.GetType());
            StringWriter retorno = new StringWriter();
            xml.Serialize(retorno, valor);
            return retorno.ToString();
        }
        public static object XmlDeserializerObject(string valor, Type tipo)
        {
            XmlSerializer xml = new XmlSerializer(tipo);
            var valor_serealizado = new StringReader(valor);
            return xml.Deserialize(valor_serealizado);
        }
    }
}
