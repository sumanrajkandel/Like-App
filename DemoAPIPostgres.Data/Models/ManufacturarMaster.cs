using System.ComponentModel.DataAnnotations;
#nullable disable
namespace DemoAPIPostgres.Models
{
    public class ManufacturarMaster : MasterBase
    {
        [Key]
        public int ManufacturarId { get; set; }

        [Required]
        [StringLength(3)]
        public string ManufacturarCode { get; set; }
        public string ManufacturarName { get; set; }
        public string ManufacturarDesc { get; set; }

        //address ka master and cascaded


    }
}