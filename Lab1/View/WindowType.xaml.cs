using System.Windows;
using Lab1.ViewModel;

namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowType.xaml
    /// </summary>
    public partial class WindowType : Window
    {
        public WindowType()
        {
            InitializeComponent();
            TypeViewModel vmTypePerson = new TypeViewModel();
            lvType.ItemsSource = vmTypePerson.ListTypePerson;
        }
    }
}
