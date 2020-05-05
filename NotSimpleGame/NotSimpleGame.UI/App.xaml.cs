using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using NotSimpleGame.UI.Views;
using NotSimpleGame.UI.ViewModels;
using NotSimpleGame.Utils;

using NotSimpleGame.BL.Implementation;

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

            IIoCContainer container = new MyIoCContainer();
            container.BindBL();
            container.Register<ISelectCharacterMenuVM, SelectCharacterMenuVM>();
            container.Register<SelectCharacterWindow>();

            SelectCharacterWindow mainWindow = container.Resolve<SelectCharacterWindow>();
            mainWindow.DataContext = container.Resolve<ISelectCharacterMenuVM>();
            mainWindow.Show();
        }
    }
}
