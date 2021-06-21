using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2004E_WAD.Models;

namespace T2004E_WAD.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            //truyen theo viewData
            //ViewData["Message"] = "Hello world";
            //ViewData["CurrentTime"] = DateTime.Now;

            ViewBag.Message = "Fucker";
            ViewBag.Current = DateTime.Now;

            Category category = new Category() { Name = "Son", Image = "Son.png", Description = "Son Description" };
            return View(category);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else {
                    return View(category);
                }

                
            }
            catch
            {
                return View(category);
            }
        }


        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Brand()
        {
            
            return View();
        }
        public ActionResult Product()
        {
            //Product product = new Product() { Name = "the silence of the lambs", Author = " Thomas Harris", Year = "1991", Price = "4$" };
            return View();
        }
        [HttpPost]

        public ActionResult Product(Product product)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(product);
                }


            }
            catch
            {
                return View(product);
            }
        }
    }
}
