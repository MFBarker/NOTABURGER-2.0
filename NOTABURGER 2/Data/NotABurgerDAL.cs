using System;
using NOTABURGER_2.Interfaces;
using NOTABURGER_2.Models;
using NuGet.LibraryModel;

namespace NOTABURGER_2.Data
{
    public class NotABurgerDAL : IDataAccessLayer
    {
        private ApplicationDbContext db;

        public NotABurgerDAL(ApplicationDbContext indb)
        {
            db = indb;
        }

        public void EditGame(MenuItem item)
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

        public MenuItem ReturnItem(int id)
        {
            return db.MenuItems.FirstOrDefault(x => x.id == id);
        }
    }
}
