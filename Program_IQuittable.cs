using System;

namespace QuittableApp
{
    // This interface defines a contract: any class that implements it
    // must provide its own version of the Quit() method.
    interface IQuittable
    {
        // Method signature only - no implementation here.
        // Any class that implements IQuittable must define what Quit() actually does.
        void Quit();
    }

    // The Employee class represents a basic employee with a name and job title.
    // It implements the IQuittable interface, which means it must include
    // its own version of the Quit() method.
    class Employee : IQuittable
    {
        // Property to store the employee's name
        public string Name { get; set; }

        // Property to store the employee's job title
        public string JobTitle { get; set; }

        // Constructor that sets the employee's name and job title when the object is created
        public Employee(string name, string jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;
        }

        // This is the Employee class's own implementation of the Quit() method
        // required by the IQuittable interface. It prints a message showing
        // that this specific employee has quit their job.
        public void Quit()
        {
            Console.WriteLine("{0} has quit their position as {1}.", Name, JobTitle);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object, but store it in a variable of type IQuittable.
            // This is polymorphism in action: the variable's type is the interface,
            // even though the actual object underneath is an Employee.
            IQuittable employee = new Employee("Sam Rivera", "Warehouse Associate");

            // Call the Quit() method through the IQuittable reference.
            // Even though "employee" is declared as IQuittable, C# knows to run
            // the Employee class's specific version of Quit() at runtime.
            employee.Quit();

            // Keep the console window open until the user presses a key
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
