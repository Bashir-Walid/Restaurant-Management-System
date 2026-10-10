namespace WebApplication_Templates.Models
{
    public class BaseEntity
    {
        public int id { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public bool IsActive { get; set; } = true;
        public string? CreatedBy { get; set; }
        public string? CreatedData { get; set; }

        public string? UpdatedBy { get; set; }

        public string? UpdatedData { get; set; }
    }
}
    