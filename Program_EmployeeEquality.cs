using System;

namespace EmployeeEqualityApp
{
    // The Employee class represents an employee with an Id, first name, and last name.
    class Employee
    {
        // Property to store the employee's unique ID
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Constructor that sets all three properties when a new Employee is created
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overload the "==" operator to compare two Employee objects by their Id property.
        // This lets us write "employee1 == employee2" and have it check Id equality
        // instead of the default behavior (which would check if they're the same object in memory).
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both references point to the same object, or are both null;
            // ReferenceEquals avoids infinite recursion that would happen if we used == here
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // If either object is null (but not both, which was already handled above),
            // they cannot be equal
            if (employee1 is null || employee2 is null)
            {
                return false;
            }

            // Compare the Id properties of the two employees
            return employee1.Id == employee2.Id;
        }

        // Comparison operators must be overloaded in pairs, so we overload "!=" as well.
        // This simply returns the opposite of whatever "==" returns.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        // It's good practice to override Equals() and GetHashCode() whenever you
        // overload == and !=, so the class behaves consistently everywhere it's used.
        public override bool Equals(object obj)
        {
            // Reuse the == operator we defined above, after converting obj to an Employee
            return this == (obj as Employee);
        }

        // GetHashCode should be based on the same field(s) used for equality (Id)
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object with Id 101
            Employee employee1 = new Employee(101, "Jordan", "Blake");

            // Create a second Employee object with a different Id (102)
            Employee employee2 = new Employee(102, "Taylor", "Reed");

            // Create a third Employee object that shares the same Id as employee1 (101),
            // to demonstrate that the comparison is based on Id, not on names
            Employee employee3 = new Employee(101, "Alex", "Morgan");

            // Compare employee1 and employee2 using the overloaded "==" operator.
            // Since their Ids are different (101 vs 102), this should be false.
            Console.WriteLine("employee1 == employee2: {0}", employee1 == employee2);

            // Compare employee1 and employee3 using the overloaded "==" operator.
            // Since their Ids are the same (101), this should be true,
            // even though their names are different.
            Console.WriteLine("employee1 == employee3: {0}", employee1 == employee3);

            // Compare employee1 and employee2 using the overloaded "!=" operator.
            // Since their Ids are different, this should be true.
            Console.WriteLine("employee1 != employee2: {0}", employee1 != employee2);

            // Keep the console window open until the user presses a key
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
