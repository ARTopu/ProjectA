using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBrideRepo
    {
        Task<IEnumerable<Bride>> GetAllBridesAsync();
        Task<Bride> GetBrideByIdAsync(int id);
        Task AddBrideAsync(Bride bride);
        Task UpdateBrideAsync(Bride bride);
        Task DeleteBrideAsync(int id);

    }
}
