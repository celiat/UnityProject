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
    public class DetailsModel : PageModel
    {
        private readonly UnityProject.Data.CampaignContext _context;

        public DetailsModel(UnityProject.Data.CampaignContext context)
        {
            _context = context;
        }

        public Campaign Campaign { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Campaign = await _context.Campaign.Include(c => c.Roles).FirstOrDefaultAsync(m => m.ID == id);

            if (Campaign == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
