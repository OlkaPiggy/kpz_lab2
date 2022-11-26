using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Rent.Model
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public string Customer { get; set; }
        [DataMember]
        public string Hotel { get; set; }
        [DataMember]
        public DateTime StartDate { set; get; }
        [DataMember]
        public DateTime FinishDate { set; get; }
        [DataMember]
        public int TotalPrice { set; get; }
    }
}
