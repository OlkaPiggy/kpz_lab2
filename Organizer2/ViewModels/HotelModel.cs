using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent.Model;

namespace Organizer2.ViewModels
{
    public class HotelModel : ViewModelBase
    {
        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        private int countRooms;

        public int CountRooms
        {
            get { return countRooms; }
            set
            {
                countRooms = value;
                OnPropertyChanged("CountRooms");
            }
        }

        private TypeOfHotel type;
        public TypeOfHotel Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
    }
}
