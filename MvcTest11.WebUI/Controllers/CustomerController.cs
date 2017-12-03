using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTest11.Domain.Abstract;

namespace MvcTest11.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository repository;
        public int PageSize = 4;
        public CustomerController(ICustomerRepository _CustomerRepository)
        {
            repository = _CustomerRepository;
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult CustomerList(int page = 1)
        {
            //return View(repository.CustomerList("جاو"));
            return View(repository.GetCustomSelectFromSP("دز").Skip((page - 1) * PageSize).Take(PageSize));
        }
    }
}