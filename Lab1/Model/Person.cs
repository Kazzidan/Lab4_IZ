using System;
using System.Collections.Generic;
using System.Text;
using Lab1.ViewModel;

namespace Lab1.Model
{
    public class Person
    {
        public int Id { get; set; } //Код
        public int VerietyID { get; set; }
        public int StatusID { get; set; }
        public int Inn { get; set; }
        public int TypeID { get; set; }
        public int Shifer { get; set; }
        public DateTime Data { get; set; }
        public Person() { }
        public Person(int id, int verietyId, int statusID, int inn,
       int type, int shifer, DateTime data)
        {
            this.Id = id;
            this.VerietyID = verietyId;
            this.StatusID = statusID;
            this.Inn = inn;
            this.TypeID = type;
            this.Shifer = shifer;
            this.Data = data;
        }

        public Person CopyFromPersonDPO(PersonDPO p)
        {
            StatusViewModel vmStatus = new StatusViewModel();
            VerietyViewModel vmVeriety = new VerietyViewModel();
            TypeViewModel vmType = new TypeViewModel();
            int StatusId = 0;
            int VerietyId = 0;
            int TypeId = 0;
            foreach (var s in vmStatus.ListStatusPerson)
            {
                if (s.Status == p.Status)
                {
                    StatusId = s.Id;
                    break;
                }
            }
            foreach (var v in vmType.ListTypePerson)
            {
                if (v.Type == p.Type)
                {
                    TypeId = v.Id;
                    break;
                }
            }
            foreach (var v in vmVeriety.ListVerietyPerson)
            {
                if (v.Veriety == p.Veriety)
                {
                    TypeId = v.Id;
                    break;
                }
            }
            if (StatusId != 0)
            {
                this.Id = p.Id;

                this.StatusID = StatusId;
                this.VerietyID = VerietyId;
                this.TypeID = TypeId;
                this.Inn = p.Inn;
                this.Shifer = p.Shifer;
                this.Data = p.Data;
            }
            return this;
        }
    }
}
