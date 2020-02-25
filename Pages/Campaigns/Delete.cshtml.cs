using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Unity.Models;
using UnityProject.Data;

namespace UnityProject
{
    public class DeleteModel : PageModel
    {
        private readonly UnityProject.Data.CampaignContext _context;

        public DeleteModel(UnityProject.Data.CampaignContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Campaign Campaign { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Campaign = await _context.Campaign.FirstOrDefaultAsync(m => m.ID == id);

            if (Campaign == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Campaign = await _context.Campaign.FindAsync(id);

            if (Campaign != null)
            {
                _context.Campaign.Remove(Campaign);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
