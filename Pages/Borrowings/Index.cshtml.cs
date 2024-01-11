using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RentACar.Data;
using RentACar.Models;

namespace RentACar.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly RentACar.Data.RentACarContext _context;

        public IndexModel(RentACar.Data.RentACarContext context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Borrowing != null)
            {
                Borrowing = await _context.Borrowing
                .Include(b => b.Car)
                .Include(b => b.Client).ToListAsync();
            }
        }
    }
}
