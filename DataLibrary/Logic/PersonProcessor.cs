using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Logic
{
    public static class PersonProcessor
    {
        public static int CreatePerson(string firstName, string lastName, string birthDay, string PESEL)
        {
            PersonModel data = new PersonModel
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDay = birthDay,
                PESEL = PESEL
            };

            string sql = @"insert into dbo.Person (FirstName, LastName, BirthDay, PESEL)
                           values (@FirstName, @LastName, @BirthDay, @PESEL);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<PersonModel> LoadPeople()
        {
            string sql = @"select Id, FirstName, LastName, BirthDay, PESEL
                           from dbo.Person;";

            return SqlDataAccess.LoadData<PersonModel>(sql);
        }

    }
}
