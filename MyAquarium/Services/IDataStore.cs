using MyAquarium.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyAquarium.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddTank(TankModel tank);
        Task<bool> UpdateTankAsync(TankModel tank);
        Task<bool> DeleteTankAsync(int? id);
        Task<TankModel> GetTankAsync(int? id);
        Task<IEnumerable<TankModel>> GetTanksAsync(bool forceRefresh = false);
    }
}
