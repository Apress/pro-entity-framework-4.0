using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF40Data
{
    public class BlogRepository
    {
        EF40Entities _context;

        public BlogRepository(EF40Entities context)
        {
            _context = context;
        }

        public IEnumerable<Employee> Emps
        {
            get
            {
                return _context.Employees;
            }
        }

        //public IEnumerable<Contact> GetContacts(Employee emp)
        //{
        //    _context.Employees.Attach(emp);
        //    _context.LoadProperty(emp, e => e.Contact);
        //    return emp.Contact;
        //}
    }
}
