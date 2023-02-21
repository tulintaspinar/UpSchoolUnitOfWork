using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UpSchoolUnitOfWork_BusinessLayer.Abstract;
using UpSchoolUnitOfWork_EntityLayer.Concrete;
using UpSchoolUnitOfWorkPresentationLayer.Models;

namespace UpSchoolUnitOfWorkPresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AccountViewModel p)
        {
            var value1 = _accountService.TGetByID(p.SenderID);
            var value2 = _accountService.TGetByID(p.ReceiverID);

            value1.AccountBalance -= p.Amount;
            value2.AccountBalance += p.Amount;

            List<Account> modifiedAccounts=new List<Account>(){ value1, value2 };
            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
