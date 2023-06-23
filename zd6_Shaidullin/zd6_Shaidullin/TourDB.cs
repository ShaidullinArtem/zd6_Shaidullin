using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace zd6_Shaidullin
{
    public class TourDB
    {
        private readonly SQLiteConnection connection;

        public TourDB(string path)
        {
            connection = new SQLiteConnection(path);
            connection.CreateTable<Tour>();
        }

        public List<Tour> GetTours()
        {
            return connection.Table<Tour>().ToList();
        }

        public int SaveTour(Tour tour)
        {
            return connection.Insert(tour);
        }

    }
}
