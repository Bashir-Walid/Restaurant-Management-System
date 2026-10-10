using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.Extensions;
using WebApplication_Templates.Helpers.Email;
using WebApplication_Templates.Models;
using WebApplication_Templates.Repositories;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TransactionReservationController : Controller
    {
        IRepository<TransactionReservation> repository;
        IEmailHelper emailHelper;

        public TransactionReservationController(
            IRepository<TransactionReservation> repository,
            IEmailHelper emailHelper)
        {
            this.repository = repository;
            this.emailHelper = emailHelper;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();

            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new TransactionReservationFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(TransactionReservationViewModels collection)
        {
            try
            {
                if (collection.id == 0)
                {
                    var data = collection.ToModel();

                    data.CreatedBy = User.Identity?.Name;
                    data.FullName = "متاح للحجز";
                    data.EmailAddress = "bacher@esw.com";
                    data.MobileNumber = "";

                    repository.Add(data);
                }
                else
                {
                    var oldData = repository.GetAll()
                        .FirstOrDefault(x => x.id == collection.id);

                    if (oldData == null)
                    {
                        return BadRequest();
                    }

                    oldData.AvailableDate = collection.AvailableDate;
                    oldData.IsActive = collection.IsActive;
                    oldData.UpdatedBy = User.Identity?.Name;

                    repository.Update(oldData);
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
        public ActionResult Reply(int id)
        {
            try
            {
                var item = repository.GetById(id);

                if (item == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                var emailModel = new EmialViewModels
                {
                    EmialAddrase = item.EmailAddress,
                    Subject = $"رد على حجزك رقم الموبايل: {item.MobileNumber}",
                    Message = $"مرحباً {item.FullName}، تم تأكيد حجزك بنجاح في موعد: {item.AvailableDate}"
                };

                emailHelper.SendMessage(emailModel);

                repository.Delete(item.id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TransactionReservationFullViewModels collection)
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