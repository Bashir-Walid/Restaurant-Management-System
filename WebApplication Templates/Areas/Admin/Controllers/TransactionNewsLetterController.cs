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
    public class TransactionNewsLetterController : Controller
    {
        IRepository<TransactionNewsLetter> repository;
        IEmailHelper emailHelper;

        public TransactionNewsLetterController(
            IRepository<TransactionNewsLetter> repository,
            IEmailHelper emailHelper)
        {
            this.repository = repository;
            this.emailHelper = emailHelper;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll().ToViewModelList();

            ViewBag.HasAnyRecord = data.Count > 0;

            var obj = new TransactionNewsLetterFullViewModels
            {
                list = data,
            };

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reply(int id, string Subject, string Message)
        {
            try
            {
                var item = repository.GetById(id);

                if (item == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                if (string.IsNullOrWhiteSpace(Subject) ||
                    string.IsNullOrWhiteSpace(Message))
                {
                    return RedirectToAction(nameof(Index));
                }

                var emailModel = new EmialViewModels
                {
                    EmialAddrase = item.Email,
                    Subject = Subject,
                    Message = Message
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
        public ActionResult Delete(int id, TransactionNewsLetterFullViewModels collection)
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