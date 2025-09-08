using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public class IInventoryRepository
    {
        internal async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
