using System;
using System.Collections.ObjectModel;
using Lab1.Model;

namespace Lab1.ViewModel
{
    class EmailPersonVievModel
    {
        /// <summary>
        /// Нахождение максимального Id
        /// </summary>
        /// <returns></returns>
        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListEmailPerson)
            {
                if (max < r.Id)
                {
                    max = r.Id;
                };
            }
            return max;
        }
        public ObservableCollection<EmailPerson> ListEmailPerson { get; set; } = new
       ObservableCollection<EmailPerson>();
        public EmailPersonVievModel()
        {
            this.ListEmailPerson.Add(new EmailPerson
            {
                Id = 1,
                PersonID = 1,
                Email = "byster1234@mail.ru"
            });
            this.ListEmailPerson.Add(new EmailPerson
            {
                Id = 2,
                PersonID = 2,
                Email = "alexdoljenko@mail.ru"
            });
            this.ListEmailPerson.Add(new EmailPerson
            {
                Id = 3,
                PersonID = 3,
                Email = "luxury1932@yandex.ru"
            });
        }
    }
}
