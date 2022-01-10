﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;
using SEIIIAssignment.Models;

namespace SEIIIAssignment.Controllers
{
    public class ItemsController : Controller
    {
        private IWebHostEnvironment _environment;
        private readonly SEIIIContext _context;

        public ItemsController(SEIIIContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [Authorize(Roles = "Admin,Client")]
        // GET: Items
        public async Task<IActionResult> Index(string searchString)
        {
            ViewBag.Message = TempData["Message"];
            ViewData["ItemDetails"] = searchString;
         
            var items = from i in _context.Items
                select i;
            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(i=>i.ArchiveStatus==0 && i.ProductName.Contains(searchString) ||
                                         i.Weight.ToString().Contains(searchString) ||
                                         i.Category.CategoryName.Contains(searchString) ||
                                         i.Classification.ClassificationName.Contains(searchString)||i.Artist.Contains(searchString)||i.EstimatedAmount.ToString().Contains(searchString)||i.StartDate.ToString().Contains(searchString))
            .Include(i => i.Category).Include(i => i.Classification);
                return View(await items.AsNoTracking().ToListAsync());
            }

            var SEIIIContext = _context.Items.Where(i=>i.ArchiveStatus==0).Include(i => i.Category).Include(i => i.Classification);
            return View(await SEIIIContext.ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.Message = TempData["Message"];
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.Classification)
                .Include(i => i.Category).Include(i=>i.Boughtby).Include(i=>i.Postedby).FirstOrDefaultAsync(i => i.ItemId == id);
            // ViewBag.Auctions =  _context.Auctions.Include(a=>a.Bids).ThenInclude(b=>b.Bidder).Include(a=>a.Bids).ThenInclude(b=>b.Amount).Where(i => i.ItemId==id);
            ViewBag.Bids = _context.Bids.Where(b => b.ItemId == id).Include(b=>b.Bidder);
                
        
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        [Authorize(Roles = "Admin,Client")]
        public IActionResult Create()
        {
            ViewData["CategoryName"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["ClassificationName"] =
                new SelectList(_context.Classifications, "ClassificationId", "ClassificationName");
            ViewData["BoughtbyId"] = new SelectList(_context.Users, "UserId", "Name");
            ViewData["PostedbyId"] = new SelectList(_context.Users, "UserId", "Name");
            return View();
        }
        [Authorize(Roles = "Admin,Client")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind(
                "ItemId,ProducedYear,TextualDescription,Image,CreatedAt,Artist,ItemType,Material,Weight,Height,Length,Medium,IsFramed,Width,ProductName,CategoryId,ClassificationId,StartDate,EstimatedAmount")]
            Item item)


        {
            if (ModelState.IsValid)
            { 
                var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid)?.Value;
                var sellerId = Int32.Parse(userId);
                var files = HttpContext.Request.Form.Files;
                foreach (var image in files)
                {
                    if (image != null && image.Length > 0)
                    {
                        var file = image;
                        var uploads = Path.Combine(_environment.WebRootPath, "uploads\\img\\products");

                        if (file.Length > 0)
                        {
                            var fileName =  Guid.NewGuid().ToString().Replace("-", "") +
                                           Path.GetExtension(file.FileName);
                           
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                
                            }
                            item.Image = fileName;
                            
                        }
                    }
                }

                DateTime date = (DateTime) item.StartDate;
                item.EndDate = date.AddMinutes(1436);
                item.CreatedAt = DateTime.Now;
                item.PostedbyId = sellerId;
                item.ArchiveStatus = 0;
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoryName"] =
                new SelectList(_context.Categories, "CategoryId", "CategoryName", item.CategoryId);
            ViewData["ClassificationName"] = new SelectList(_context.Classifications, "ClassificationId",
                "ClassificationName", item.ClassificationId);
            return View(item);
        }

        // GET: Items/Edit/5
        [Authorize(Roles = "Admin,Client")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            ViewData["CategoryName"] = new SelectList(_context.Categories, "CategoryId", "CategoryName",
                item.Category.CategoryName);
            ViewData["ClassificationName"] = new SelectList(_context.Classifications, "ClassificationId",
                "ClassificationName", item.ClassificationId);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind(
                "ItemId,ProducedYear,TextualDescription,Image,CreatedAt,Artist,ItemType,Material,Weight,Height,Length,Medium,IsFramed,Width,ProductName,CategoryId,ClassificationId,StartDate,EstimatedAmount")]
            Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    DateTime date = (DateTime) item.StartDate;
                    item.EndDate = date.AddMinutes(1436);
                 
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoryName"] =
                new SelectList(_context.Categories, "CategoryId", "CategoryName", item.CategoryId);
            ViewData["ClassificationName"] = new SelectList(_context.Classifications, "ClassificationId",
                "ClassificationName", item.ClassificationId);
            return View(item);
        }

        // GET: Items/Delete/5

        [Authorize(Roles = "Admin,Client")]
        // POST: Items/Delete/5

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
       

        public async Task<IActionResult> Archive(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemData = await _context.Items.FindAsync(id);
            itemData.ArchiveStatus = 1;
            if (itemData == null)
            {
                return NotFound();
            }

            _context.Update(itemData);
            await _context.SaveChangesAsync();
   
            return RedirectToAction(nameof(Index));
        }
     
        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.ItemId == id);
        }
    }
}