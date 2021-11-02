using Data;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider sp;

        public App()
        {
            var services = new ServiceCollection();
            services.RegDepDA();
            services.RegDepBL();
            services.RegDepUI();
            sp = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            RestaurantsWindow rw = new RestaurantsWindow();
            rw.DataContext = sp.GetService<ReastaurantViewModel>();
            rw.Show();
        }
    }
}
