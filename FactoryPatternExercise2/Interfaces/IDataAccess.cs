using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2.Interfaces
{
    public interface IDataAccess
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void LoadData();
        public void SaveData();
    }
}
