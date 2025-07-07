using System;
using SQLite;
using ControlSuscripciones.Models;

namespace ControlSuscripciones.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _db;

        public async Task Init()
        {
            if (_db != null)
                return;

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "suscripciones.db3");
            _db = new SQLiteAsyncConnection(dbPath);
            await _db.CreateTableAsync<Suscripcion>();
        }

        public async Task AddSuscripcion(Suscripcion suscripcion)
        {
            await Init();
            await _db.InsertAsync(suscripcion);
        }

        public async Task<List<Suscripcion>> GetSuscripciones()
        {
            await Init();
            return await _db.Table<Suscripcion>().ToListAsync();
        }
    }
}

