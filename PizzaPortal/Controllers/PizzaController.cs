﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPortal.Models;
using System.Configuration;

namespace PizzaPortal.Controllers
{
    public class PizzaController : Controller
    {
        List<PizzaDetails> pizzaDetails;
       static List<Order> orders = new List<Order>();
        public PizzaController()
        {
            pizzaDetails = new List<PizzaDetails>();
            pizzaDetails.Add(new PizzaDetails() { Id = 1, Name = "Pizza1", Price = 100, Rating = 4.4 });
            pizzaDetails.Add(new PizzaDetails() { Id = 2, Name = "Pizza2", Price = 200, Rating = 4.4 });
            pizzaDetails.Add(new PizzaDetails() { Id = 3, Name = "Pizza3", Price = 300, Rating = 4.4 });
            pizzaDetails.Add(new PizzaDetails() { Id = 4, Name = "Pizza4", Price = 400, Rating = 4.4 });
            pizzaDetails.Add(new PizzaDetails() { Id = 5, Name = "Pizza5", Price = 500, Rating = 4.4 });
        }
        // GET: PizzaController1
        public ActionResult Index()
        {
            return View(pizzaDetails);
        }

        public ActionResult AddToCart(int id)
        {
            TempData["id"] = id;
           var ans =  pizzaDetails.Find(x => x.Id == id);
            return View(ans);
        }
        [HttpPost]
        public ActionResult AddToCart(IFormCollection collection)
        {
            // int qty = Convert.ToInt32(Request.Form["qty"]);
            Order order = new Order();
            int id = Convert.ToInt32(TempData["id"]);
            order.Quantity = Convert.ToInt32(Request.Form["qty"]);
            var ans = pizzaDetails.Find(x => x.Id == id);
            order.ProdId = ans.Id;
            order.ProdName = ans.Name;
            order.Total = ans.Price * order.Quantity;
            orders.Add(order);
            return RedirectToAction("Checkout");
        }

        public ActionResult Checkout()
        {
            return View(orders);
        }
        // GET: PizzaController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController1/Create
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

        // GET: PizzaController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController1/Edit/5
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

        // GET: PizzaController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController1/Delete/5
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