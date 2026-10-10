using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace WebApplication_Templates.Models
    //Table Titles : Id / Title / Keyword

{
    public class Titles :BaseEntity
    {
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Desc { get; set; }

    }
}
