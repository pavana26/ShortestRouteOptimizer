using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShortestRouteOptimizer.Models.DTO
{
    public class ShortestPathData
    {
        public IEnumerable<string> NodeNames { get; set; }
        public int Distance { get; }

    }
}