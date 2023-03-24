using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databasetype)
        {
            switch (databasetype.ToLower())
            {
                case "list":
                    return new ListDataAccess();

                case "sql":
                    return new SQLDataAccess();

                case "mongo":
                    return new MongoDataAccess();

                default:
                    return new ListDataAccess();
            }
        }
    }
}
