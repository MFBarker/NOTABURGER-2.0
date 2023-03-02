using NOTABURGER_2.Models;

namespace NOTABURGER_2.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<MenuItem> GetMenu();
        MenuItem ReturnItem(int id);
        void EditGame(MenuItem item);
        //IEnumerable<MenuItem> GetMenu();

        IEnumerable<Person> GetPeople();
    }
}
