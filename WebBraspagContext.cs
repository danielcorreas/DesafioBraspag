using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebBraspag.Solution;

namespace WebBraspag.Models
{
    public class WebBraspagContext : DbContext
    {
        public WebBraspagContext (DbContextOptions<WebBraspagContext> options)
            : base(options)
        {
        }

        public DbSet<WebBraspag.Solution.Formulario> Formulario { get; set; }
    }
}
