using Microsoft.EntityFrameworkCore;
using Anotations.Context;
using Anotations.Models;
using Anotations.Repository.Interfaces;

namespace Anotations.Repository
{
    public class AnotationRepository : IAnotationRepository
    {
        //instancia do nosso contexto
        private readonly AppDbContext _context;
        public AnotationRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Anotation> GetAnotations => _context.Anotations.Where(a => a != null);
    }
}