using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DIY_Site.Data;
using DIY_Site.Models;
using Microsoft.AspNetCore.Identity;

namespace DIY_Site.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context; // Replace with your actual DbContext class

        public UserController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Favorites()
        {
            var userId = _userManager.GetUserId(User);
            var userFavorites = await _context.UserFavorites
                                              .Where(uf => uf.UserId == userId)
                                              .Include(uf => uf.User)
                                              .Include(uf => uf.Project)
                                              .ToListAsync();

            return View(userFavorites);
        }
    }
}
