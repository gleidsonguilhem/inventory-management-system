using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMS.UseCases.Inventories
{
    internal class AddInventoryUseCase : IAddInventoryUseCase
    {
        private IInventoryRepository inventoryRepository;

        public AddInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;

        }
        public async Task ExecuteAsync(Inventory inventory)
        {
            await this.inventoryRepository.AddInventoryAsync(inventory);
        }

    }
}
