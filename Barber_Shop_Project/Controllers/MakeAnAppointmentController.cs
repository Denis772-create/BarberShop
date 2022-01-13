using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barber_Shop_Project.Models;
using Barber_Shop_Project.Models.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Barber_Shop_Project.Controllers
{
    public class MakeAnAppointmentController : Controller
    {
        private readonly ITeamRepositories _teamRepositories;
        private readonly IUserRepositories _userRepositories;
        private readonly IOrdersRepositories _ordersRepositories;

        public MakeAnAppointmentController(ITeamRepositories teamRepositories, IUserRepositories userRepositories, IOrdersRepositories ordersRepositories)
        {
            _teamRepositories = teamRepositories;
            _userRepositories = userRepositories;
            _ordersRepositories = ordersRepositories;
        }

        public IActionResult Index()
        {
            string[] hairNames = new[] { "Styling", "Children's haircut", "Straight razor", "Beard trim", "Haircut with a clipper", "A haircut" };
            SelectList hairList = new SelectList(hairNames, hairNames[5]);
            ViewBag.hairList = hairList;

            var arrNameEmpl = _teamRepositories.GetEmployeesAsync().Result.Select(a => a.Fname + " " + a.Lname);
            SelectList selectEmplList = new SelectList(arrNameEmpl, arrNameEmpl.FirstOrDefault());
            ViewBag.selectEmplList = selectEmplList;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Order order)
        {
            if (ModelState.IsValid)
            {
                order.Date = DateTime.Now;
                order.Employees = _teamRepositories.GetEmployeesAsync().Result
                    .Where(a => (a.Fname + " " + a.Lname) == order.Employees.Fname)
                    .Select(b => b).ToList().FirstOrDefault();
                order.Users = _userRepositories.GetUserAsync(HttpContext.User.Identity?.Name).Result;
                if (order.Employees != null)
                    order.EmployeesId = order.Employees.Id;
                order.UsersId = order.Users.Id;

                _ordersRepositories.AddOrderAsync(order);

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}