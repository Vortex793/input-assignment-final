using System;

namespace User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which part of the code would you like to run (choose between 1-5)");
            Console.WriteLine("1 - Name Age and Salary");
            Console.WriteLine("2 - More User Input of Data");
            Console.WriteLine("3 - Age in 5 Years");
            Console.WriteLine("4 - A Dumb Calculator");
            Console.WriteLine("5 - The Cash Register");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) Part1();
            else if (choice == 2) Part2();
            else if (choice == 3) Part3();
            else if (choice == 4) Part4();
            else if (choice == 5) Part5();
            else Console.WriteLine("Invalid number :(");

                Console.ReadLine();
        }

        static void Part1()
        {
            string name;
            int age;
            double money;

            Console.Write("What is your name?: ");
            name = Console.ReadLine();

            Console.Write("Hi " + name + " How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("So you're " + age + " wow that's not old at all! How much money do you make, " + name + "? ");
            money = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(money + "! I really hope that's per hour and not per year!");
            Console.WriteLine();
        }

        static void Part2()
        {
            string firstName, lastName, login;
            int id;
            double grade, average;

            Console.Write("First name: ");
            firstName = Console.ReadLine();

            Console.Write("Last name: ");
            lastName = Console.ReadLine();

            Console.Write("Grade (9-12): ");
            grade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Student ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Login: ");
            login = Console.ReadLine();

            Console.Write("Average: ");
            average = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your information:");
            Console.WriteLine("\tLogin:\t" + login);
            Console.WriteLine("\tID:\t" + id);
            Console.WriteLine("\tName:\t" + firstName + " " + lastName);
            Console.WriteLine("\tAverage:" + average + "%");
            Console.WriteLine("\tGrade:\t" + grade);
            Console.WriteLine();
        }

        static void Part3()
        {
            string name;
            int age, plusYears, minusYears;

            Console.Write("What is your name?: ");
            name = Console.ReadLine();

            Console.Write("Hi " + name + " how old are you?: ");
            age = Convert.ToInt32(Console.ReadLine());

            plusYears = age + 5;
            minusYears = age - 5;

            Console.WriteLine("Did you know that you will be " + plusYears +
                              " in five years, and you were " + minusYears + " five years ago?");
            Console.WriteLine();
        }

        static void Part4()
        {
            double num1, num2, num3, total;

            Console.Write("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a final number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            total = (num1 + num2 + num3) / 2;

            Console.WriteLine("All numbers added together then divided by 2 equals " + total);
            Console.WriteLine();
        }

        static void Part5()
        {
            string item1, item2;
            double price1, price2, addedCost, discount, discountedPrice, total, tax, finalPrice;

            Console.Write("Enter your first item: ");
            item1 = Console.ReadLine();

            Console.Write("Enter the price of " + item1 + ": ");
            price1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your second item: ");
            item2 = Console.ReadLine();

            Console.Write("Enter the price of " + item2 + ": ");
            price2 = Convert.ToDouble(Console.ReadLine());

            addedCost = price1 + price2;

            discount = 0.20;
            discountedPrice = addedCost * discount;

            total = addedCost - discountedPrice;
            tax = total * 0.13;
            finalPrice = total + tax;

            Console.WriteLine("\nSales Receipt");
            Console.WriteLine("=====================");
            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Price: $" + price1);
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Price: $" + price2);
            Console.WriteLine("=====================");
            Console.WriteLine("Subtotal: $" + addedCost);
            Console.WriteLine("Discount (20%): -$" + discountedPrice);
            Console.WriteLine("After Discount: $" + total);
            Console.WriteLine("Tax (13%): $" + tax);
            Console.WriteLine("=====================");
            Console.WriteLine("Total Owed: $" + finalPrice);
            Console.WriteLine();
        }
    }
}
