using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DanfossTestAspProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DanfossTestAspProject.Controllers
{
    public class HomeController : Controller
    {
        private DanfossClientsContext db;
        private Client client;

        public HomeController(DanfossClientsContext context)
        {
            db = context;
        }

        public async Task<IActionResult> CurrentClients()
        {
            return View(await db.Clients.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult NewClient()
        {
            client = new Client();
            client.SpecialOffers.Add(new SpecialOffer());
            return View(client);
        }

        [Route("newClientToAdd")]
        public async Task<IActionResult> NewClientToAdd(Client user)
        {
            if (ModelState.IsValid)
            {
                var client = db.Clients.FirstOrDefault(x => x.IdentificationNumber == user.IdentificationNumber);
                await db.Clients.AddAsync(user);
                await db.SaveChangesAsync();
                if (client != null)
                {
                    return new JsonResult("Требуется согласование");
                }
                else
                {
                    return new JsonResult("Новый клиент добавлен");
                }
            }
            else
            {
                return new JsonResult("Ошибка данных");
            }

        }

        /// <summary>
        /// Новая скидка.
        /// </summary>
        /// <param name="user">Модель с текущей скидкой.</param>
        /// <returns>Новый список скидок.</returns>
        [Route("newSaleToAdd")]
        public IActionResult NewSaleToAdd([Bind("SpecialOffers")] Client user)
        {
            if (ModelState.IsValid)
            {
                user.SpecialOffers.Add(new SpecialOffer());
            }
            return PartialView("SpecialOffer", user);
        }
    }
}
