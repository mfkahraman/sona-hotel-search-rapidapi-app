using Microsoft.AspNetCore.Mvc;

namespace SonaHotelSearchRapidApiApp.ViewComponents
{
    public class _HotelSearchComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // You can pass any model or data to the view if needed
            return View();
        }
    }
}
