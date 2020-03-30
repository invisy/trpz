using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Configuration;


using NotSimpleGame.DataLayer.Repositories;
using NotSimpleGame.Models;
using NotSimpleGame.DataLayer.Entities;
using NotSimpleGame.Models.General.Characters;
using NotSimpleGame.UI.Views;
using NotSimpleGame.UI.ViewModels;
using NotSimpleGame.Utils;


namespace NotSimpleGame.UI
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Console.WriteLine(connectionString);

            MyIoCContainer container = new MyIoCContainer();
            container.Register<IRepository<WeaponEntity>, WeaponRepository>();
            container.Register<IRepository<SkinEntity>, SkinRepository>();
            container.Register<IRepository<PlayerEntity>, PlayerRepository>();
            container.Register<IPlayerManager, PlayerManager>();
            container.Register<ISelectCharacterMenuVM, SelectCharacterMenuVM>();
            container.Register<SelectCharacterWindow>();

            SelectCharacterWindow mainWindow = container.Resolve<SelectCharacterWindow>();
            mainWindow.DataContext = container.Resolve<ISelectCharacterMenuVM>();
            mainWindow.Show();
        }
    }
}
