using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository<SystemSettings> SystemSettingsRepository;
        IRepository<Slider> SliderRepository;
        IRepository<About> AboutRepository;
        IRepository<Titles> TitlesRepository;
        IRepository<TransactionReservation> TransactionReservationRepository;
        private readonly IRepository<TransactionReservation> _transactionContactUs;
        IRepository<Feedback> FeedbackRepository;
        IRepository<Banner> BannerRepository;
        IRepository<Partners> PartnersRepository;
        IRepository<MasterSocialMedia> MasterSocialMediaRepository;
        IRepository<MasterContactUs> MasterContactUsRepository;
        IRepository<OpeningTime> OpeningTimeRepository;
        IRepository<TransactionNewsLetter> TransactionNewsLetterRepository;
        private readonly IRepository<TransactionNewsLetter> _atransactionContactUs;

        IRepository<Services> ServicesRepository;
        IRepository<MenuCategory> MenuCategoryRepository;
        IRepository<MenuItems> MenuItemsRepository;
        IRepository<MasterTransactionContactUs> MasterTransactionContactUsRepository;
        private readonly IRepository<MasterTransactionContactUs> _trsansactionContactUs;





        public HomeController(ILogger<HomeController> logger, IRepository<SystemSettings> systemSettingsRepository, IRepository<Slider> sliderRepository, IRepository<About> aboutRepository, IRepository<Titles> titlesRepository, IRepository<TransactionReservation> transactionContactUs, IRepository<TransactionReservation> transactionReservationRepository, IRepository<Feedback> feedbackRepository, IRepository<Banner> bannerRepository, IRepository<Partners> partnersRepository, IRepository<MasterSocialMedia> masterSocialMediaRepository, IRepository<MasterContactUs> masterContactUsRepository, IRepository<OpeningTime> openingTimeRepository, IRepository<TransactionNewsLetter> transactionNewsLetter, IRepository<TransactionNewsLetter> atransactionContactUs, IRepository<Services> servicesRepository, IRepository<MenuCategory> menuCategoryRepository, IRepository<MenuItems> menuItemsRepository, IRepository<MasterTransactionContactUs> trsansactionContactUs, IRepository<MasterTransactionContactUs> masterTransactionContactUsRepository)
        {
            _logger = logger;
            SystemSettingsRepository = systemSettingsRepository;
            SliderRepository = sliderRepository;
            AboutRepository = aboutRepository;
            TitlesRepository = titlesRepository;
            _transactionContactUs = transactionContactUs;
            TransactionReservationRepository = transactionReservationRepository;
            FeedbackRepository = feedbackRepository;
            BannerRepository = bannerRepository;
            PartnersRepository = partnersRepository;
            MasterSocialMediaRepository = masterSocialMediaRepository;
            MasterContactUsRepository = masterContactUsRepository;
            OpeningTimeRepository = openingTimeRepository;
            TransactionNewsLetterRepository = transactionNewsLetter;
            _atransactionContactUs = atransactionContactUs;
            ServicesRepository = servicesRepository;
            MenuCategoryRepository = menuCategoryRepository;
            MenuItemsRepository = menuItemsRepository;
            _trsansactionContactUs = trsansactionContactUs;
            MasterTransactionContactUsRepository = masterTransactionContactUsRepository;
        }

        public HomeViewModels GetLayoutData()
        {
            var data = new HomeViewModels
            {
                SystemSettings = SystemSettingsRepository.GetAllClint()?.FirstOrDefault()?.ToViewModel(),
                Slider = SliderRepository.GetAllClint()?.ToViewModelList(),
                About = AboutRepository.GetAllClint()?.ToViewModelList(),
                Titles = TitlesRepository.GetAllClint()?.ToViewModelList(),
                TransactionReservation = TransactionReservationRepository.GetAllClint()?.Where(x => x.EmailAddress == "bacher@esw.com").ToList().ToViewModelList(),
                Feedback = FeedbackRepository.GetAllClint()?.ToViewModelList(),
                Banner = BannerRepository.GetAllClint()?.FirstOrDefault()?.ToViewModel(),
                Partners = PartnersRepository.GetAllClint()?.ToViewModelList(),
                MasterSocialMedia = MasterSocialMediaRepository.GetAllClint()?.ToViewModelList(),
                MasterContactUs = MasterContactUsRepository.GetAllClint()?.ToViewModelList(),
                OpeningTime = OpeningTimeRepository.GetAllClint()?.ToViewModelList(),
                TransactionNewsLetter = TransactionNewsLetterRepository.GetAllClint()?.ToViewModelList(),
                Services = ServicesRepository.GetAllClint()?.ToViewModelList(),
                MenuCategory = MenuCategoryRepository.GetAllClint()?.ToViewModelList(),
                MenuItems = MenuItemsRepository.GetAllClint()?.ToViewModelList(),
                MasterTransactionContactUs = MasterTransactionContactUsRepository.GetAllClint()?.ToViewModelList(),



            };
            return data;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendMessage3(MasterTransactionContactUsFullViewModel model)
        {
            var data = new MasterTransactionContactUs
            {
                Name = model.Name,
                Email = model.Email,
                Subject = model.Subject,
                Message = model.Message,
                Datesent = DateTime.Now
            };

            _trsansactionContactUs.Add(data);

            return RedirectToAction("Contact");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendMessage(TransactionReservationFullViewModels model)
        {
            var emptySlot = _transactionContactUs.GetAll().AsEnumerable().FirstOrDefault(x => x.AvailableDate.ToString() == model.AvailableDate.ToString() && x.EmailAddress == "bacher@esw.com");

            if (emptySlot != null)
            {
                var data = new TransactionReservation
                {
                    FullName = model.FullName,
                    EmailAddress = model.EmailAddress,
                    MobileNumber = model.MobileNumber,
                    AvailableDate = model.AvailableDate,
                    Datesent = DateTime.Now,
                    IsActive = true
                };
                _transactionContactUs.Add(data);

                _transactionContactUs.Delete(emptySlot.id);
            }
            else
            {
                
            }

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendMessage2(TransactionNewsLetterFullViewModels model)
        {
            var obj = new TransactionNewsLetter
            {
                Email = model.Email,
            };

            _atransactionContactUs.Add(obj);

            return RedirectToAction("Index");
        }


        public IActionResult Index()
        {
            var model= GetLayoutData();
            return View("Index",model);
        }
        public IActionResult About()
        {
            var model = GetLayoutData();
            return View("About", model);
        }
        public IActionResult Contact()
        {
            var model = GetLayoutData();
            return View("Contact", model);
        }
        public IActionResult Menu()
        {
            var model = GetLayoutData();
            return View("Menu", model);
        }
        public IActionResult ProductDetails()
        {
            var model = GetLayoutData();
            return View("ProductDetails", model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
