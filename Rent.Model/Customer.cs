using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Rent.Model
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public Age age { get; set; }

    }

    [DataContract]
    public enum Age
    {
        [EnumMember]
        Child,

        [EnumMember]
        Young,

        [EnumMember]
        MidAge,

        [EnumMember]
        Old
    }
}
