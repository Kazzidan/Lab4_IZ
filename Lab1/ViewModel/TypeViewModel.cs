using Lab1.Model;
using System;
using System.Collections.ObjectModel;

namespace Lab1.ViewModel
{
    class TypeViewModel
    {
        public ObservableCollection<TypePerson> ListTypePerson { get; set; } = new
       ObservableCollection<TypePerson>();
        public TypeViewModel()
        {
            this.ListTypePerson.Add(
            new TypePerson
            {
                Id = 1,
                Type = "физическое лицо"
            });
            this.ListTypePerson.Add(
            new TypePerson
            {
                Id = 2,
                Type = "юридическое лицо"
            });
        }
    }
}
