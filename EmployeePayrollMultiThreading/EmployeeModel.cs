using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeeModel  
    {
        private long phoneNumber;

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public EmployeeModel(string employeeName, DateTime startDate, long phoneNumber, string address, string department, string gender, int basicPay, int deductions, int taxablePay, int tax, int netPay)
        {
            EmployeeName = employeeName;
            StartDate = startDate;
            this.phoneNumber = phoneNumber;
            Address = address;
            Department = department;
            Gender = gender;
            BasicPay = basicPay;
            Deductions = deductions;
            TaxablePay = taxablePay;
            Tax = tax;
            NetPay = netPay;
        }

        public EmployeeModel()
        {
        }

        public bool AddEmployeeListToDataBase(List<EmployeeModel> employeeList)
        {
            throw new NotImplementedException();
        }
    }
}