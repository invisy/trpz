using System;
using System.Windows;
using System.Windows.Controls;

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
            _text = text;
        }

        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
            label.Content = _text;
        }
    }
}
