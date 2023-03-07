using NOTABURGER_2.Models;

namespace NOTABURGER_2.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<MenuItem> GetMenu();
        MenuItem ReturnItem(int id);
        void Edit(MenuItem item);

        MenuItem GetItem(int? id);

        void Delete(int? id);

        IEnumerable<Person> GetPeople();

        IEnumerable<SecretMenuItem> GetSecretMenu();
    }
}
