using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var filePath = Server.MapPath("~/App_Data/productos.json"); 
            var json = System.IO.File.ReadAllText(filePath);
            var productos = JsonConvert.DeserializeObject<List<Producto>>(json);

            return View(productos);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto nuevoProducto)
        {
            try
            {
                var pathToJson = Server.MapPath("~/App_Data/productos.json");
                var jsonData = System.IO.File.ReadAllText(pathToJson);
                var productos = JsonConvert.DeserializeObject<List<Producto>>(jsonData) ?? new List<Producto>();

                nuevoProducto.ProductoId = productos.Any() ? productos.Max(p => p.ProductoId) + 1 : 1;

                productos.Add(nuevoProducto);
                jsonData = JsonConvert.SerializeObject(productos, Formatting.Indented);
                System.IO.File.WriteAllText(pathToJson, jsonData);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
    }
}
