using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public class BrideRepo : IBrideRepo
    {
        private readonly AppDbContext _appDbContext;

        public BrideRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddBrideAsync(Bride bride)
        {
             _appDbContext.Brides.Add(bride);
            await _appDbContext.SaveChangesAsync();
            
        }

        public async Task DeleteBrideAsync(int id)
        {
           var bride = _appDbContext.Brides.FindAsync(id);
            if(bride != null)
            {
                _appDbContext.Remove(bride);
                await _appDbContext.SaveChangesAsync();
            }
            
        }

        public async Task<IEnumerable<Bride>> GetAllBridesAsync()
        {
            return await _appDbContext.Brides.ToListAsync();
            
        }

        public async Task<Bride> GetBrideByIdAsync(int id)
        {
            return await _appDbContext.Brides.FindAsync(id);  
        }

        public  async Task UpdateBrideAsync(Bride bride)
        {
            _appDbContext.Entry(bride).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
        }
    }
}
