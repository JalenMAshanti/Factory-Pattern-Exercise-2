using FactoryPatternExercise2.Factory;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Helpers.Helper.GetUserInput("Which Database would you like to access? (SQL,Mongo,List)");
            var Database = DataAccessFactory.GetDataAccesType(input);

            Console.Clear();
            Database.LoadData();
            Console.WriteLine("");
            Database.SaveData();
            Console.ReadKey(true);
        }
    }
}
