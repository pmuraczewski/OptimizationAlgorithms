using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizationAlgorithms;

namespace OptimizationAlgorithmsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new AntColony();
            var inputPermutation = new List<int> { 1, 2, 3 };

            algorithm.RunAlgorithm(inputPermutation);
        }
    }
}
