using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class EmailPerson
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public string Email { get; set; }
        public EmailPerson() { }
        public EmailPerson(int id, int personID, string email)
        {
            this.Id = id;
            this.PersonID = personID;
            this.Email = email;
        }
        public EmailPerson ShallowCopy()
        {
            return (EmailPerson)this.MemberwiseClone();
        }
    }

}