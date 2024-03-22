using ShortestRouteOptimizer.App_Data;
using ShortestRouteOptimizer.Models;
using ShortestRouteOptimizer.Models.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ShortestRouteOptimizer.Controllers
{
    public class ShortestPathController : Controller
    {
        private IRouteOptimizerService _routeOptimizerService;

        private readonly List<string> Nodes = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
        
        public ShortestPathController()
        {
            _routeOptimizerService = new RouteOptimizerService();
        }

        // GET: ShortestPath
        [HttpGet]
        public ActionResult Path()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Path")]
        public ActionResult SubmitTag(PathRequest pathRequest)
        {
            if (!ModelState.IsValid)
            {
                return View("Path");
            }

            var sourceNode = pathRequest.SourceNode;
            var destinationNode = pathRequest.DestinationNode;         
            bool isError = false;

            if (!Nodes.Contains(sourceNode))
            {
                ModelState.AddModelError("SourceNode", "From Node doesnot exist");
                isError = true;
            }
            if (!Nodes.Contains(destinationNode))
            {
                ModelState.AddModelError("DestinationNode", "To Node doesnot exist");
                isError = true;
            }
            if (isError)
            {
                return View("Path");
            }
           
            ViewBag.Result = _routeOptimizerService.ShortestPath(sourceNode, destinationNode, Nodes);
            return View("Result");
        }

        [HttpGet]
        public ActionResult Result()
        {
            return View();
        }

    }
}