using System;

namespace cSharp
{
    public class VT06_02_List_Employee_Salary
    {
        public static void Print()
        {
            List<(string, decimal)> employees = new List<(string, decimal)>();

            Console.WriteLine("Employee Entry System");

            while (true)
            {
                Console.Write("Enter employee name (press 'x' or 'X' to stop): ");
                string name = Console.ReadLine();

                if (name.ToLower() == "x") // Check for 'x' or 'X' (case-insensitive)
                {
                    break; // Exit the loop if user enters 'x' or 'X'
                }

                Console.Write("Enter salary: ");
                decimal salary;

                // Handle potential user input errors (non-numeric input)
                while (!decimal.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal value for salary.");
                }

                employees.Add((name, salary));

                Console.WriteLine($"Employee Name: {name}");
                Console.WriteLine($"Salary: {salary:C2}"); // Format salary as currency

                Console.WriteLine("\nPress any key to continue or 'x' or 'X' to stop...");
            }

            Console.WriteLine("Employee entry system terminated.");

            if (employees.Count > 0) // Check if any employees were added
            {
                Console.WriteLine("\nEmployee List:");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Name: {employee.Item1}, Salary: {employee.Item2}");
                }
            }
            else
            {
                Console.WriteLine("No employees were entered.");
            }
        }
    }
}
