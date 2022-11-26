using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rent.Model;

namespace Organizer2.ViewModels
{
    public class CustomerModel:ViewModelBase
    {
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
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

        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        private Age _age;
        public Age age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("age");
            }
        }

    }
}
