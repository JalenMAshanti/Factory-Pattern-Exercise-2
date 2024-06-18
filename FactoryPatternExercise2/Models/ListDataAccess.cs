using FactoryPatternExercise2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2.Models
{
    public class ListDataAccess : IDataAccess
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void LoadData()
        {
            Console.WriteLine("I am reading data from List Database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to List Database");
        }
    }
}
