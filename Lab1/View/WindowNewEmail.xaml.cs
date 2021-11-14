using System;
using System.Windows;

namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewEmail.xaml
    /// </summary>
    public partial class WindowNewEmail : Window
    {
        public WindowNewEmail()
        {
            InitializeComponent();
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

    }
}
