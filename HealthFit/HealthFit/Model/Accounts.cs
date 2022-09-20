using System;
using SQLite;

namespace HealthFit.Model
{
    public class Accounts
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NameF { get; set; }
        public string NameP { get; set; }
        public string PersonWeight { get; set; }
        public string PersonHeight { get; set; }
        public DateTime BDate { get; set; }
    }
}
