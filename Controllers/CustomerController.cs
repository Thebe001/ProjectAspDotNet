using AspCoreApplication2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreApplication2023.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie() { Name = "movie 1" };
            List<Customer> customers = new List<Customer>()
    {
        new Customer { Id = 1, Name = "Customer 1" },
        new Customer { Id = 2, Name = "Customer 2" },
    };

            var viewModel = new MovieCustomerModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}
