using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SonaHotelSearchRapidApiApp.Models;
using static SonaHotelSearchRapidApiApp.Models.HotelSearchResponseModel;

namespace SonaHotelSearchRapidApiApp.Controllers
{
    public class HomeController() : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Hotels()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Hotels(string checkIn, string checkOut, int adults, int roomQty)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-755070&search_type=CITY&arrival_date={checkIn}&departure_date={checkOut}&adults={adults}&room_qty={roomQty}"),

                Headers =
                {
                    { "x-rapidapi-key", "9b063ae1d3msh4540ffaa7b69c52p16e4b6jsn1a9e5d81098b" },
                    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                },
            };

            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var deserializedValues = JsonConvert.DeserializeObject<HotelSearchResponseModel.Rootobject>(json);
            var values = deserializedValues.data.hotels.ToList();
            return View(values);
        }


    }
}
