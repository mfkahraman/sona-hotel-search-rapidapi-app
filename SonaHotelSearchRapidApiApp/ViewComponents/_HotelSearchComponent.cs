using Microsoft.AspNetCore.Mvc;

namespace SonaHotelSearchRapidApiApp.ViewComponents
{
    public class _HotelSearchComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // You can pass any model or data to the view if needed
            return View();
        }
    }
}
