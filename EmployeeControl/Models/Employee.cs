using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeControl.Models
{
    public class Employee
    {
        //Atributos
        public int ID { get; private set; }
        public string name { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string office { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateBirthday { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateAdmission { get; set; }

        public string CPF { get; set; }
        public string RG { get; set; }
        public string PIS { get; set; }
        public double salary { get; set; }
        public string phone { get; set; }
        public string celPhone { get; set; }
        public string email { get; set; }
        public Company Company { get; set; }

        //Construtores
        public Employee()
        {

        }

        public Employee(int id, string name, string address, string postalCode, string city, string state, string office, DateTime dateBirthday, DateTime dateAdmission, string cPF, string rG, string pIS, double salary, string phone, string celPhone, string email, Company company)
        {
            ID = id;
            this.name = name;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.state = state;
            this.office = office;
            this.dateBirthday = dateBirthday;
            this.dateAdmission = dateAdmission;
            CPF = cPF;
            RG = rG;
            PIS = pIS;
            this.salary = salary;
            this.phone = phone;
            this.celPhone = celPhone;
            this.email = email;
            Company = company;
        }
    }    
}
