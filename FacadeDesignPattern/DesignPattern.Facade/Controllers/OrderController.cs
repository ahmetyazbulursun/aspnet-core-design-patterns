﻿using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderDetailStart(int customerId, int productId, int orderId, int amount, decimal price)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrderDetail(customerId, productId, orderId, amount, price);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderStart(int customerId)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerId);
            return RedirectToAction("Index");
        }
    }
}
