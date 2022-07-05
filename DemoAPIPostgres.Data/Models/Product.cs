using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPIPostgres.Models
{
#nullable disable
    public class Product : MasterBase
    {       
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(3)]
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime ProductMFD { get; set; }
        public DateTime ProductExpDate { get; set; }

        [ForeignKey("Product_ManufacturarMaster_ManufacturarId")]
        public int ManufacturarId { get; set; }


 


    }
}
