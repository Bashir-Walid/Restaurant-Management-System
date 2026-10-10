namespace WebApplication_Templates.ViewModels
{
    public class OpeningTimeViewModels
    {
        public string Day { get; set; }
        public string StartTime { get; set; }
        public bool IsOpen { get; set; }
        public string EndTime { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
