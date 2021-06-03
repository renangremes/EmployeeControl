using System;

namespace EmployeeControl.Models
{
    public class Employees
    {
        public int ID { get; private set; }
        public string name { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string office { get; set; }
        public DateTime dateBirthday { get; set; }
        public DateTime dateAdmission { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string PIS { get; set; }
        public double salary { get; set; }
        public string phone { get; set; }
        public string celPhone { get; set; }
        public string email { get; set; }
    }
}
