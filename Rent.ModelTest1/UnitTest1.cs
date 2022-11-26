using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rent.Model;
using Rent.Model.Serialization;
using System.Collections.Generic;

namespace Rent.ModelTest
{
    [TestClass]
    public class UnitTestSerialization
    {
        [TestMethod]
        public void TestMethodSerialize()
        {
            var model = new DataModel();
            model.Customers = new List<Customer>() { new Customer() { Name = "Olha", Surname = "Sopotnytska", Email = "firstClient@email.com", age = Age.Young } };
            model.Hotels = new List<Hotel> { new Hotel() { Name = "Milano", Address = "BackerStreet 221b", Price = 6000, CountRooms = 50, Type = TypeOfHotel.Hostel } };
            model.Orders = new List<Order>() { new Order() { Customer = "Fernando", Hotel = "Milano",
                StartDate = new DateTime(2022, 9, 26) ,FinishDate = new DateTime(2022, 9, 30), TotalPrice = 10500 } };
            DataSerialization.SerializeData(@"C:\Users\User\source\repos\Organizer2\organizer.dat", model);
        }

        [TestMethod]
        public void TestMethodDeSerialize()
        {
            var model = DataSerialization.DeserializeItem(@"C:\Users\User\source\repos\Organizer2\organizer.dat");
        }


        [TestMethod]
        public void TestMethodDeSerializeFromModel()
        {
            var model = DataModel.Load();
        }

        [TestMethod]
        public void TestMethodSerializeFromModel()
        {
            var model = new DataModel();

            model.Save();
        }
    }
}
