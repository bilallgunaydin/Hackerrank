using System;
namespace Inheritance
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }
        

        public void printPerson()
        {
            
            Console.WriteLine("Name: "+firstName+", "+lastName);
            Console.WriteLine("ID: "+id);
        }
    }
    
}