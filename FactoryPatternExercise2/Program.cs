namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataAccess database = DataAccessFactory.GetDataAccessType();
            database.LoadData();
            database.SaveData();
        }
    }
}
