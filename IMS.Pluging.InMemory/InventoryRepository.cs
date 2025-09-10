using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.Pluging.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory {InventroyId = 1, InventroyName = "Bike Seat", Quantity=10, Price=2 },
                new Inventory {InventroyId = 2, InventroyName = "Bike Body", Quantity=10, Price=15 },
                new Inventory {InventroyId = 1, InventroyName = "Bike Wheels", Quantity=20, Price=8 },
                new Inventory {InventroyId = 1, InventroyName = "Bike Pedels", Quantity=20, Price=1 },
            };
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name) {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.InventroyName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
