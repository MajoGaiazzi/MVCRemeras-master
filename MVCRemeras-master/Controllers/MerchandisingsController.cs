using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCMerchandising.Data;
using MVCMerchandising.Models;

namespace MVCMerchandising.Controllers
{
    public class MerchandisingsController : Controller
    {
        private readonly MVCMerchandisingContext _context;

        public MerchandisingsController(MVCMerchandisingContext context)
        {
            _context = context;
        }

        // GET: Merchandisings
        public async Task<IActionResult> Index(string MerchanTalles, string SearchString)

        {

            IQueryable<string> genreQuery = from m in _context.Merchandising

                                            orderby m.Talles

                                            select m.Talles;


            var Product = from m in _context.Merchandising

                         select m;


            if (!string.IsNullOrEmpty(SearchString))

            {

                Product = Product.Where(s => s.Producto.Contains(SearchString));

            }


            if (!string.IsNullOrEmpty(MerchanTalles))

            {

                Product = Product.Where(x => x.Talles == MerchanTalles);

            }


            var ProductGenreVM = new MerchanTalleViewModel

            {

                Talles = new SelectList(await genreQuery.Distinct().ToListAsync()),

                Productos = await Product.ToListAsync()

            };


            return View(ProductGenreVM);

        }

        // GET: Merchandisings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandising = await _context.Merchandising
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchandising == null)
            {
                return NotFound();
            }

            return View(merchandising);
        }

        // GET: Merchandisings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Merchandisings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Producto,Talles,Descripcion,Precio,Colores,Imagen")] Merchandising merchandising)
        {
            if (ModelState.IsValid)
            {
                _context.Add(merchandising);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(merchandising);
        }

        // GET: Merchandisings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandising = await _context.Merchandising.FindAsync(id);
            if (merchandising == null)
            {
                return NotFound();
            }
            return View(merchandising);
        }

        // POST: Merchandisings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Producto,Talles,Descripcion,Precio,Colores,Imagen")] Merchandising merchandising)
        {
            if (id != merchandising.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(merchandising);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MerchandisingExists(merchandising.Id))
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
            return View(merchandising);
        }

        // GET: Merchandisings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandising = await _context.Merchandising
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchandising == null)
            {
                return NotFound();
            }

            return View(merchandising);
        }

        // POST: Merchandisings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var merchandising = await _context.Merchandising.FindAsync(id);
            _context.Merchandising.Remove(merchandising);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MerchandisingExists(int id)
        {
            return _context.Merchandising.Any(e => e.Id == id);
        }
    }
}
