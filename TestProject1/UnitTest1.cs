using EmployeeList;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using WebapiList.Controllers;
//using WebApplication1.Controllers;
//using WebApplication1.Model;

namespace TestProject1
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void Post_with_0_id_returns_OkResult()
        {
            EmployeeController addMovieController = new EmployeeController();

            Employee employee = new Employee()
            {
                EmpId = 3,
                Name = "Kavin",
                Designation = "Devops",
                Salary = 10000
            };

            var result = addMovieController.PostProduct(employee);

            Assert.IsInstanceOf<OkResult>(result);
        }
        [Test]
        public void Update_with_correct_type_returns_correctResult()
        {

            EmployeeController updateMovieController = new EmployeeController();

            Employee employee = new Employee()
            {
                EmpId = 1,
                Name = "Mano Selvaraj",
                Designation = "Devops",
                Salary = 12000
            };

            var result = updateMovieController.Update(employee.EmpId, employee).Result;

            Assert.IsInstanceOf<OkResult>(result);

        }

        [Test]
        public void GetById_returns_correctResult()
        {
            EmployeeController employeeController = new EmployeeController();
            var result = employeeController.GetEmployees(1);

            var value = result.EmpId;
            Assert.AreEqual(1, value);

        }
        [Test]
        public void Get_returnsAllResults_give_correct_type()
        {
            EmployeeController employeeController = new EmployeeController();
            var result = employeeController.GetAllEmployees();
            Assert.IsInstanceOf<List<Employee>>(result);

        }



    }
}