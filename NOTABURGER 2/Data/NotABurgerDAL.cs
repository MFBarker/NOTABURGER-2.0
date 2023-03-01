﻿using System;
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

        public IEnumerable<MenuItem> GetMenu()
        {
            return db.MenuItems.ToList();
        }

        public IEnumerable<Person> GetPeople()
        {
            return db.Employees.ToList();
        }
    }
}
