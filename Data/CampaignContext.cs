using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unity.Models;

namespace UnityProject.Data
{
    public class CampaignContext : DbContext
    {
        public CampaignContext (DbContextOptions<CampaignContext> options)
            : base(options)
        {
        }
        [BindProperty]
        public DbSet<Unity.Models.Campaign> Campaign { get; set; }
    }
}
