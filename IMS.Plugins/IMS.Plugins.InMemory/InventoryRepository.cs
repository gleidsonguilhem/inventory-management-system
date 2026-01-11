using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory { InventoryId = 1, InventoryName = "Bike Seat", Price = 2, Quantity = 2 },
                new Inventory { InventoryId = 2, InventoryName = "Bike Body", Price = 2, Quantity = 2 },
                new Inventory { InventoryId = 3, InventoryName = "Bike Wheels", Price = 2, Quantity = 2 },
                new Inventory { InventoryId = 4, InventoryName = "Bike Pedals", Price = 2, Quantity = 2 },
            };
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
