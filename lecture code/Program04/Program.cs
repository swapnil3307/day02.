using System.ComponentModel.DataAnnotations;

namespace Program04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { Id = 1, Name = "Swap", Address = "karad" };
            Employee e2 = new Employee() { Id = 2, Name = "pranav", Address = "pune" };
            Employee e3 = new Employee() { Id = 3, Name = "kartik", Address = "nashik" };
            Employee e4 = new Employee() { Id = 4, Name = "Swarup", Address = "kadegaon" };
            Employee e5 = new Employee() { Id = 5, Name = "pavan", Address = "sangli" };

            List<Employee> list1 = new List<Employee>();
            list1.Add(e1);
            list1.Add(e2);
            list1.Add(e3);
            list1.Add(e4);
            list1.Add(e5);

            e1.Display();
            e2.Display();
            e3.Display(); 
            e4.Display();
            e5.Display();
        }
    }
    class Employee
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set;
            }
        public void Display()
        {
            Console.WriteLine($"id:{Id} name: {Name} address: {Address}");
                   
          
        }
    }
}
