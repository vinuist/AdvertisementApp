using Aca.AdvertisementApp.Business.Interfaces;
using Aca.AdvertisementApp.UI.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceService _providedServiceService;
        private readonly IAdvertisementService _advertisingService;
        public HomeController(IProvidedServiceService providedServiceService, IAdvertisementService advertisingService)
        {
            _providedServiceService = providedServiceService;
            _advertisingService = advertisingService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _providedServiceService.GetAllAsync();
            return this.ResponseView(response);
        }

        public async Task<IActionResult> HumanResource()
        {
            var response = await _advertisingService.GetActivesAsync();
             return this.ResponseView(response);
        }
    }
}
