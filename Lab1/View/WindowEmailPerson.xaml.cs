using System.Windows;
using Lab1.ViewModel;
using Lab1.Model;

namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowEmailPerson.xaml
    /// </summary>
    public partial class WindowEmailPerson : Window
    {
        EmailPersonVievModel vmEmailPerson;
        public WindowEmailPerson()
        {
            InitializeComponent();
            vmEmailPerson = new EmailPersonVievModel();
            lvEmailPerson.ItemsSource = vmEmailPerson.ListEmailPerson;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewEmail wnEmail = new WindowNewEmail
            {
                Title = "Новая почта",
                Owner = this
            };
        // формирование кода новой должности
            int maxIdEmail = vmEmailPerson.MaxId() + 1;
            EmailPerson EmailPers = new EmailPerson
            {
                Id = maxIdEmail
            };
            wnEmail.DataContext = EmailPers;
            if (wnEmail.ShowDialog() == true)
            {
                vmEmailPerson.ListEmailPerson.Add(EmailPers);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewEmail wnRole = new WindowNewEmail
            {
                Title = "Редактирование должности",
                Owner = this
            };
            EmailPerson Email = lvEmailPerson.SelectedItem as EmailPerson;
            if (Email != null)
            {
                EmailPerson tempRole = Email.ShallowCopy();
                wnRole.DataContext = tempRole;
                if (wnRole.ShowDialog() == true)
                {
                    // сохранение данных
                    Email.PersonID = tempRole.PersonID;
                    Email.Email = tempRole.Email;
                    lvEmailPerson.ItemsSource = null;
                    lvEmailPerson.ItemsSource = vmEmailPerson.ListEmailPerson;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать должность для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
           EmailPerson Email = (EmailPerson)lvEmailPerson.SelectedItem;
            if (Email != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по Почте: " +
               Email.Email, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmEmailPerson.ListEmailPerson.Remove(Email);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать Почту для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
