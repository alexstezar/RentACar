using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Models;

namespace RentACar.Pages.Renters
{
    public class DeleteModel : PageModel
    {
        private readonly RentACar.Data.RentACarContext _context;

        public DeleteModel(RentACar.Data.RentACarContext context)
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

            var renter = await _context.Renter.FirstOrDefaultAsync(m => m.ID == id);

            if (renter == null)
            {
                return NotFound();
            }
            else 
            {
                Renter = renter;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Renter == null)
            {
                return NotFound();
            }
            var renter = await _context.Renter.FindAsync(id);

            if (renter != null)
            {
                Renter = renter;
                _context.Renter.Remove(Renter);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
