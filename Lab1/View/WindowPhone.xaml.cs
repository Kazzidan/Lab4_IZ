using System.Windows;
using Lab1.ViewModel;

namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPhone.xaml
    /// </summary>
    public partial class WindowPhone : Window
    {
        public WindowPhone()
        {
            InitializeComponent();
            PhoneViewModel vmPhonePerson = new PhoneViewModel();
            lvPhone.ItemsSource = vmPhonePerson.ListPhonePerson;
        }
    }
}