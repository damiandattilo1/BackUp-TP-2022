using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace Biblioteca
{
    public class Lapiz :Util, ISerializa, IDeserializa
    {
        private eColor color;
        private eTrazo trazo;

        public eColor Color
        {
            get { return color; }
            set { color = value; }
        }

        public eTrazo Trazo
        {
            get { return trazo; }
            set { trazo = value; }
        }

        public Lapiz() : base()
        {

        }


        public Lapiz(string marca, int precio, eColor color, eTrazo trazo) :base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {base.Marca}");
            sb.AppendLine($"Trazo: {this.Trazo.ToString()}");
            sb.AppendLine($"Color: {this.color.ToString()}");
            sb.AppendLine($"Precio: {base.Precio.ToString()}");

            return sb.ToString();

        }

        public void SerializaEnXml()
        {
            using (FileStream stream = new FileStream((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"/Lapiz{this.GetHashCode()}.xml"), FileMode.Create))

            using (StreamWriter streamWriter = new StreamWriter(stream))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lapiz));

                xmlSerializer.Serialize(streamWriter, this);
            }
        }

        public void SerializaEnJson()
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(this, opciones);
            File.WriteAllText((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"/Lapiz{this.GetHashCode()}.json"), jsonString);

        }

        public Lapiz DeserializaEnJson()
        {
            string jsonString = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"/Lapiz{this.GetHashCode()}.json");


            Lapiz lapiz = JsonSerializer.Deserialize<Lapiz>(jsonString);

            return lapiz;
        }

        public Lapiz DeserializaEnXml()
        {
            Lapiz lapiz;
            using (FileStream stream = new FileStream((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"/Lapiz{this.GetHashCode()}.xml"), FileMode.Open))

            using (StreamReader streamReader = new StreamReader(stream))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lapiz));

                lapiz = xmlSerializer.Deserialize(streamReader) as Lapiz;

                
            }

            return lapiz;
        }
    }
}
