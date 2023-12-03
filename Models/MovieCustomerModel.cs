// Models/MovieCustomerViewModel.cs
namespace AspCoreApplication2023.Models
{
    public class MovieCustomerModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
