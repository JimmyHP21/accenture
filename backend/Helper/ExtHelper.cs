using DesafioFULLApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFULLApi.Helper
{
    public static class ExtHelper
    {
            

        public static Company ToCompany(this CompanyDTO dto)
        {
            return new Company(
                dto.NameCompany,
                dto.CnpjCompany,
                dto.StateRegistration,

                dto.Cep,
                dto.Address,
                dto.City,
                dto.State,
                dto.Number,

                dto.PhoneCompany,

                dto.Suppliers.Select(x => new Supplier(x.CnpjSupplier, x.NameSupplier, x.StateRegistration, x.Business)).ToList()
            );
        }

        public static CompanyDTO ToCompanyDTO(this Company model)
        {
            return new CompanyDTO(
                model.Id,
                model.NameCompany,
                model.CnpjCompany,
                model.StateRegistration,

                model.Cep,
                model.Address,
                model.City,
                model.State,
                model.Number,

                model.PhoneCompany,

                model.Suppliers.Select(x => new SupplierDTO(x.Id, x.CnpjSupplier, x.NameSupplier, x.StateRegistration, x.Business, x.CompanyId)).ToList()
            );
        }
    }
}
