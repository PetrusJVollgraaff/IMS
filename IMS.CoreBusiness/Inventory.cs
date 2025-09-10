namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventroyId { get; set; }
        public string InventroyName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
