﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");

            //TODO: Print the Average of numbers
            double average = numbers.Average();
            Console.WriteLine($"Average of numbers: {average}");

            //TODO: Order numbers in ascending order and print to the console
            var orderedNumbers = (from n in numbers
                                  orderby n
                                  select n).ToArray();
            Console.WriteLine("Numbers in ascending order:");
            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }
            //TODO: Order numbers in descending order and print to the console
            var orderNumbers = numbers
            .OrderByDescending(n => n)
            .ToArray();
            Console.WriteLine("Numbers in descending order:");
            foreach (var number in orderNumbers)
            {
                Console.WriteLine(number);
            }






            //TODO: Print to the console only the numbers greater than 6
            var filteredNumbers = numbers
            .Where(n => n > 6)
            .ToArray();
            Console.WriteLine("Numbers greater than 6:");
            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var orderedNumber = numbers.OrderByDescending(n => n).ToArray();
            Console.WriteLine("First 4 numbers in descending order:");
            int count = 0;
            foreach (var number in orderedNumbers)
            {
                if (count < 4)
                {
                    Console.WriteLine(number);
                    count++;
                }
                else
                {
                    break; 
                }
            }



            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 39;
            var orderedNumbersss = numbers.OrderByDescending(n => n).ToArray();
            Console.WriteLine("Numbers in descending order after changing index 4:");
            foreach (var number in orderedNumbersss)
            {
                Console.WriteLine(number);
            }
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

                //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
                 var filteredEmployees = employees
                .Where(e => e.FirstName.StartsWith("C") || e.FirstName.StartsWith("S"))
                .OrderBy(e => e.FirstName);
                foreach (var employee in filteredEmployees)
                {
                    Console.WriteLine(employee.FullName);
                }
                //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
                var filterEmployees = employees
                 .Where(e => e.Age > 26)
                 .OrderBy(e => e.Age)
                 .ThenBy(e => e.FirstName);

                // Print FullName and Age of filtered employees
                foreach (var employee in filteredEmployees)
                {
                    Console.WriteLine($"{employee.FullName} - Age: {employee.Age}");
                }
                //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
                 var sumYearsOfExperience = employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                .Sum(e => e.YearsOfExperience);
                 Console.WriteLine($"Sum of Years of Experience for employees with YOE <= 10 and Age > 35: {sumYearsOfExperience}");
                //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
                var averageYearsOfExperience = employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                .Average(e => e.YearsOfExperience);
                Console.WriteLine($"Average of Years of Experience for employees with YOE <= 10 and Age > 35: {averageYearsOfExperience}");
                //TODO: Add an employee to the end of the list without using employees.Add()
                employees = new List<Employee>(employees.Concat(new[] { new Employee("Michele", "Mostoller", 39, 1) }));
                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.FullName} - Age: {employee.Age}");
                }
                Console.WriteLine();

                Console.ReadLine();


                #region CreateEmployeesMethod
                 static List<Employee> CreateEmployees()
                {
                    List<Employee> employees = new List<Employee>();
                    employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
                    employees.Add(new Employee("Steven", "Bustamento", 56, 5));
                    employees.Add(new Employee("Micheal", "Doyle", 36, 8));
                    employees.Add(new Employee("Daniel", "Walsh", 72, 22));
                    employees.Add(new Employee("Jill", "Valentine", 32, 43));
                    employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
                    employees.Add(new Employee("Big", "Boss", 23, 14));
                    employees.Add(new Employee("Solid", "Snake", 18, 3));
                    employees.Add(new Employee("Chris", "Redfield", 44, 7));
                    employees.Add(new Employee("Faye", "Valentine", 32, 10));

                    return employees;
                }
                #endregion
            }
        }
    }


