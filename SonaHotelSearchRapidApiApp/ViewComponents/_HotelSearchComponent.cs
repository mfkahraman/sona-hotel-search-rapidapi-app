﻿using Microsoft.AspNetCore.Mvc;

namespace SonaHotelSearchRapidApiApp.ViewComponents
{
    public class _HotelSearchComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
