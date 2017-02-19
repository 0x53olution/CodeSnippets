using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Common;


namespace EfMockTesting
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("EmployeeDb")
        {

        }

        public EmployeeContext(DbConnection connection)
            : base(connection, true)
        {

        }
         public DbSet<EntityEmployee> EntityEmployees { get; set; }
            
    }
}
