using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Unity.Models;
using UnityProject.Data;

namespace UnityProject
{
    public class CreateModel : PageModel
    {
        private readonly UnityProject.Data.CampaignContext _context;

        public CreateModel(UnityProject.Data.CampaignContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Campaign Campaign { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Campaign.Add(Campaign);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
