using System.Windows;
using Lab1.ViewModel;

namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowVeriety.xaml
    /// </summary>
    public partial class WindowVeriety : Window
    {
        public WindowVeriety()
        {
            InitializeComponent();
            VerietyViewModel vmVerietyPerson = new VerietyViewModel();
            lvVeriety.ItemsSource = vmVerietyPerson.ListVerietyPerson;
        }
    }
}
