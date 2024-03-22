using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShortestRouteOptimizer.Models.ViewModel
{
    public class PathRequest
    {
        [Required(ErrorMessage = "Please enter from node")]
        public string SourceNode { get; set; }

        [Required(ErrorMessage = "Please enter to node")]
        public string DestinationNode { get; set; }
    }
}