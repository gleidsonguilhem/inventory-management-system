using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;

namespace IMS.UseCases
{
    public class ViewInventoryByNameUseCase : IViewInventoryByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoryByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }


        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoriesByNameAsync(name);
        }

    }
}