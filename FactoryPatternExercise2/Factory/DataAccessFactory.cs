using FactoryPatternExercise2.Interfaces;
using FactoryPatternExercise2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2.Factory
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccesType(string databaseType) 
        {
            switch (databaseType.ToLower()) 
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataBaseAccess();
                case "mongo":
                    return new MongoDataAccess();
                default:
                    return new SQLDataBaseAccess();

            }
        
        }
    }
}
