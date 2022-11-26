using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Rent.Model.Serialization;

namespace Rent.Model
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Customer> Customers { get; set; }
        [DataMember]
        public IEnumerable<Hotel> Hotels { get; set; }
        [DataMember]
        public IEnumerable<Order> Orders { get; set; }

        public DataModel()
        {
            Customers = new List<Customer>() { new Customer() { Name = "Olha", Surname = "Sopotnytska", Email = "firstClient@email.com", age = Age.Young } };
            Hotels = new List<Hotel> { new Hotel() { Name = "Milano", Address = "BackerStreet 221b", Price = 6000, CountRooms = 50, Type = TypeOfHotel.Hostel } };
            Orders = new List<Order>() { new Order() { Customer = "Fernando", Hotel = "Milano",
                StartDate = new DateTime(2022, 9, 26) ,FinishDate = new DateTime(2022, 9, 30), TotalPrice = 10500 } };
        }

        public static string DataPath = @"C:\Users\User\source\repos\Organizer2\organizer.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerialization.DeserializeItem(DataPath);
            }
            Console.WriteLine("load");
            return new DataModel();
        }

        public void Save()
        {
            Console.WriteLine("in save method");
            DataSerialization.SerializeData(DataPath, this);
        }
    }
}
