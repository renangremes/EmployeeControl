using System.Collections.Generic;

namespace EmployeeControl.Models
{
    public class Company
    {
        //Atributos
        public int ID { get; private set; }
        public string name { get; set; }
        public string CNPJ { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string phone { get; set; }
        public string celPhone { get; set; }
        public string email { get; set; }
        public ICollection<Employees> Employees { get; set; } = new List<Employees>();
    
        //Construtores
        public Company()
        {

        }

        public Company(int id, string name, string cNPJ, string address, string postalCode, string city, string state, string phone, string celPhone, string email)
        {
            ID = id;
            this.name = name;
            CNPJ = cNPJ;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.state = state;
            this.phone = phone;
            this.celPhone = celPhone;
            this.email = email;
        }
    }
}
