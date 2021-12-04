using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Xml.Linq;



namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            XDocument doc = XDocument.Load("employees.xml");
            List<Employee> employees = new List<Employee>();

            XElement root = doc.Root;

            foreach (XElement element in root.Elements())
            {
                XAttribute Id = element.Attribute("id");
                XElement Name = element.Element("name");
                string name = Name.Value;
                XElement Phone = element.Element("phone");
                string phone = Phone.Value;
                XElement Department = element.Element("address");
                string department = Department.Value;
                XElement Street = element.Element("street");
                string street = Street.Value;
                XElement City = element.Element("city");
                string city = City.Value;
                XElement State = element.Element("state");
                string state = State.Value;
                XElement Zip = element.Element("zip");
                string zip = Zip.Value;
                XElement Country = element.Element("zip");
                string country = Zip.Value;
                Employee employee = new Employee();
                employee.Id = int.Parse(Id.Value);
                employee.Name = name;
                employee.Phone = int.Parse(phone);
                employee.Department = department;
                employee.Street = street;
                employee.City = city;
                employee.State = state;
                employee.Zip = int.Parse(zip);
                employees.Add(employee);
            }
            return employees;
        }

        [HttpPost]
        public string InsertEmployee(Employee employee)
        {
            Console.WriteLine(employee.Name);

            XDocument doc = XDocument.Load("employees.xml");
            XElement EmployeeRoot = doc.Root;
            XElement addEmployeeElement = new XElement("employees");

            return "Yeah!! your Insertion is done.!";
        }


        [HttpPut]
        public string UpdateEmployee(int id)
        {
            return "Congratulations! your new employee data is saved successfully";
        }


        [HttpDelete]
        public string DeleteEmployee(string id)
        {
            XDocument doc = XDocument.Load("employees.xml");
            XElement EmployeeRoot = doc.Root;
            XElement selectedElement = EmployeeRoot.Descendants("employee").Where(el => el.Attribute("Id").Value == id).FirstOrDefault();
            if (selectedElement != null)
            {
                Console.WriteLine(selectedElement);
                selectedElement.Remove();
                doc.Save("employees.xml");

            }
            else
            {
                return "Employee id is invalid.";
            }

            return "Woohoo! The employee data has been deleted!";
        }


    }
}
