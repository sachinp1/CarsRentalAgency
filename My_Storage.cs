using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Xml.Serialization;


namespace CarsRentalAgency
{
    class My_Storage
    {
        internal static void WriteXml<T>(T data, string file)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                FileStream fs = new FileStream(file, FileMode.Create);
                xs.Serialize(fs, data);
                fs.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Error");
            }
        }

        internal static T ReadXml<T>(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    return (T)xs.Deserialize(sr);
                }
            }
            catch (Exception)
            {
                return default(T);
            }
        }
    }
    
}
