using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    
    public class CustomersController : ApiController //This class derives from ApiController
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/customers
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.Include(c=>c.MembershipType)
                .ToList().Select(Mapper.Map<Customer,CustomerDto>);  
        }
        //GET /api/customers/1
        public CustomerDto GetCustomer(int id)
        {
            var customerDto = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customerDto == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Customer,CustomerDto>(customerDto);    

        }
        //POST /api/customers
        [HttpPost] //sadece post request var ise çalıaşcak
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
            if (ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customer=Mapper.Map<CustomerDto, Customer>(customerDto);    
            _context.Customers.Add(customer);
            _context.SaveChanges();
            customerDto.Id= customer.Id;
            return customerDto;
        }
        //PUT /api/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
                var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
                if (customerInDb == null)
                    throw new HttpResponseException(HttpStatusCode.NotFound);

                Mapper.Map<CustomerDto, Customer>(customerDto, customerInDb);
            
                _context.SaveChanges();

              }
           }
        //DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

        }

       }
}
