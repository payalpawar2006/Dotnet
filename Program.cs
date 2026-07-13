using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            Console.WriteLine("\n===== Employee System =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Exit");

            Console.Write("Enter Choice 1-4 : ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Enter id : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        bool exists = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == id)
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (exists)
                        {
                            Console.WriteLine("Employee id already exists");
                            break;
                        }

                        Console.Write("Enter name : ");
                        string name = Console.ReadLine();

                        Console.Write("Enter salary : ");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        Employee employee = new Employee(id, name, salary);

                        employees.Add(employee);

                        Console.WriteLine("Employee Added Successfully");

                        break;

                    case 2:

                        if (employees.Count == 0)
                        {
                            Console.WriteLine("No Employees in System");
                        }
                        else
                        {
                            foreach (Employee emp in employees)
                            {
                                emp.Display();
                            }
                        }

                        break;

                    case 3:

                        Console.Write("Enter Employee Id : ");
                        int searchId = Convert.ToInt32(Console.ReadLine());

                        bool found = false;

                        foreach (Employee emp in employees)
                        {
                            if (emp.Id == searchId)
                            {
                                emp.Display();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Employee not found");
                        }

                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}