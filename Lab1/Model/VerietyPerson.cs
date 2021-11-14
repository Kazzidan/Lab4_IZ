using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class VerietyPerson
    {
        public int Id { get; set; }
        public string Veriety { get; set; }
        public VerietyPerson() { }
        public VerietyPerson(int id, string veriety)
        {
            this.Id = id;
            this.Veriety = veriety;
        }
    }
}
