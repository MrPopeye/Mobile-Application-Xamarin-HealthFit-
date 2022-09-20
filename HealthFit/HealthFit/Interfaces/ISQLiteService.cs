using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HealthFit.Interfaces
{
    public interface ISQLiteService
    {
        SQLiteConnection GetConnection(string databaseName);
        long GetSize(string databaseName);
    }
}
