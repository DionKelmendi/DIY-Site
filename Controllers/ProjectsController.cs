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
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public ProjectsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Projects == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.Supplies)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            var userId = _userManager.GetUserId(User);

            if (userId != null)
            {
                var existingFavorite = await _context.UserFavorites
                    .FirstOrDefaultAsync(f => f.ProjectId == id && f.UserId == userId);

                ViewData["Favorited"] = existingFavorite != null;
            }

            var viewModel = new ProjectDetailsViewModel
            {
                Project = project,
                Supplies = project.Supplies
            };

            return View(viewModel);
        }

        // GET: Projects/Favorites/5
        public async Task<IActionResult> Favorites(int? id)
        {
            if (id == null || _context.Projects == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            var project = await _context.Projects
                .FirstOrDefaultAsync(m => m.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            var existingFavorite = await _context.UserFavorites
                .FirstOrDefaultAsync(f => f.ProjectId == id && f.UserId == userId);

            if (existingFavorite != null)
            {
                // Delete the existing favorite
                _context.UserFavorites.Remove(existingFavorite);
            }
            else
            {
                // Create a new UserFavorites entry
                var userFavorite = new UserFavorites
                {
                    ProjectId = project.Id,
                    UserId = userId
                };

                _context.UserFavorites.Add(userFavorite);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = id });
        }

    }
}
