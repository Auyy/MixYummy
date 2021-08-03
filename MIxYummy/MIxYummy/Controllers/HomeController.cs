using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MIxYummy.Models;
using MIxYummy.Repositories;

namespace MIxYummy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Privacy()
        {
            var mY_Profile_ShopRepository = new MY_Profile_ShopRepoitory();
            var mY_Profile_Shop = mY_Profile_ShopRepository.GetAll();
            return View(mY_Profile_Shop);
        }

        // GET: /Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Shop_Email,Shop_Password")] MY_Profile_Shop mY_Profile_Shop)
        {
            if (ModelState.IsValid)
            {
                var mY_Profile_ShopRepository = new MY_Profile_ShopRepoitory();
                mY_Profile_ShopRepository.Add(mY_Profile_Shop);
                return RedirectToAction(nameof(Privacy));
            }
            return View(mY_Profile_Shop);
        }


        public IActionResult Edit(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var mY_Profile_ShopRepository = new MY_Profile_ShopRepoitory();
            var movie = mY_Profile_ShopRepository.GetById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }


        //POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Shop_Email,Shop_Password")] MY_Profile_Shop mY_Profile_Shop)
        {
            if (id != mY_Profile_Shop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var mY_Profile_ShopRepository = new MY_Profile_ShopRepoitory();
                    mY_Profile_ShopRepository.Update(mY_Profile_Shop, id);
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!MY_Profile_ShopExists(mY_Profile_Shop.Id))
                    //{
                    //    return NotFound();
                    //}
                    //else
                    //{
                    //    throw;
                    //}
                }
                return RedirectToAction(nameof(Privacy));
            }
            return View(mY_Profile_Shop);
        }

    
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
