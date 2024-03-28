using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore23.Controllers
{
    public class testVIEW : Controller
    {
        // GET: testVIEW
        public ActionResult test(int id)
        {
            return View();
        }

        // GET: testVIEW/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: testVIEW/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: testVIEW/Create
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

        // GET: testVIEW/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: testVIEW/Edit/5
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

        // GET: testVIEW/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: testVIEW/Delete/5
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
