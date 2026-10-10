using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Helpers.File;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AboutController : Controller
    {
        IRepository<About> repository;
        IFileHelper FileHelper;

        public AboutController(IRepository<About> repository, IFileHelper fileHelper)
        {
            this.repository = repository;
            FileHelper = fileHelper;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();

            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new AboutFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(AboutViewModels collection)
        {
            try
            {
                if (collection.id == 0)
                {
                    var allData = repository.GetAll();

                    if (allData.Any())
                    {
                        return RedirectToAction(nameof(Index));
                    }

                    var data = collection.ToModel();

                    data.CreatedBy = User.Identity?.Name;

                    data.Image = FileHelper.SaveImge(
                        collection.ImageFile,
                        "AboutImage"
                    );

                    if (data.Image != "Error")
                    {
                        repository.Add(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Image Is Required");

                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                {
                    var oldData = repository.GetAll()
                        .FirstOrDefault(x => x.id == collection.id);

                    if (oldData == null)
                    {
                        return BadRequest();
                    }

                    var data = collection.ToModel();

                    data.UpdatedBy = User.Identity?.Name;

                    data.Image = oldData.Image;

                    if (collection.ImageFile != null)
                    {
                        var image = FileHelper.SaveImge(
                            collection.ImageFile,
                            "AboutImage"
                        );

                        if (image != "Error")
                        {
                            data.Image = image;
                        }
                    }

                    repository.Update(data);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AboutFullViewModels collection)
        {
            if (collection.DeleteId <= 0)
            {
                return BadRequest();
            }

            repository.Delete(collection.DeleteId);

            return RedirectToAction(nameof(Index));
        }
    }
}