using WebApplication_Templates.Models;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Extensions
{
    public static class SystemSettingsMappingExtension
    {
        public static SystemSettings ToModel(this SystemSettingsViewModels model)
        {
            return new SystemSettings
            {
                Bg1 = model.Bg1,
                Bg2 = model.Bg2,
                Location = model.Location,
                LogoDark = model.LogoDark,
                LogoLight = model.LogoLight,
                ReservationImage=model.ReservationImage,
                id=model.id,
                FooterText= model.FooterText,
                IsActive=model.IsActive,


            };
        }
        public static SystemSettingsViewModels ToViewModel(this SystemSettings model)
        {
            return new SystemSettingsViewModels
            {
                Bg1 = model.Bg1,
                Bg2 = model.Bg2,
                Location = model.Location,
                LogoDark = model.LogoDark,
                LogoLight = model.LogoLight,
                ReservationImage = model.ReservationImage,
                id = model.id,
                FooterText = model.FooterText,
                IsActive = model.IsActive,

            };
        }
        public static List<SystemSettingsViewModels> ToViewModelList(this List<SystemSettings> model)
        {
            return model.Select(x=>x.ToViewModel()).ToList();
        }
        public static List<SystemSettings> ToModelList(this List<SystemSettingsViewModels> model)
        {
            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
