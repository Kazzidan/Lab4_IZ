using Lab1.Model;
using System;
using System.Collections.ObjectModel;

namespace Lab1.ViewModel
{
    class StatusViewModel
    {
        public ObservableCollection<StatusPerson> ListStatusPerson { get; set; } = new
       ObservableCollection<StatusPerson>();
        public StatusViewModel()
        {
            this.ListStatusPerson.Add(
            new StatusPerson
            {
                Id = 1,
                Status = "активный"
            });
            this.ListStatusPerson.Add(
            new StatusPerson
            {
                Id = 2,
                Status = "неактивный"
            });
        }
    }
}