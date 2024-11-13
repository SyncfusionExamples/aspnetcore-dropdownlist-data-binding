using ASPNETCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            ControlName model = new ControlName();
			model.SupportCoordinatorDataList = new Countries().CountriesList();
            model.val = "DE";
            return View(model);
        }
        public IActionResult Privacy()
        {
	        Complex model = new Complex();
	        ViewBag.DataSource  = model.GetData();
	        return View();
        }
    }
    public class ControlName
    {
		public List<Countries> SupportCoordinatorDataList { get; set; }
        public string val { get; set; }

    }
	public class Countries
	{
		public string Name { get; set; }
		public string Code { get; set; }

        // Modify this method to retrieve data from SQL Server
        public List<Countries> CountriesList()
		{
            // Simulated data retrieval from SQL Server
            List<Countries> country = new List<Countries>();
			country.Add(new Countries { Name = "Australia", Code = "AU" });
			country.Add(new Countries { Name = "Bermuda", Code = "BM" });
			country.Add(new Countries { Name = "Canada", Code = "CA" });
			country.Add(new Countries { Name = "Cameroon", Code = "CM" });
			country.Add(new Countries { Name = "Denmark", Code = "DK" });
			country.Add(new Countries { Name = "France", Code = "FR" });
			country.Add(new Countries { Name = "Finland", Code = "FI" });
			country.Add(new Countries { Name = "Germany", Code = "DE" });
			country.Add(new Countries { Name = "Greenland", Code = "GL" });
			country.Add(new Countries { Name = "Hong Kong", Code = "HK" });
			country.Add(new Countries { Name = "India", Code = "IN" });
			country.Add(new Countries { Name = "Italy", Code = "IT" });
			country.Add(new Countries { Name = "Japan", Code = "JP" });
			country.Add(new Countries { Name = "Mexico", Code = "MX" });
			country.Add(new Countries { Name = "Norway", Code = "NO" });
			country.Add(new Countries { Name = "Poland", Code = "PL" });
			country.Add(new Countries { Name = "Switzerland", Code = "CH" });
			country.Add(new Countries { Name = "United Kingdom", Code = "GB" });
			country.Add(new Countries { Name = "United States", Code = "US" });
			return country;
		}
	}
	public class Code
	{
		public string Id { get; set; }
	}

	public class Country
	{
		public string CountryId { get; set; }
	}
	public class Complex
	{
		public Country Country { get; set; }
		public Code Code { get; set; }
		public List<Complex> GetData()
		{
			List<Complex> data = new List<Complex>();
			data.Add(new Complex() { Country = new Country() { CountryId = "Australia"  }, Code = new Code() { Id = "AU" } });
			data.Add(new Complex() { Country = new Country() { CountryId = "Bermuda" }, Code = new Code() { Id = "BM" } });
			data.Add(new Complex() { Country = new Country() { CountryId = "Canada" }, Code = new Code() { Id = "CA" } });
			data.Add(new Complex() { Country = new Country() { CountryId = "Cameroon" }, Code = new Code() { Id = "CM" } });
			data.Add(new Complex() { Country = new Country() { CountryId = "Denmark" }, Code = new Code() { Id = "DK" } });
			data.Add(new Complex() { Country = new Country() { CountryId = "France" }, Code = new Code() { Id = "FR" } });
			return data;
		}
	}
	


}