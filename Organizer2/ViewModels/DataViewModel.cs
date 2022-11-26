using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Rent.Model;
using System.Collections.ObjectModel;

namespace Organizer2.ViewModels
{
    public class DataViewModel : ViewModelBase
    {
        public DataViewModel()
        {
            SetPanelVisibility = new Command(PanelVisibility);

            ChangeAgeToChild = new Command(ToChild);
            ChangeAgeToYoung = new Command(ToYoung);
            ChangeAgeToMidAge = new Command(ToMidAge);
            ChangeAgeToOld = new Command(ToOld);

            ChangeTypeOfHotelToHotel = new Command(ToHotel);
            ChangeTypeOfHotelToHostel = new Command(ToHostel);
            ChangeTypeOfHotelToCottage = new Command(ToCottage);
            ChangeTypeOfHotelToMotel = new Command(ToMotel);
        }

        private string visiblePanel = "Customers";
        public string VisiblePanel
        {
            get { return visiblePanel; }
            set
            {
                visiblePanel = value;
                OnPropertyChanged("VisiblePanel");
            }
        }

        public ICommand SetPanelVisibility { get; set; }
        public void PanelVisibility(object parameter)
        {
            VisiblePanel = parameter.ToString();
        }


        private ObservableCollection<CustomerModel> customers;
        public ObservableCollection<CustomerModel> Customers
        {
            get { return customers; }
            set
            {
                customers = value;
                OnPropertyChanged("Customers");
            }
        }

        private ObservableCollection<HotelModel> hotels;

        public ObservableCollection<HotelModel> Hotels
        {
            get { return hotels; }
            set
            {
                hotels = value;
                OnPropertyChanged("Hotels");
            }
        }

        private ObservableCollection<OrderModel> orders;

        public ObservableCollection<OrderModel> Orders
        {
            get { return orders; }
            set
            {
                orders = value;
                OnPropertyChanged("Orders");
            }
        }

        public CustomerModel selectedCustomer;
        public CustomerModel SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");
            }
        }
        public ICommand ChangeAgeToChild { get; set; }

        public void ToChild(object args)
        {
            if (SelectedCustomer != null)
            {
                SelectedCustomer.age = Age.Child;
            }
        }
        public ICommand ChangeAgeToYoung { get; set; }

        public void ToYoung(object args)
        {
            if (SelectedCustomer != null)
            {
                SelectedCustomer.age = Age.Young;
            }
        }
        public ICommand ChangeAgeToMidAge { get; set; }

        public void ToMidAge(object args)
        {
            if (SelectedCustomer != null)
            {
                SelectedCustomer.age = Age.MidAge;
            }
        }
        public ICommand ChangeAgeToOld { get; set; }

        public void ToOld(object args)
        {
            if (SelectedCustomer != null)
            {
                SelectedCustomer.age = Age.Old;
            }
        }

        public HotelModel selectedHotel;
        public HotelModel SelectedHotel
        {
            get { return selectedHotel; }
            set
            {
                selectedHotel = value;
                OnPropertyChanged("SelectedHotel");
            }
        }
        public ICommand ChangeTypeOfHotelToHotel { get; set; }

        public void ToHotel(object args)
        {
            if (SelectedHotel != null)
            {
                SelectedHotel.Type = TypeOfHotel.Hotel;
            }
        }
        public ICommand ChangeTypeOfHotelToHostel { get; set; }

        public void ToHostel(object args)
        {
            if (SelectedHotel != null)
            {
                SelectedHotel.Type = TypeOfHotel.Hostel;
            }
        }
        public ICommand ChangeTypeOfHotelToCottage { get; set; }

        public void ToCottage(object args)
        {
            if (SelectedHotel != null)
            {
                SelectedHotel.Type = TypeOfHotel.Cottage;
            }
        }
        public ICommand ChangeTypeOfHotelToMotel { get; set; }

        public void ToMotel(object args)
        {
            if (SelectedHotel != null)
            {
                SelectedHotel.Type = TypeOfHotel.Motel;
            }
        }
    }
}
