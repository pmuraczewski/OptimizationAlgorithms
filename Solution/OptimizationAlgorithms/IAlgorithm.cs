using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationAlgorithms
{
    public interface IAlgorithm
    {
        IEnumerable<int> RunAlgorithm(IEnumerable<int> inputPermutation);
    }
}
