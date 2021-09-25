using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace p18_repasopoov2
{
    public static class Utils
    {
        public static void GrabarXml(string archivo, Red red){
            FileStream f = File.Open(archivo,FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Red));
            xml.Serialize(f,red);
        }
        
        public static void LeerXml(string archivo, ref Red red){
            FileStream f = File.Open(archivo, FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(Red));
            red = (Red) xml.Deserialize(f);
        }

        public static void GrabarJson(string archivo, Red red){
            StreamWriter f = File.CreateText(archivo);
            JsonSerializer json = new JsonSerializer();
            json.Serialize(f, red);
            f.Close();
        }

        public static void LeerJson(string archivo, ref Red red){
            StreamReader f = File.OpenText(archivo);
            string txt = f.ReadToEnd();
            red = JsonConvert.DeserializeObject<Red>(txt);
        }
    }
}