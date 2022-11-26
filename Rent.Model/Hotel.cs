using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Rent.Model
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int CountRooms { get; set; }
        [DataMember]
        public TypeOfHotel Type { set; get; }
    }


    [DataContract]
    public enum TypeOfHotel
    {
        [EnumMember]
        Hotel,

        [EnumMember]
        Hostel,

        [EnumMember]
        Motel,

        [EnumMember]
        Cottage
    }
}
