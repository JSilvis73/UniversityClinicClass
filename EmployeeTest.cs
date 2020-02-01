using System;
using UniversityClinicClass;
using Xunit;

namespace UniversityClinicClassTests
{
    public class EmployeeTest
    {
        [Fact]
        public void PayEmployee_Sets_PaidStatus_To_True()
        {
            //arrange
        Employee newEmployee = new Employee();

            //act
        newEmployee.PayEmployee();

            //assert
        Assert.True(newEmployee.PaidStatus);
        }

        [Fact]
        public void PayAllEmployee_Set_PaidStatus_To_True()
        {
            //arrange
           
            //List<Employee> employees = new List<Employee>();

            //act

            //assert
        }





    }
}
