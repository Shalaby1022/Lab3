using System;
using System.Runtime.Intrinsics.X86;

namespace LAB3
{
    internal class Program
    {
        struct Employee
        {
            private int ssn;
            private string fname;
            private string lname;
            private int age;
            private string address;



            public void SetSsn(int _ssn)
            {
                ssn = _ssn;
            }

            public void SetFname(string _fname)
            {
                fname = _fname;
            }

            public void SetLname(string _lname)
            {
                lname = _lname;
            }

            public void SetAge(int _age)
            {
                if (_age >= 23 && _age <= 45)
                {
                    age = _age;
                }
                else
                {
                    throw new ArgumentException("Invalid age. Age must be between 23 and 45.");
                }
            }

            public void SetAddress(string _address)
            {
                string comparedAddress = _address.ToLower();

                if (comparedAddress == "cairo" || comparedAddress == "alex" || comparedAddress == "giza")
                {
                    address = _address;
                }
                else
                {
                    throw new ArgumentException("Invalid address. Address must be cairo, alex, or giza.");
                }
            }

            // Getters Methods.
            public int GetSsn()
            {
                return ssn;

            }

            public string GetFirstNmae()
            {
                return fname;

            }

            public string GetLastName()
            {
                return lname;
            }

            public int GetAge()
            {
                return age;
            }
            public string GetAddress()
            {
                return address;

            }

            public void PrintOneConsole()
            {
                Console.WriteLine($"SSN: {ssn}");
                Console.WriteLine($"Name: {fname} {lname}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Address: {address}");
            }

            public string PrintAsString()
            {
                return $"SSN: {GetSsn}\nName: {GetFirstNmae} {GetLastName}\nAge: {GetAge}\nAddress: {GetAddress}";
            }


        }

        static void Main(string[] args)
        {
            Employee e = new Employee();



            Console.WriteLine("Enter your SSN:");
            int ssn = int.Parse(Console.ReadLine());
            e.SetSsn(ssn);

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            e.SetFname(firstName);

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            e.SetLname(lastName);

            Console.WriteLine("Enter your age:");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 23 || age > 45)
            {
                Console.WriteLine("Invalid age. Age must be between 23 and 45. Please try again:");
            }
            e.SetAge(age);

            Console.WriteLine("Enter your address (Cairo, Alex, or Giza):");
            string address;
            while (true)
            {
                address = Console.ReadLine().ToLower();
                if (address == "cairo" || address == "alex" || address == "giza")
                {
                    break;
                }
                Console.WriteLine("Invalid address. Address must be cairo, alex, or giza. Please try again:");
            }
            e.SetAddress(address);

            Console.WriteLine("\nEmployee Data:");
            e.PrintOneConsole();

            // print number of employees 
            Console.WriteLine("Enter the number of employees:");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Employee E = new Employee();

                Console.WriteLine($"\nEmployee {i + 1}:");

                Console.WriteLine("Enter SSN:");
                int Ssn = int.Parse(Console.ReadLine());
                E.SetSsn(Ssn);

                Console.WriteLine("Enter first name:");
                string Fname = Console.ReadLine();
                E.SetFname(Fname);

                Console.WriteLine("Enter last name:");
                string Lname = Console.ReadLine();
                E.SetLname(Lname);

                Console.WriteLine("Enter age:");
                int Age;
                while (!int.TryParse(Console.ReadLine(), out Age) || Age < 23 || Age > 45)
                {
                    Console.WriteLine("Invalid age. Age must be between 23 and 45. Please try again:");
                }
                E.SetAge(Age);

                Console.WriteLine("Enter address (Cairo, Alex, or Giza):");
                string Add;
                while (true)
                {
                    Add = Console.ReadLine().ToLower();
                    if (Add == "cairo" || Add == "alex" || Add == "giza")
                    {
                        break;
                    }
                    Console.WriteLine("Invalid address. Address must be Cairo, Alex, or Giza. Please try again:");
                }
                E.SetAddress(Add);

                employees[i] = E;
            }

            Console.WriteLine("\nEmployee Data:");

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"\nEmployee {i + 1}:");
                employees[i].PrintOneConsole();
            }
        }
    }
}
