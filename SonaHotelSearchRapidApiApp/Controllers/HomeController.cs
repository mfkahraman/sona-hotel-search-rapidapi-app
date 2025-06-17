using Microsoft.AspNetCore.Mvc;

namespace SonaHotelSearchRapidApiApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SearchHotels(string query)
        {
            // Here you would typically call a service to search for hotels based on the query
            // For now, we will just return the query as a simple example
            ViewBag.Query = query;
            return View("SearchResults");
        }

        public IActionResult Hotels()
        {
            // This action could be used to display a list of hotels
            // For now, we will just return a view
            return View();
        }


    }
}
