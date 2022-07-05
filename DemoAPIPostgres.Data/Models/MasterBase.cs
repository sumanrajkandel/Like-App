namespace DemoAPIPostgres.Models
{
    public class MasterBase
    {
        public bool IsActive { get; set; } = default!;
        public DateTime CreatedOn { get; set; } = default!;
        public int CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
    }
}