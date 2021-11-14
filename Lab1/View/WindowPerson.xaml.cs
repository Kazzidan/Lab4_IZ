using System;
using System.Windows;
using Lab1.ViewModel;
using Lab1.Helper;
using Lab1.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;



namespace Lab1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPerson.xaml
    /// </summary>
    public partial class WindowPerson : Window
    {
        private PersonViewModel vmPerson;
        private StatusViewModel vmStatus;
        private VerietyViewModel vmVeriety;
        private TypeViewModel vmType;

        ObservableCollection<PersonDPO> personsDPO;
        private List<StatusPerson> statuses;
        private List<VerietyPerson> verieties;
        private List<TypePerson> types;


        public WindowPerson()
        {
            InitializeComponent();
            vmPerson = new PersonViewModel();
            vmStatus = new StatusViewModel();
            vmVeriety = new VerietyViewModel();
            vmType = new TypeViewModel();
            
            statuses = vmStatus.ListStatusPerson.ToList();
            verieties = vmVeriety.ListVerietyPerson.ToList();
            types = vmType.ListTypePerson.ToList();

            personsDPO = new ObservableCollection<PersonDPO>();

            foreach (var person in vmPerson.ListPerson)
            {
                PersonDPO p = new PersonDPO();
                p = p.CopyFromPerson(person);
                personsDPO.Add(p);
            }

            lvClients.ItemsSource = personsDPO;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewPerson wnPerson = new WindowNewPerson
            {
                Title = "Новый клиент",
                Owner = this
            };

            // формирование кода нового клиента
            int maxIdPerson = vmPerson.MaxId() + 1;
            PersonDPO per = new PersonDPO
            {
                Id = maxIdPerson,
                Data = DateTime.Now
            };
            wnPerson.DataContext = per;
            wnPerson.CbStatus.ItemsSource = statuses;
            wnPerson.CbType.ItemsSource = types;
            wnPerson.CbVeriety.ItemsSource = verieties;
            if (wnPerson.ShowDialog() == true)
            {
                StatusPerson s = (StatusPerson)wnPerson.CbStatus.SelectedValue;
                per.Status = s.Status;
                VerietyPerson v = (VerietyPerson)wnPerson.CbVeriety.SelectedValue;
                per.Veriety = v.Veriety;
                TypePerson t = (TypePerson)wnPerson.CbType.SelectedValue;
                per.Type = t.Type;
                personsDPO.Add(per);
                // добавление нового сотрудника в коллекцию ListPerson<Person>
                Person p = new Person();
                p = p.CopyFromPersonDPO(per);
                vmPerson.ListPerson.Add(p);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewPerson wnEmployee = new WindowNewPerson
            {
                Title = "Редактирование данных",
                Owner = this
            };
            PersonDPO perDPO = (PersonDPO)lvClients.SelectedValue;
            PersonDPO tempPerDPO; // временный класс для редактирования
            if (perDPO != null)
            {
                tempPerDPO = perDPO.ShallowCopy();
                wnEmployee.DataContext = tempPerDPO;
                wnEmployee.CbStatus.ItemsSource = statuses;
                wnEmployee.CbStatus.Text = tempPerDPO.Status;
                wnEmployee.CbVeriety.ItemsSource = verieties;
                wnEmployee.CbVeriety.Text = tempPerDPO.Veriety;
                wnEmployee.CbType.ItemsSource = types;
                wnEmployee.CbType.Text = tempPerDPO.Type;
                if (wnEmployee.ShowDialog() == true)
                {

                    StatusPerson r = (StatusPerson)wnEmployee.CbStatus.SelectedValue;
                    VerietyPerson v = (VerietyPerson)wnEmployee.CbVeriety.SelectedValue;
                    TypePerson t = (TypePerson)wnEmployee.CbType.SelectedValue;
                    perDPO.Status = r.Status;
                    perDPO.Type = t.Type;
                    perDPO.Veriety = v.Veriety;
                    perDPO.Inn = tempPerDPO.Inn;
                    perDPO.Shifer = tempPerDPO.Shifer;
                    perDPO.Data = tempPerDPO.Data;
                    lvClients.ItemsSource = null;
                    lvClients.ItemsSource = personsDPO;
                    // перенос данных из класса отображения данных в класс Person
                    FindPerson finder = new FindPerson(perDPO.Id);
                    List<Person> listPerson = vmPerson.ListPerson.ToList();
                    Person p = listPerson.Find(new Predicate<Person>(finder.PersonPredicate));
                    p = p.CopyFromPersonDPO(perDPO);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать сотрудника для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            PersonDPO person = (PersonDPO)lvClients.SelectedItem;
            if (person != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по сотруднику: \n"
                    + person.Id,
                "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    // удаление данных в списке отображения данных
                    personsDPO.Remove(person);
                    // удаление данных в списке классов ListPerson<Person>
                    Person per = new Person();
                    per = per.CopyFromPersonDPO(person);
                    vmPerson.ListPerson.Remove(per);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать данные по сотруднику для удаления",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}