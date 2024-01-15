using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EFCrudOperationContext : DbContext
    {
        public EFCrudOperationContext(DbContextOptions<EFCrudOperationContext> options) : base(options)
        {
            
        }



        public DbSet<Employee> Employees { get; set; }


    }


}
