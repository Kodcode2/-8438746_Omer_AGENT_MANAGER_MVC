using Agent_Management_Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Agent_Management_Client.Controllers
{
    public class TargetController : Controller
    {
        private readonly HttpClient _httpClient;
        public TargetController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // GET: TargetController
        public async Task<IActionResult> Index()
        {
            var res = await _httpClient.GetStringAsync("http://localhost:5120/Targets");
            var respons = JsonConvert.DeserializeObject<List<Target>>(res);
            return View(respons);

        }

        // GET: TargetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TargetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TargetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TargetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TargetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TargetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TargetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
