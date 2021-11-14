using Lab1.Model;
using System;
using System.Collections.ObjectModel;

namespace Lab1.ViewModel
{
    class PhoneViewModel
    {
        public ObservableCollection<PhonePerson> ListPhonePerson { get; set; } = new
       ObservableCollection<PhonePerson>();
        public PhoneViewModel()
        {
            this.ListPhonePerson.Add(
            new PhonePerson
            {
                Id = 1,
                PersonId = 1,
                Phone = "89298213318"
            });
            this.ListPhonePerson.Add(
            new PhonePerson
            {
                Id = 2,
                PersonId = 2,
                Phone = "89184591343"
            });
            this.ListPhonePerson.Add(
            new PhonePerson
            {
                Id = 1,
                PersonId = 1,
                Phone = "89991332847"
            });
        }
    }
}
