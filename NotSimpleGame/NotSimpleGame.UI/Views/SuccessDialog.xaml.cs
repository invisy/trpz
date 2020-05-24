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
using System.Windows.Shapes;

namespace NotSimpleGame.UI.Views
{
    /// <summary>
    /// Логика взаимодействия для SuccessDialog.xaml
    /// </summary>
    public partial class SuccessDialog : Window
    {
        String _text;
        public SuccessDialog(String text)
        {
            InitializeComponent();
            _text =  text;
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            label.Content = _text;
        }
    }
}
