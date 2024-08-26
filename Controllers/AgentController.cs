using Agent_Management_Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Agent_Management_Client.Controllers
{
    public class AgentController : Controller
    {
        private readonly HttpClient _httpClient;
        public AgentController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // GET: AgentController1
        public async Task<IActionResult> Index()
        {
            var res = await _httpClient.GetStringAsync("http://localhost:5120/Agents");
            var respons = JsonConvert.DeserializeObject<List<Agent>>(res);
            return View(respons);
            
        }

        // GET: AgentController1/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var res = await _httpClient.GetStringAsync($"http://localhost:5120/missions/{id}");
            var respons = JsonConvert.DeserializeObject<Mission>(res);
        
            return View(respons);
        }

        // GET: AgentController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgentController1/Create
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

        // GET: AgentController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgentController1/Edit/5
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

        // GET: AgentController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgentController1/Delete/5
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
