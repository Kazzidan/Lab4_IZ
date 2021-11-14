using System.Windows;
using Lab1.ViewModel;
namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowStatus.xaml
    /// </summary>
    public partial class WindowStatus : Window
    {
        public WindowStatus()
        {
            InitializeComponent();
            StatusViewModel vmStatusPerson = new StatusViewModel();
            lvStatus.ItemsSource = vmStatusPerson.ListStatusPerson;
        }
    }
}
