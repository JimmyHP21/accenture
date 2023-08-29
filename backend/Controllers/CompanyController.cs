using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DesafioFULLApi.Models;
using DesafioFULLApi.Helper;
using Microsoft.AspNetCore.Cors;
using System;

namespace DesafioFULLApi.Controllers
{
    [EnableCors("EnableCORS")]
    [Route("api/Company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyContext _context;

        public CompanyController(CompanyContext context)
        {
            _context = context;
        }

        // GET: api/Company
        [DisableCors]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDTO>>> GetCompanys()
        {
            var dbList = await _context.Companys.Include(x => x.Suppliers).ToListAsync();
            return dbList.Select(x => x.ToCompanyDTO()).ToList();
        }

        // GET: api/Company/5
        [DisableCors]
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var company = await _context.Companys.Include(x => x.Suppliers).FirstOrDefaultAsync(x => x.Id == id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        // PUT: api/Company/update/5
        [DisableCors]
        [HttpPut("update/{id}")]
        public async Task<IActionResult> PutCompany(int id, CompanyDTO companyDto)
        {

            if (id != companyDto.Id)
            {
                return BadRequest();
            }

            var company = await _context.Companys.Include(x => x.Suppliers).FirstOrDefaultAsync(x => x.Id == id);
            
            if (company == null)
            {
                return NotFound();
            }

            company.NameCompany = companyDto.NameCompany;
            company.CnpjCompany = companyDto.CnpjCompany;
            company.StateRegistration = companyDto.StateRegistration;
            company.State = companyDto.State;
            company.Cep = companyDto.Cep;
            company.Address = companyDto.Address;
            company.City = companyDto.City;
            company.Number = companyDto.Number;
            company.PhoneCompany = companyDto.PhoneCompany;


            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Company/new
        [DisableCors]
        [HttpPost("new")]
        public async Task<ActionResult<CompanyDTO>> PostCompany(CompanyDTO company)
        {
            _context.Companys.Add(company.ToCompany());
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompany), new { id = company.Id }, company);
        }

        // DELETE: api/Company/delete/5
        [DisableCors]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await _context.Companys.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.Companys.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyExists(int id)
        {
            return _context.Companys.Any(e => e.Id == id);
        }
    }
}
