using System.Windows;
using Lab1.Model;
using Lab1.ViewModel;

namespace Lab1.Helper
{
    public class FindStatus
    {
        int id;
        public FindStatus(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Lab1.Model.StatusPerson status)
        {
            return status.Id == id;
        }
    }
}
