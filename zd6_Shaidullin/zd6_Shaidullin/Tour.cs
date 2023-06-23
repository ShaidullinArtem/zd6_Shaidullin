using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace zd6_Shaidullin
{
    public class Tour
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }    
        public string Catigory { get; set; }
        public double Price { get; set; }
        public string TourOperator { get; set; }
        public double Days { get; set; }
        public string Description { get; set; }

    }
}
