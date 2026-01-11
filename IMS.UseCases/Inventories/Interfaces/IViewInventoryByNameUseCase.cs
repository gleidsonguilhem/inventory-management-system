using IMS.CoreBusiness;

namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IViewInventoryByNameUseCase
    {
        public Task<IEnumerable<Inventory>> ExecuteAsync(string? name);
    }
}