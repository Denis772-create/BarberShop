using Barber_Shop_Project.Models;
using Barber_Shop_Project.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Barber_Shop_Project.Models.Repositories.Abstract;
using Barber_Shop_Project.Models.Repositories.EF;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Barber_Shop_Project.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private UserManager<User> _userManager;
        private ITeamRepositories _teamRepositories;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager, ITeamRepositories teeamRepositories)
        {
            _teamRepositories = teeamRepositories;
            _userManager = userManager;
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewData["Id"] = _userManager.GetUserId(User);
            return View();
        }

        [AllowAnonymous]
        public IActionResult Discounts()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Contacts()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Team()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Services()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string adress, string subj, string mess)
        {
            ServiceEmail service = new ServiceEmail();
            await service.SendEmailMessageAsync(adress, subj, mess);
            return RedirectToAction("Index");
        }
    }
}