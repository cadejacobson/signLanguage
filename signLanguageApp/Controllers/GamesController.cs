using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using signLanguageApp.Data;
using signLanguageApp.ViewModels;

namespace signLanguageApp.Controllers
{
    public class GamesController : Controller
    {
        private readonly signLanguageAppContext _context;

        public GamesController(signLanguageAppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var signs = from s in _context.Sign
                        select s;

            var collections = _context.Sign.Select(ts => ts.Collection).Distinct().ToList();


            var SignNameViewModel = new SignViewModel
            {
                Signs = await signs.ToListAsync(),
                Collections = collections
            };

            //This has to group by collection :) Thanks

            return View(SignNameViewModel);
        }


        public IActionResult Letters()
        {
            return View();
        }

        public async Task<IActionResult> PickTwo(string collection)
        {
            var signs = from s in _context.Sign
                        where s.Collection == collection
                        select s;

            var SignNameViewModel = new SignViewModel
            {
                Signs = await signs.ToListAsync(),
            };

            return View();
        }
    }
}
