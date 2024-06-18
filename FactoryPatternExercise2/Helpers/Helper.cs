using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2.Helpers
{
    public static class Helper
    {
        public static string GetUserInput(string message) 
        { 
            Console.WriteLine(message);
            var input = Console.ReadLine();
            return input;
        }
    }
}
