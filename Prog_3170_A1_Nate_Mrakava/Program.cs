using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_3170_A1_Nate_Mrakava {
    internal class Program {
        static void Main(string[] args) {
            A1Service.ServiceClient srv = new A1Service.ServiceClient();
            for(; ; ) {
                try {
                    Console.WriteLine("1. Prime number\r\n2. Sum of digits\r\n3. Reverse a string\r\n4. Print HTML tags\r\n5. Sort 5 numbers\r\n6. Exit\r\n");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1) {
                        Console.WriteLine("Enter a number:");
                        int value = int.Parse(Console.ReadLine());
                        Console.WriteLine(srv.PrimeNumber(value) + "\n");
                        Console.ReadKey();
                    }
                    else if (choice == 2) {
                        Console.WriteLine("Enter a number:");
                        int value = int.Parse(Console.ReadLine());
                        Console.WriteLine(srv.SumOfDigits(value) + "\n");
                        Console.ReadKey();
                    }
                    else if (choice == 3) {
                        Console.WriteLine("Type something:");
                        string value = Console.ReadLine();
                        Console.WriteLine(srv.ReverseString(value) + "\n");
                        Console.ReadKey();
                    }
                    else if (choice == 4) {
                        Console.WriteLine("What do you want in the tags:");
                        string value = Console.ReadLine();
                        Console.WriteLine("What tags:");
                        string tags = Console.ReadLine();
                        Console.WriteLine(srv.PrintTags(value, tags) + "\n");
                        Console.ReadKey();
                    }
                    else if (choice == 5) {
                        Console.WriteLine("Enter the first number:");
                        int value1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second number:");
                        int value2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the third number:");
                        int value3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the fourth number:");
                        int value4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the fifth number:");
                        int value5 = int.Parse(Console.ReadLine());
                        int[] value = new int[] { value1, value2, value3, value4, value5 };
                        Console.WriteLine("Enter 0 for ASC, 1 for DESC:");
                        int by = int.Parse(Console.ReadLine());
                        if (by == 0) {
                            Console.WriteLine(srv.SortArray(value, false));
                        } else {
                            Console.WriteLine(srv.SortArray(value, true));
                        }
                        Console.ReadKey();
                    }
                    else {
                        Environment.Exit(0);
                    }

                }
                catch {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}

