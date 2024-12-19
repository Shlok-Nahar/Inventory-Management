using System.ComponentModel.DataAnnotations;

namespace InventoryManagement
{
    public class SupplierEntity
    {
        [Key]
        public int supplierID { get; set; }
        public string name { get; set; } = "";
        public string? contactInfo { get; set; }

        public ICollection<ProductEntity> productEntities { get; set; } = new List<ProductEntity>();
    }
}