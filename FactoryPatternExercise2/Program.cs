namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what data base would you like to use: List, SQL, Mongo");
            string dataBaseType = Console.ReadLine();
            IDataAccess database = DataAccessFactory.GetDataAccessType(dataBaseType);
            database.LoadData();
            database.SaveData();
        }
    }
}
