using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commerce.Models;
using Commerce.Models.Entities;



namespace Retail.Controllers
{
    public class CustomerController : Controller
    {
        private IGenericRepository<Customer> _repository;
        
        public CustomerController()
        {
            _repository = new EntityFrameworkRepository<Customer>();
        }
        //
        // GET: /Customer/
        public ActionResult GetAllCustomers()
        {
            IEnumerable<Customer> model = _repository.GetAll();
            return View(model);
        }

        public ActionResult CreateCustomer()
        {

           

            for (int i = 1; i < 11;i++ )
            {
                Customer cust = new Customer();
                
                cust.ContactName = "Jefferson Pastuszak";
                cust.ContactTitle = "Sr.";
                cust.Country = "BRASIL";
            
                _repository.Save(cust);

                cust = null;
                
            }

            return RedirectToAction("GetAllCustomers");
        }
	}
}