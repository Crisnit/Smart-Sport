using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SmartSport.Models
{
    public class TrainingsRepository
    {
        SQLiteConnection database;

        public TrainingsRepository( string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Training>();
        }
        public IEnumerable<Training> GetItems()
        {
            return database.Table<Training>().ToList();
        }

        public Training GetItem(int id)
        {
            return database.Get<Training>(id);
        }

        public void DeleteItem(int id) 
        {
            database.Delete<Training>(id);
        }

        public int SaveItem (Training item)
        {
            if(item.Id!=0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
