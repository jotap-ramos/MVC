﻿using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "Keyboard" };
            return View(item);
        }
        public IActionResult Edit(int itemId)
        {
            return Content("id= " + itemId);
        }
    }
}
