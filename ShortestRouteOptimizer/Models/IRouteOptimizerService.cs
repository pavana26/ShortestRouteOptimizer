using ShortestRouteOptimizer.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestRouteOptimizer.Models
{
    public interface IRouteOptimizerService
    {
        ShortestPathData ShortestPath(string souceNodeName, string destNodeName, List<string> graphNode);

    }
}
