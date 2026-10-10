using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication_Templates.Models
{
    //Table OpeningTime: Id / Day / StartTime / EndTime / IsOpen

    public class OpeningTime :BaseEntity
    {
        public string Day {  get; set; }
        public string StartTime { get; set; }
        public bool IsOpen { get; set; }
        public string EndTime { get; set; }

    }
}
