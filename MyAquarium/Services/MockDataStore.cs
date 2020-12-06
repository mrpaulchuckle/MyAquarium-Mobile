using MyAquarium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAquarium.Services
{
    public class MockDataStore : IDataStore<TankModel>
    {
        private readonly List<TankModel> TankModels;

        public MockDataStore()
        {
            TankModels = new List<TankModel>()
            {
                new TankModel { ID = 1, Name = "First item", Description="This is an item description.", IsFavourite = false },
                new TankModel { ID = 2, Name = "Second item", Description="This is an item description.", IsFavourite = true },
                new TankModel { ID = 3, Name = "Third item", Description="This is an item description.", IsFavourite = false },
                new TankModel { ID = 4, Name = "Fourth item", Description="This is an item description.", IsFavourite = false },
                new TankModel { ID = 5, Name = "Fifth item", Description="This is an item description.", IsFavourite = false },
                new TankModel { ID = 6, Name = "Sixth item", Description="This is an item description.", IsFavourite = false }
            };
        }

        public async Task<bool> AddTank(TankModel tank)
        {
            tank.ID = TankModels.Count + 1;
            TankModels.Add(tank);

            return await Task.FromResult(true);
        }

        public async Task<bool> SetTankAsFavourite(TankModel tank)
        {
            TankModels.All(x => x.IsFavourite = false);
            TankModels.Where(x => x.ID == tank.ID).Select(x => x.IsFavourite = true);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateTankAsync(TankModel tank)
        {
            TankModel myExistingTank = TankModels.Where((TankModel arg) => arg.ID == tank.ID).FirstOrDefault();
            TankModels.Remove(myExistingTank);
            TankModels.Add(tank);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteTankAsync(int? id)
        {
            TankModel myTankToDelete = TankModels.Where((TankModel arg) => arg.ID == id).FirstOrDefault();
            TankModels.Remove(myTankToDelete);

            return await Task.FromResult(true);
        }

        public async Task<TankModel> GetTankAsync(int? id)
        {
            return await Task.FromResult(TankModels.FirstOrDefault(s => s.ID == id));
        }

        public async Task<IEnumerable<TankModel>> GetTanksAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(TankModels);
        }
    }
}