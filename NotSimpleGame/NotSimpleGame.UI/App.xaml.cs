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

using NotSimpleGame.DL.Implementation;
using NotSimpleGame.BL.Implementation;

namespace NotSimpleGame.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IIoCContainer container = new MyIoCContainer();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            container.BindDL(connectionString);
            container.BindBL();
            container.Register<ISelectCharacterMenuVM, SelectCharacterMenuVM>();
            container.Register<SelectCharacterWindow>();

            SelectCharacterWindow mainWindow = container.Resolve<SelectCharacterWindow>();
            mainWindow.DataContext = container.Resolve<ISelectCharacterMenuVM>();
            mainWindow.Show();
        }

    }
}
