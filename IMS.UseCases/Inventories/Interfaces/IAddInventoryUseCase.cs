using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories.Interfaces
{
    internal interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}