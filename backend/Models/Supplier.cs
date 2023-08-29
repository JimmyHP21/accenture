using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DesafioFULLApi.Models
{
	public class Supplier
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[StringLength(80)]
		public string NameSupplier { get; set; }
		public string CnpjSupplier { get; set; }
		public string StateRegistration { get; set; }
		public string Business { get; set; }

		[Key, ForeignKey("Company")]
		public int CompanyId { get; set; }
		public Company Company;

		public Supplier() { }

		public Supplier(string nameSupplier, string cnpjSupplier, string stateRegistration, string business)
		{
			NameSupplier = nameSupplier;
			CnpjSupplier = cnpjSupplier;
			StateRegistration = stateRegistration;
			Business = business;
		}
	}
}
