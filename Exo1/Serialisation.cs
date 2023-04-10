using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Exo1
{
    public class Serialisaton
    {
        //private static List<Resa> lResa;
        //private static List<Resa> list;

        /*public static void sauvegarde()
        {
            FileStream stream = new FileStream("data", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, voyage);
            stream.Close();
        }
        public static List<Voyage> chargement()
        {
            if (File.Exists("data")) {
                BinaryFormatter deserializer = new BinaryFormatter();
                FileStream stream = new FileStream("data", FileMode.Open);
                voyage = (Voyage)deserializer.Deserialize(stream);
                stream.Close();
            }
            return;
        }*/
    }
}