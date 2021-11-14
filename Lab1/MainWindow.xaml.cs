using Lab1.View;
using System.Windows;

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static int IdEmail { get; set; }
        public static int IdPerson { get; set; }

        private void Employee_OnClick(object sender, RoutedEventArgs
      e)
        {
            WindowPerson wEmployee = new WindowPerson();
            wEmployee.Show();
        }
        private void Email_OnClick(object sender, RoutedEventArgs e)
        {
            WindowEmailPerson wRole = new WindowEmailPerson();
            wRole.Show();
        }
        private void Veriety_OnClick(object sender, RoutedEventArgs e)
        {
            WindowVeriety wVeriety = new WindowVeriety();
            wVeriety.Show();
        }
        private void Phone_OnClick(object sender, RoutedEventArgs e)
        {
            WindowPhone wPhone = new WindowPhone();
            wPhone.Show();
        }
        private void Status_OnClick(object sender, RoutedEventArgs e)
        {
            WindowStatus wStatus = new WindowStatus();
            wStatus.Show();
        }

        

    }
}
