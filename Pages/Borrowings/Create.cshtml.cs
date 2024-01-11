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

namespace RentACar.Pages.Borrowings
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
            var carList = _context.Car
                .Select(x => new
                {
                    x.ID,
                    CarName = x.Name
                });
            ViewData["CarID"] = new SelectList(carList, "ID", "CarName");
            ViewData["ClientID"] = new SelectList(_context.Client, "ID", "FullName");
            return Page();
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Borrowing == null || Borrowing == null)
            {
                return Page();
            }

            _context.Borrowing.Add(Borrowing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
