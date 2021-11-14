using System;
using System.Collections.ObjectModel;
using Lab1.Model;


namespace Lab1.ViewModel
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> ListPerson { get; set; } =
        new ObservableCollection<Person>();

        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListPerson)
            {
                if (max < r.Id)
                {
                    max = r.Id;
                };
            }
            return max;
        }
        public PersonViewModel()
        {
            this.ListPerson.Add(
            new Person
            {
                Id = 1,
                VerietyID = 1,
                StatusID = 2,
                Inn = 12345678,
                TypeID = 1,
                Shifer = 159357,
                Data = new DateTime(1980, 02, 28)
            });
            this.ListPerson.Add(
            new Person
            {
                Id = 2,
                VerietyID = 2,
                StatusID = 1,
                Inn = 12345678,
                TypeID = 1,
                Shifer = 159357,
                Data = new DateTime(1981, 03, 20)
            });
        }

    }
}