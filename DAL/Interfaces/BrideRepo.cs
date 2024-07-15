using DAL.Data;
using DAL.Entities;
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

        public Task<Bride> AddBrideAsync(Bride bride)
        {
            
        }

        public Task<Bride> DeleteBrideAsync(int id)
        {
            
        }

        public Task<IEnumerable<Bride>> GetAllBridesAsync()
        {
            
        }

        public Task<Bride> GetBrideByIdAsync(int id)
        {
            
        }

        public Task<Bride> UpdateBrideAsync(Bride bride)
        {
            
        }
    }
}
