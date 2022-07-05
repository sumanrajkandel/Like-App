namespace DemoAPIPostgres.Models
{
    public class MasterBase
    {
        public bool IsActive { get; set; } = default!;
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.UtcNow;
        public int CreatedBy { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
    }
}