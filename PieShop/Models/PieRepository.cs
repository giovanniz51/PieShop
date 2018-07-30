using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {

        private readonly AppDbContext _context;

        public PieRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pie> Pies => _context.Pies.Include(c => c.Category);

        public IEnumerable<Pie> PiesOfTheWeek => _context.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);

        public Pie GetPieById(int pieId)
        {
            return _context.Pies.SingleOrDefault(p => p.PieId == pieId);
        }
    }
}
