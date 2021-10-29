using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NbgHfrCore.Services;
using NbgHfrCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbgHfrMVC.Controllers

{
    public class PropertyController : Controller
    {
        private readonly IHfrService hfrService;
        //sos
        public PropertyController(IHfrService hrService)
        {
            this.hfrService = hrService;
        }

        // GET: PropertyController
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> List()
        {
            List<Property> properties = await hfrService.GetProperty();
            return View(properties);

        }


        // GET: PropertyController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Property property = await hfrService.GetProperty(id);

            return View(property);
        }

        // GET: PropertyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Property proper)
        {
            try
            {
                Property prop = await hfrService.CreateProperty(proper);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PropertyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PropertyController/Edit/5
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

        // GET: PropertyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PropertyController/Delete/5
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
