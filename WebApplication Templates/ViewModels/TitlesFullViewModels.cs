namespace WebApplication_Templates.ViewModels
{
    public class TitlesFullViewModels
    {
        public string Title { get; set; }
        public string Keyword { get; set; }
        public bool IsActive { get; set; }
        public int id { get; set; }
        public List<TitlesViewModels> list { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleted { get; set; }
        public int DeleteId { get; set; }
        public string Desc { get; set; }

    }
}
