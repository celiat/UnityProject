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
    public class IndexModel : PageModel
    {
        private readonly UnityProject.Data.CampaignContext _context;

        public IndexModel(UnityProject.Data.CampaignContext context)
        {
            _context = context;
        }

        public IList<Campaign> Campaign { get;set; }

        public async Task OnGetAsync()
        {
            Campaign = await _context.Campaign.Include(c => c.Roles).ToListAsync();
        }
    }
}
