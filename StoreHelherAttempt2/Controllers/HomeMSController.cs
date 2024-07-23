using Microsoft.AspNetCore.Mvc;
using StoreHelherAttempt2.Models;
using System.Diagnostics;

namespace StoreHelherAttempt2.Controllers
{
	public class HomeMSController : Controller
	{
		private readonly ILogger<HomeMSController> _logger;

		public HomeMSController(ILogger<HomeMSController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
