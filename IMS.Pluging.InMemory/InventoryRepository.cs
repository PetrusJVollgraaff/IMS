//using IMS.UseCases.PluginInterfaces;

namespace IMS.Pluging.InMemory
{
    public class InventoryRepository : UseCases.PluginInterfaces.IInventoryRepository
    {
        private List<CoreBusiness.Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<CoreBusiness.Inventory>()
            {
                new CoreBusiness.Inventory { }
            };
        }

        public Task<IEnumerable<CoreBusiness.Inventory>> GetInventoriesByNameAsync(string name) { 
        }
    }
}
