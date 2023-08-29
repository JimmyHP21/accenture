
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesafioFULLApi.Models
{
    public class CompanyDTO
    {

        public int Id { get; set; }
        public string NameCompany { get; set; }
        public string CnpjCompany { get; set; }
        public string StateRegistration { get; set; }

        public string Cep { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Number { get; set; }


        public string PhoneCompany { get; set; }

        public virtual ICollection<SupplierDTO> Suppliers { get; set; }

        public CompanyDTO() { }

        public CompanyDTO(int id, string nameCompany, string cnpjCompany, string stateRegistration, string cep, string address,
                       string city, string state, int number, string phoneCompany, ICollection<SupplierDTO> suppliers)
        {
            Id = id;
            NameCompany = nameCompany;
            CnpjCompany = cnpjCompany;
            StateRegistration = stateRegistration;

            Cep = cep;
            Address = address;
            City = city;
            State = state;
            Number = number;

            PhoneCompany = phoneCompany;

            Suppliers = suppliers;
        }
    }
}
