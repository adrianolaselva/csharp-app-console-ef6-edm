using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleEntities entity = new ExampleEntities();

            Person person = new Person() { Name = "Adriano", Email = "adrianolaselva@gmail.com" };

            entity.Person.Add(person);

            entity.SaveChanges();

            Person person2 = entity.Person.Find(1);

            Console.WriteLine(person2.Id);

            var result = entity.Person.Where<Person>(p => p.Email == "adrianolaselva@gmail.com").ToList();
            
            foreach (var p in result)
            {
                Console.WriteLine(p.Id);
            }

            entity.Dispose();
        }
    }
}
