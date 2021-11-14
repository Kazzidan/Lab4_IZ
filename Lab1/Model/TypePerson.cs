using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    class TypePerson
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public TypePerson() { }
        public TypePerson(int id, string Type)
        {
            this.Id = id;
            this.Type = Type;
        }
    }
}
