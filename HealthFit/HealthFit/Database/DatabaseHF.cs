using System.Collections.Generic;
using System.Threading.Tasks;
using HealthFit.Model;
using SQLite;
using System;
using Xamarin.Forms;

namespace HealthFit.Database
{
    public class DatabaseHF
    {
        readonly SQLiteAsyncConnection _database;

        public DatabaseHF(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Accounts>().Wait();
        }

        public Task<List<Accounts>> GetAccountsAsync()
        { 
            return _database.Table<Accounts>().ToListAsync();
        }
        public Task<int> UpdateAccountAsync(Accounts account)
        {
            return _database.UpdateAsync(account);
        }
        public Task<int> SaveAccountAsync(Accounts account)
        {
            return _database.InsertAsync(account);
        }
        public Task<int> DeleteAccountAsync(Accounts account)
        {
            return _database.DeleteAsync(account);
        }
        public Task<Accounts> GetAccountByIdAsync(int id)
        {
            return _database.Table<Accounts>().Where(account => account.ID == id).FirstAsync();
        }
    }
}
