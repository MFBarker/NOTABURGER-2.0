using NOTABURGER_2.Interfaces;
using NOTABURGER_2.Models;

namespace NOTABURGER_2.Data
{
    public class NotABurgerDAL : IDataAccessLayer
    {
        private ApplicationDbContext db;

        public NotABurgerDAL(ApplicationDbContext indb)
        {
            db = indb;
        }

        public void Edit(MenuItem item)
        {
            db.MenuItems.Update(item);
            db.SaveChanges();
        }

        public IEnumerable<MenuItem> GetMenu()
        {
            return db.MenuItems.ToList();
        }

        public IEnumerable<Person> GetPeople()
        {
            return db.Employees.ToList();
        }

        public IEnumerable<SecretMenuItem> GetSecretMenu()
        {
            return db.SecretMenuItems.ToList();
        }

        public MenuItem ReturnItem(int id)
        {
            return db.MenuItems.FirstOrDefault(x => x.id == id);
        }

        public void Delete(int? id)
        {
            MenuItem foundItem = GetItem(id);
            db.MenuItems.Remove(foundItem);
            db.SaveChanges();
        }

        public MenuItem GetItem(int? id)
        {
            return db.MenuItems.Where(g => g.id == id).FirstOrDefault();
        }
    }
}
