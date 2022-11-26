using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Rent.Model;
using Organizer2.ViewModels;

namespace Organizer2.Map
{
    class Mapping
    {
        public void Create()
        {
            //var DataModelToView = new AutoMapper.MapperConfiguration(c => c.CreateMap<DataModel, DataViewModel>());
            //var ViewToDataModel = new AutoMapper.MapperConfiguration(c => c.CreateMap<DataViewModel, DataModel>());

            //var ClientToView = new AutoMapper.MapperConfiguration(c => c.CreateMap<Customer, CustomerModel>());
            //var ViewToClient = new AutoMapper.MapperConfiguration(c => c.CreateMap<CustomerModel, Customer>());

            //var EmployeeToView = new AutoMapper.MapperConfiguration(c => c.CreateMap<Hotel, HotelModel>());
            //var ViewToEmployee = new AutoMapper.MapperConfiguration(c => c.CreateMap<HotelModel, Hotel>());

            //var TransporterToView = new AutoMapper.MapperConfiguration(c => c.CreateMap<Order, OrderModel>());
            //var ViewToTransporter = new AutoMapper.MapperConfiguration(c => c.CreateMap<OrderModel, Order>());

            Mapper.CreateMap<DataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, DataModel>();

            Mapper.CreateMap<Customer, CustomerModel>();
            Mapper.CreateMap<CustomerModel, Customer>();

            Mapper.CreateMap<Hotel, HotelModel>();
            Mapper.CreateMap<HotelModel, Hotel>();

            Mapper.CreateMap<Order, OrderModel>();
            Mapper.CreateMap<OrderModel, Order>();
        }
    }
}
