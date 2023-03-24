using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType()
        {
            Console.WriteLine("Hello, what data base would you like to use: List, SQL, Mongo");
            for (var i = 0; i < 3; i++)
            {
                var dataBaseType = Console.ReadLine();
                switch (dataBaseType.ToLower())
                {
                    case "list":
                        return new ListDataAccess();

                    case "sql":
                        return new SQLDataAccess();
          
                    case "mongo":
                        return new MongoDataAccess();

                    default:
                        Console.WriteLine("enter a valid response. You can choose from: List, SQL, Mongo");
                        continue;
                }
            }
            Console.Clear();
            return GetDataAccessType();
        }

    }
}
