using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Models;

namespace RentACar.Pages.Renters
{
    public class EditModel : PageModel
    {
        private readonly RentACar.Data.RentACarContext _context;

        public EditModel(RentACar.Data.RentACarContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Renter Renter { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Renter == null)
            {
                return NotFound();
            }

            var renter =  await _context.Renter.FirstOrDefaultAsync(m => m.ID == id);
            if (renter == null)
            {
                return NotFound();
            }
            Renter = renter;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Renter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RenterExists(Renter.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RenterExists(int id)
        {
          return (_context.Renter?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
