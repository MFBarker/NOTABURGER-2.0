﻿using NOTABURGER_2.Models;

namespace NOTABURGER_2.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<MenuItem> GetMenu();

        IEnumerable<Person> GetPeople();
    }
}
