﻿using MySql.Data.MySqlClient;
using Projekt.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt.DAL.Repositories
{
    class MealsRepos
    {
        private const string ALL_MEALS = "SELECT * FROM MEALS";

        public static List<Entities.Meals> GetAllMeals()
        {
            List<Entities.Meals> meals = new List<Entities.Meals>();

            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(ALL_MEALS, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    meals.Add(new Entities.Meals(reader));
                connection.Close();
            }
            return meals;
        }
    }
}