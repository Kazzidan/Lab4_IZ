using System;
using System.Collections.Generic;
using System.Text;
using Lab1.ViewModel;

namespace Lab1.Model
{
    public class PersonDPO
    {
        public int Id { get; set; } //Код
        public string Veriety { get; set; }
        public string Status { get; set; }
        public int Inn { get; set; }
        public string Type { get; set; }
        public int Shifer { get; set; }
        public DateTime Data { get; set; }
        public PersonDPO() { }
        public PersonDPO(int id, string veriety, string status, int inn,
        string type, int shifer, DateTime data)
        {
            this.Id = id;
            this.Veriety = veriety;
            this.Status = status;
            this.Inn = inn;
            this.Type = type;
            this.Shifer = shifer;
            this.Data = data;
        }
        public PersonDPO CopyFromPerson(Person person)
        {
            PersonDPO perDPO = new PersonDPO();
            StatusViewModel vmStatus = new StatusViewModel();
            VerietyViewModel vmVeriety = new VerietyViewModel();
            TypeViewModel vmType = new TypeViewModel();
            string status = string.Empty;
            string veriety = string.Empty;
            string type = string.Empty;
            foreach (var s in vmStatus.ListStatusPerson)
            {
                if (s.Id == person.Id)
                {
                    status = s.Status;
                    break;
                }
            }
            foreach (var v in vmVeriety.ListVerietyPerson)
            {
                if (v.Id == person.Id)
                {
                    veriety = v.Veriety;
                    break;
                }
            }
            foreach (var t in vmType.ListTypePerson)
            {
                if (t.Id == person.Id)
                {
                    type = t.Type;
                    break;
                }
            }
            if ((status != string.Empty) & (type != string.Empty) & (veriety != string.Empty))
            {
                perDPO.Id = person.Id;
                perDPO.Status = status;
                perDPO.Veriety = veriety;
                perDPO.Type = type;
                perDPO.Inn = person.Inn;
                perDPO.Shifer = person.Shifer;
                perDPO.Data = person.Data;
            }
            return perDPO;
        }
        public PersonDPO ShallowCopy()
        {
            return (PersonDPO)this.MemberwiseClone();
        }

    }
}
