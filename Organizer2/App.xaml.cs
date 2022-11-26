using AutoMapper;
//using Organizer2.Mapping;
using Organizer2.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Rent.Model;
using Organizer2.Map;

namespace Organizer2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
   // DataModel _model;
    public partial class App : Application
    {
        private DataModel _model;
        private DataViewModel _viewModel;
        public App()
        {
            new Mapping().Create();

            _model = DataModel.Load();
            _viewModel = Mapper.Map<DataModel, DataViewModel>(_model);

            var window = new MainWindow() { DataContext=_viewModel};
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                // _model.Save();

                //var config = new MapperConfiguration(cfg => cfg.CreateMap<DataViewModel, DataModel>());
                //var mapper = new Mapper(config);
                _model = Mapper.Map<DataViewModel, DataModel>(_viewModel);
                _model.Save();

            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
