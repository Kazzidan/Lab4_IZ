using System.Windows;

namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewPerson.xaml
    /// </summary>
    public partial class WindowNewPerson : Window
    {
        public WindowNewPerson()
        {
            InitializeComponent();
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
