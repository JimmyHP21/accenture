
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioFULLApi.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(80)]
        public string NameCompany { get; set; }
        public string CnpjCompany { get; set; }
        public string StateRegistration { get; set; }
        
        public string Cep { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Number { get; set; }


        public string PhoneCompany { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

        public Company() { }

        public Company(string nameCompany, string cnpjCompany, string stateRegistration, string cep, string address, 
                       string city, string state, int number, string phoneCompany, ICollection<Supplier> suppliers)
        {
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
