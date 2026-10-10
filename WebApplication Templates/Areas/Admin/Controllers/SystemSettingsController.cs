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
    public class SystemSettingsController : Controller
    {
        IRepository<SystemSettings> repository;
        IFileHelper FileHelper;

        public SystemSettingsController(
            IRepository<SystemSettings> repository,
            IFileHelper fileHelper)
        {
            this.repository = repository;
            FileHelper = fileHelper;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();

            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new SystemSettingsFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(SystemSettingsViewModels collection)
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

                    data.Bg1 = FileHelper.SaveImge(
                        collection.ImageFileBg1,
                        "SystemSettingsImage"
                    );

                    data.Bg2 = FileHelper.SaveImge(
                        collection.ImageFileBg2,
                        "SystemSettingsImage"
                    );

                    data.LogoLight = FileHelper.SaveImge(
                        collection.ImageFileLogoLight,
                        "SystemSettingsImage"
                    );

                    data.LogoDark = FileHelper.SaveImge(
                        collection.ImageFileLogoDark,
                        "SystemSettingsImage"
                    );

                    data.ReservationImage = FileHelper.SaveImge(
                        collection.ImageFileReservationImage,
                        "SystemSettingsImage"
                    );

                    if (data.Bg1 != "Error" &&
                        data.Bg2 != "Error" &&
                        data.LogoLight != "Error" &&
                        data.LogoDark != "Error" &&
                        data.ReservationImage != "Error")
                    {
                        repository.Add(data);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Images Are Required");

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

                    data.Bg1 = oldData.Bg1;
                    data.Bg2 = oldData.Bg2;
                    data.LogoLight = oldData.LogoLight;
                    data.LogoDark = oldData.LogoDark;
                    data.ReservationImage = oldData.ReservationImage;

                    if (collection.ImageFileBg1 != null)
                    {
                        var image = FileHelper.SaveImge(
                            collection.ImageFileBg1,
                            "SystemSettingsImage"
                        );

                        if (image != "Error")
                        {
                            data.Bg1 = image;
                        }
                    }

                    if (collection.ImageFileBg2 != null)
                    {
                        var image = FileHelper.SaveImge(
                            collection.ImageFileBg2,
                            "SystemSettingsImage"
                        );

                        if (image != "Error")
                        {
                            data.Bg2 = image;
                        }
                    }

                    if (collection.ImageFileLogoLight != null)
                    {
                        var image = FileHelper.SaveImge(
                            collection.ImageFileLogoLight,
                            "SystemSettingsImage"
                        );

                        if (image != "Error")
                        {
                            data.LogoLight = image;
                        }
                    }

                    if (collection.ImageFileLogoDark != null)
                    {
                        var image = FileHelper.SaveImge(
                            collection.ImageFileLogoDark,
                            "SystemSettingsImage"
                        );

                        if (image != "Error")
                        {
                            data.LogoDark = image;
                        }
                    }

                    if (collection.ImageFileReservationImage != null)
                    {
                        var image = FileHelper.SaveImge(
                            collection.ImageFileReservationImage,
                            "SystemSettingsImage"
                        );

                        if (image != "Error")
                        {
                            data.ReservationImage = image;
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
        public ActionResult Delete(int id, SystemSettingsFullViewModels collection)
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