using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
        Task<Inventory> GetInventoryByIdAsync(int inventoryId);
        Task UpdateInventoryAsync(Inventory inventory);
    }
}
