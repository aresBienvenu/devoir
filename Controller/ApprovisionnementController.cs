using Microsoft.AspNetCore.Mvc;
using TonProjet.Models;
using TonProjet.Services;
using System.Threading.Tasks;

namespace TonProjet.Controllers
{
    public class ApprovisionnementController : Controller
    {
        private readonly IApprovisionnementService _service;

        public ApprovisionnementController(IApprovisionnementService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _service.GetAllAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Approvisionnement appro)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(appro);
                return RedirectToAction(nameof(Index));
            }
            return View(appro);
        }
    }
}
