using System.Data;

namespace Program02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Manager \n2.Salesmanager");
            Employee e1 = null;
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    e1 = new Manager();
                    break;
                case 2:
                    e1 = new Salesmanager();
                    break;
            }
            if (e1 != null)
            {
                e1.Accept();
                e1.Display();
            }
        }
    }

    class Employee
    {
        private int _id;


        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        private double salary;

        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public virtual double CalSalary()
        {
            return salary;
        }

        public virtual void DoWork()
        {

        }
        public virtual void Accept()
        {
            Console.WriteLine("Enter id: ");
            this._id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the  salary: ");
            this.salary = double.Parse(Console.ReadLine());

        }
        public virtual void Display()
        {
            Console.WriteLine("salary : " + CalSalary);
        }
    }

    class Manager : Employee
    {
        private double _bonus;

        public double bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
        public override double CalSalary()
        {

            return Salary + _bonus;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("enter the bonus :");
            _bonus = double.Parse(Console.ReadLine());

        }

        public override void DoWork()
        {
            Console.WriteLine("manager do Work");
        }
        public override void Display()
        {
            Console.WriteLine("salary : " + this.CalSalary());
        }
    }

    class Salesmanager : Employee
    {
        private double _comm;

        public double comm
        {
            get { return _comm; }
            set { _comm = value; }
        }

        public override double CalSalary()
        {
            return Salary + _comm;
        }

        public virtual void DoWork()
        {
            Console.WriteLine("salesman do work");
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("enter the commision :");
            _comm = double.Parse(Console.ReadLine());

        }
        public override void Display()
        {
            Console.WriteLine("salary : " + this.CalSalary());
        }

    }

    class Labour : Employee
    {

    }

}

