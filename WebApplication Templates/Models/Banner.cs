namespace WebApplication_Templates.Models
{
    //(one record) Table Banner: Id / Image / Title / Brief / Desc / IsPrimary

    public class Banner :BaseEntity
    {
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public bool IsPrimary { get; set; }
    }
}
