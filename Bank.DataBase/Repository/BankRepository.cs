using Bank.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank.DataBase.Repository
{
    public class BankRepository
    {
        private readonly BankDbContext _context;
        public BankRepository(BankDbContext context) 
        { 

            _context = context;

        }
            
        public async Task<List<Card>> GetCards()
        {
            var cardEntyties = await _context.Cards
                .AsNoTracking()
                .ToListAsync();


        }

    }
}
