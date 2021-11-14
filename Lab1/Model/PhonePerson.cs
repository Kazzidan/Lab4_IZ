using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class PhonePerson
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Phone { get; set; }
        public PhonePerson() { }
        public PhonePerson(int id, int personId, string phone)
        {
            this.Id = id;
            this.PersonId = personId;
            this.Phone = phone;
        }
    }
}
