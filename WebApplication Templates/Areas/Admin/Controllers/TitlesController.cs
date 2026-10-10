using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TitlesController : Controller
    {
        IRepository<Titles> repository;

        public TitlesController(IRepository<Titles> repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();

            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new TitlesFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(TitlesViewModels collection)
        {
            try
            {
                if (collection.id <= 0)
                {
                    return RedirectToAction(nameof(Index));
                }

                var oldData = repository.GetAll()
                    .FirstOrDefault(x => x.id == collection.id);

                if (oldData == null)
                {
                    return BadRequest();
                }

                oldData.Title = collection.Title;
                oldData.Desc = collection.Desc;
                oldData.IsActive = collection.IsActive;
                oldData.UpdatedBy = User.Identity?.Name;

                repository.Update(oldData);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus(int id)
        {
            try
            {
                repository.Changsteates(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}