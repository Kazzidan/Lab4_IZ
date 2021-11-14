using Lab1.Model;
using System;
using System.Collections.ObjectModel;

namespace Lab1.ViewModel
{
    class VerietyViewModel
    {
        public ObservableCollection<VerietyPerson> ListVerietyPerson { get; set; } = new
       ObservableCollection<VerietyPerson>();
        public VerietyViewModel()
        {
            this.ListVerietyPerson.Add(new VerietyPerson
            {
                Id = 1,
                Veriety = "инвестор"
            });
            this.ListVerietyPerson.Add(new VerietyPerson
            {
                Id = 2,
                Veriety = "доверительное управление"
            });
        }
    }
}
