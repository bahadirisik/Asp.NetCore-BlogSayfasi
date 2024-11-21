using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class EmployeeTestController : Controller
	{
		public HttpClient GetHttpClient()
		{
			//Bu kod satırı izinde sıkıntı çıkmasın diye
			var handler = new HttpClientHandler();
			handler.ClientCertificateOptions = ClientCertificateOption.Manual;
			handler.ServerCertificateCustomValidationCallback =
				(httpRequestMessage, cert, cetChain, policyErrors) =>
				{
					return true;
				};

			var httpClient = new HttpClient(handler);
			return httpClient;
		}
		public async Task<IActionResult> Index()
		{
			var httpClient = GetHttpClient();
			var responseMessage = await httpClient.GetAsync("https://localhost:44381/api/Default");
			var jsonString = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
			return View(values);
		}

		[HttpGet]
		public IActionResult AddEmployee()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddEmployee(Class1 p)
		{
			var httpClient = GetHttpClient();
			var jsonEmployee = JsonConvert.SerializeObject(p);
			StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");
			var responseMessage = await httpClient.PostAsync("https://localhost:44381/api/Default", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View(p);
		}

		[HttpGet]
		public async Task<IActionResult> EditEmployee(int id)
		{
			var httpClient = GetHttpClient();
			var responseMessage = await httpClient.GetAsync("https://localhost:44381/api/Default/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonEmployee = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<Class1>(jsonEmployee);
				return View(values);
			}

			return RedirectToAction("Index");
		}

		[HttpPost]
		public async Task<IActionResult> EditEmployee(Class1 p)
		{
			var httpClient = GetHttpClient();
			var jsonEmployee = JsonConvert.SerializeObject(p);
			StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");
			var responseMessage = await httpClient.PutAsync("https://localhost:44381/api/Default", content);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View(p);
		}

		public async Task<IActionResult> DeleteEmployee(int id)
		{
			var httpClient = GetHttpClient();
			var responseMessage = await httpClient.DeleteAsync("https://localhost:44381/api/Default/" + id);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}
	}

	public class Class1
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}
}
