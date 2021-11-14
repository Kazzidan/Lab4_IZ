using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Helper
{
    class FindType
    {
        int id;
        public FindType(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Lab1.Model.TypePerson status)
        {
            return status.Id == id;
        }

    }
}
