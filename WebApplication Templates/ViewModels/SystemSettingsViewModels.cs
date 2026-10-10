namespace WebApplication_Templates.ViewModels
{
    public class SystemSettingsViewModels
    {
        public string LogoDark { get; set; }
        public string LogoLight { get; set; }
        public string Bg1 { get; set; }
        public string Bg2 { get; set; }
        public string ReservationImage { get; set; }
        public string Location { get; set; }
        public string FooterText { get; set; }
        public int id { get; set; }
        public bool IsActive { get; set; } = true;
        public IFormFile? ImageFileLogoDark { get; set; }
        public IFormFile? ImageFileLogoLight { get; set; }
        public IFormFile? ImageFileBg1 { get; set; }
        public IFormFile? ImageFileBg2 { get; set; }
        public IFormFile? ImageFileReservationImage { get; set; }
    }
}
