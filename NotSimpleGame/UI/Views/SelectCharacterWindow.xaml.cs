using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using NotSimpleGame.UI.ViewModels;
using NotSimpleGame.Models;

namespace NotSimpleGame.UI.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class SelectCharacterWindow : Window, ISelectCharacterWindow
    {
        public SelectCharacterWindow()
        {
            InitializeComponent();
        }
    }
}
