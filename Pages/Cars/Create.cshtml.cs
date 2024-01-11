using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACar.Data;
using RentACar.Models;

namespace RentACar.Pages.Cars
{
    public class CreateModel : PageModel
    {
        private readonly RentACar.Data.RentACarContext _context;

        public CreateModel(RentACar.Data.RentACarContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["RenterID"] = new SelectList(_context.Set<Renter>(), "ID", "RenterName");
            return Page();
        }

        [BindProperty]
        public Car Car { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Car == null || Car == null)
            {
                return Page();
            }

            _context.Car.Add(Car);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
