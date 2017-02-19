using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfMockTesting;
using System.Data.Common;

namespace EfMockTesting.Tests
{
    [TestFixture]
    public class TestClass
    {
        public EmployeeContext Context {get; set;}
        public DbConnection EmployeeDb {get; set;}
        public bool IsInMemory { get; private set; }
        
        public void CreateInMemoryDb()
        {
            EmployeeDb = Effort.DbConnectionFactory.CreatePersistent(Guid.NewGuid().ToString());
            this.Context = new EmployeeContext(EmployeeDb);
            this.IsInMemory = true;
        }

        [Test]
        public void Context_Created()
        {
            this.CreateInMemoryDb();
            Assert.IsNotNull(Context.Database);
        }

        [Test]
        public void Invoke_Works()
        {
            this.CreateInMemoryDb();
            var test = this.Context.EntityEmployees.ToList();
            Assert.IsTrue(true);
         }

        [Test]
        public void Save_Works()
        {
            this.CreateInMemoryDb();
            this.Context.EntityEmployees.Add(new EntityEmployee() { FirstName = "Fristname 1", LastName= "Lastname 1"});
            this.Context.EntityEmployees.Add(new EntityEmployee() { FirstName = "Fristname 2", LastName = "Lastname 2" });
            this.Context.EntityEmployees.Add(new EntityEmployee() { FirstName = "Fristname 3", LastName = "Lastname 3" });
            this.Context.SaveChanges();

            using (new EmployeeContext(this.EmployeeDb))
            {
                Assert.IsTrue(this.Context.EntityEmployees.Count()==3);    
            }
        }
    }
}
