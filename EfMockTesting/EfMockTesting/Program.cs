using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMockTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EmployeeContext())
            {
                for(int i =0; i<10; i++)
                {
                    var emp = new EntityEmployee{FirstName = "Bill " + i, LastName = "Gates " +i};
                    db.EntityEmployees.Add(emp);
                }
                db.SaveChanges();

                foreach (var emp in db.EntityEmployees)
                {
                    Console.WriteLine("ID: {0} Name: {1} Nachname {2}", emp.Id, emp.FirstName, emp.LastName);
                } 
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
