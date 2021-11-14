using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Model
{
    public class StatusPerson
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public StatusPerson() { }
        public StatusPerson(int id, string status)
        {
            this.Id = id;
            this.Status = status;
        }
    }
}
