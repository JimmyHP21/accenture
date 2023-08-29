using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioFULLApi.Models
{
    public class SupplierDTO
    {
        public int Id { get; set; }
        public string NameSupplier { get; set; }
        public string CnpjSupplier { get; set; }
        public string StateRegistration { get; set; }
        public string Business { get; set; }
        public int CompanyId { get; set; }
        public CompanyDTO Company;

        public SupplierDTO() { }

        public SupplierDTO(int id, string nameSupplier, string cnpjSupplier, string stateRegistration, string business, int companyId)
        {
            Id = id;
            NameSupplier = nameSupplier;
            CnpjSupplier = cnpjSupplier;
            StateRegistration = stateRegistration;
            Business = business;
            CompanyId = companyId;
        }
    }
}