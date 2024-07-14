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
        Task<Bride> AddBrideAsync(Bride bride);
        Task<Bride> UpdateBrideAsync(Bride bride);
        Task<Bride> DeleteBrideAsync(int id);

    }
}
