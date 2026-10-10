namespace WebApplication_Templates.ViewModels
{
    public class OpeningTimeFullViewModels
    {
        public string Day { get; set; }
        public string StartTime { get; set; }
        public bool IsOpen { get; set; }
        public string EndTime { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; internal set; }
        public List<OpeningTimeViewModels> list { get; set; }
        public int DeleteId { get; set; }
    }
}
