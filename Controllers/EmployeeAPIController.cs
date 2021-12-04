using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Xml.Linq;
using System.Web;
using System.Net;
using System.Net.Http;



namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeAPIController : ControllerBase
    {
        private readonly ILogger<EmployeeAPIController> _logger;

        public EmployeeAPIController(ILogger<EmployeeAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            //string pathWithFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Employee.xml");
            //XDocument doc = XDocument.Load(pathWithFileName);
            ////  XDocument doc = XDocument.Load( "Employee.xml")
            //List<Employee> employees = new List<Employee>();
            //foreach (XElement element in Descendants("").Descendants("Employee"))
            //{
            //    Employee employee = new Employee();
            //    employee.Id = int.Parse(element.Element("Id").Value);
            //    employee.Name = element.Element("Name").Value;
            //    employee.Phone = int.Parse(element.Element("Phone").Value);
            //    employee.Department = element.Element("Department").Value;
            //    employee.Street = element.Element("Street").Value;
            //    employee.City = element.Element("City").Value;
            //    employee.State = element.Element("State").Value;
            //    employee.ZIP = int.Parse(element.Element("ZIP").Value);
            //    employees.Add(employee);
            //}
            //return employees;
            //string pathWithFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "employees.xml");
            //XDocument doc = XDocument.Load(pathWithFileName);
            //XElement root = doc.Root;
            //List<Employee> movies = new List<Employee>();
            //foreach (XElement ele in root.Elements())
            //{

            //}
            List<string> a = new List<string>();
            a.Add("hello");
            a.Add("hi");
            return a;
        }



        //public Employee GetEmployee(int id)
        //{
        //    Employee employee = new Employee();
        //    XDocument doc = XDocument.Load("Employee.xml");
        //    XElement element = doc.Element("DocumentElement").Elements("Employee").Elements("ID").SingleOrDefault(x => x.Value == id.ToString());
        //    if (element != null)
        //    {
        //        XElement parent = element.Parent;
        //        employee.Id = int.Parse(element.Element("Id").Value);
        //        employee.Name = element.Element("Name").Value;
        //        employee.Phone = int.Parse(element.Element("Phone").Value);
        //        employee.Department = element.Element("Department").Value;
        //        employee.Street = element.Element("Street").Value;
        //        employee.City = element.Element("City").Value;
        //        employee.State = element.Element("State").Value;
        //        employee.ZIP = int.Parse(element.Element("ZIP").Value);
        //        return employee;
        //    }

        //    return null;

        //}
    }
}