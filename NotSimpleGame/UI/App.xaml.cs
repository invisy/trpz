using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using NotSimpleGame.DataLayer.Repositories;
using NotSimpleGame.Models;
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

            MyIoCContainer container = new MyIoCContainer();
            container.Register<WeaponRepository>();
            container.Register<SkinRepository>();
            container.Register<PlayerRepository>();
            container.Register<IPlayerManager, PlayerManager>();
            container.Register<ISelectCharacterMenuVM, SelectCharacterMenuVM>();
            container.Register<ISelectCharacterWindow, SelectCharacterWindow>();

            ISelectCharacterMenuVM startVM = container.Resolve<ISelectCharacterMenuVM>();
            startVM.Start();
        }
    }
}
