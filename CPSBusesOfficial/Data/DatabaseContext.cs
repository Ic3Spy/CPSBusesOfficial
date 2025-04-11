using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPSBusesOfficial.Models;
using SQLite;

namespace CPSBusesOfficial.Data
{
    /// <summary>
    /// Centralized Class for handing local SQLite Database things for the App
    /// Loaded in MauiProgram as Singleton (one instance only within the App)
    /// </summary>
    public class DatabaseContext
    {
        SQLiteAsyncConnection database;
        public static DatabaseContext Instance { set; get; }
        public DatabaseContext()
        {
            //init from constructor
            DatabaseContext.Instance = this;
        }

        /// <summary>
        /// Initialize Database Availability
        /// </summary>
        /// <returns></returns>
        public async Task Init()
        {
            if (database is not null)
                return;

            database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            //Create tables
            await database.CreateTableAsync<Role>();
            await database.CreateTableAsync<Days>();
            await database.CreateTableAsync<Schedule>();
            await database.CreateTableAsync<User>();
            await database.CreateTableAsync<Bus>();
            await database.CreateTableAsync<Attendance>();
            await database.CreateTableAsync<Dispatch>();
            await database.CreateTableAsync<Violation>();
            await database.CreateTableAsync<ViolationReport>();
            await database.CreateTableAsync<ViolationForm>();
            await database.CreateTableAsync<IncidentReport>();
            await database.CreateTableAsync<IncidentForm>();
        }

        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns></returns>
        
    }
}
