﻿using NOTABURGER_2.Models;

namespace NOTABURGER_2.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<MenuItem> GetMenu();
        MenuItem ReturnItem(int id);
        void Edit(MenuItem item);
       
        IEnumerable<Person> GetPeople();

        IEnumerable<SecretMenuItem> GetSecretMenu();
    }
}
