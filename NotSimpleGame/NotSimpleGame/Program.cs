using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using NotSimpleGame.Utils;

using NotSimpleGame.DAL;
using NotSimpleGame.Models;
using NotSimpleGame.Presenters;
using NotSimpleGame.Views;

namespace NotSimpleGame
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyIoCContainer container = new MyIoCContainer();
            container.Register<IDataLayer, DataLayer>();
            container.Register<IСharacterManagerModel, СharacterManagerModel>();
            container.Register<ICharacterManagerView, CharacterManagerView>();
            container.Register<CharackterManagerPresenter, CharackterManagerPresenter>();
            container.Resolve<CharackterManagerPresenter>().Show();
        }
    }
}
