using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Model.Serialization
{
    public class DataSerialization
    {
        public static void SerializeData(string fileName, DataModel dataModel)
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            //var formatter = new BinaryFormatter();
            var s = new FileStream(fileName, FileMode.Create);
            formatter.WriteObject(s, dataModel);
            //formatter.Serialize(s, dataModel);
            s.Close();
        }

        public static DataModel DeserializeItem(string fileName)
        {
            var s = new FileStream(fileName, FileMode.Open);
            var formatter = new DataContractSerializer(typeof(DataModel));
            //var formatter = new BinaryFormatter();
            return (DataModel)formatter.ReadObject(s);
            //return (DataModel)formatter.Deserialize(s);
        }
    }
}
