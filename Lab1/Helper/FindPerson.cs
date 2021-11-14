using System;
using Lab1.Model;

namespace Lab1.Helper
{
    class FindPerson
    {

        int id;
        public FindPerson(int id)
        {
            this.id = id;
        }
        public bool PersonPredicate(Person role)
        {
            return role.Id == id;
        }
    }
}
