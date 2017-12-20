using System; 
using System.Collections.Generic; 
using System.Diagnostics; 
using System.Linq; 
using System.Threading.Tasks; 
using Microsoft.Extensions.Logging; 
using Microsoft.AspNetCore.Mvc; 
using Lab.Models; 

namespace Lab.Controllers {
    public class HomeController:Controller {
        private readonly ILogger _logger; 

        public HomeController(ILogger < HomeController > logger) {
            _logger = logger; 
        }
        
        public IActionResult Index() {
            _logger.LogInformation("In Index we are!");
            return View(); 
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page."; 

            return View(); 
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page."; 

            return View(); 
        }

        public IActionResult Error() {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id??HttpContext.TraceIdentifier }); 
        }
    }
}
