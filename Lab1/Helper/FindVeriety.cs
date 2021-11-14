using System.Windows;
using Lab1.Model;
using Lab1.ViewModel;

namespace Lab1.Helper
{
    public class FindVeriety
    {
        int id;
        public FindVeriety(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Lab1.Model.VerietyPerson veriety)
        {
            return veriety.Id == id;
        }

    }
}
