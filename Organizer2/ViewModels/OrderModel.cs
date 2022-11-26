using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer2.ViewModels
{
    public class OrderModel : ViewModelBase
    {
        private string customer;

        public string Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                OnPropertyChanged("Customer");
            }
        }
        private string hotel;

        public string Hotel
        {
            get { return hotel; }
            set
            {
                hotel = value;
                OnPropertyChanged("Hotel");
            }
        }

        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        private DateTime finishDate;

        public DateTime FinishDate
        {
            get { return finishDate; }
            set
            {
                finishDate = value;
                OnPropertyChanged("FinishDate");
            }
        }

        private int totalPrice;

        public int TotalPrice
        {
            get { return totalPrice; }
            set
            {
                totalPrice = value;
                OnPropertyChanged("TotalPrice");
            }
        }

    }
}
