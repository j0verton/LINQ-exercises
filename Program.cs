﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {


        public static void Main()
        {
            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            // Create some customers and store in a List
            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            /*
                You will need to use the `Where()`
                and `Select()` methods to generate
                instances of the following class.

                public class ReportItem
                {
                    public string CustomerName { get; set; }
                    public string BankName { get; set; }
                }
            */
            List<ReportItem> millionaireReport = banks.Join(customers, bank => bank.Symbol, customer => customer.Bank, (bank, customer) => new ReportItem
            {
                BankName = bank.Name,
                CustomerName = customer.Name
            }).OrderBy(n => n.CustomerName.Split(" ")[1]).ToList();

            foreach (var item in millionaireReport)
            {
                Console.WriteLine($"{item.CustomerName} at {item.BankName}");
            }

            // List<Customer> customers = new List<Customer>() {
            //     new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            //     new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            //     new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            //     new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            //     new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            //     new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            //     new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            //     new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            //     new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            //     new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            // };

            // List<Customer> millionaires = customers.Where(c => c.Balance > 1e6).ToList();

            // var results = millionaires.GroupBy(
            //     m => m.Bank,
            //     m => m.Name,
            //     (key, g) => new { Bank = key, Names = g.ToList() });

            // // List<> results
            // foreach (var result in results)
            // {
            //     Console.WriteLine($"{result.Bank}: {result.Names.Count} millionaires");
            // }


            // millionaires.GroupBy(customer => customer.Bank)
            // .ToList()
            // .ForEach(group =>
            // {
            //     Console.WriteLine($"{group.Key} {group.Count()}");
            // });

            //convert to list 

            //// Restriction/Filtering Operations
            // // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // List<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L")).ToList();
            // LFruits.ForEach(fruit => Console.WriteLine(fruit));


            // // Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // List<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0).ToList();
            // fourSixMultiples.ForEach(num => Console.WriteLine(num));
            // // Ordering Operations
            // //Order these student names alphabetically, in descending order (Z to A)
            //             List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre"
            // };

            //             List<string> descend = names.OrderByDescending(n => n).ToList();
            //             descend.ForEach(num => Console.WriteLine(num));

            // // Build a collection of these numbers sorted in ascending order
            // List<int> numbers = new List<int>()
            //             {
            //                 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            //             };
            // List<int> sortedNums = numbers.OrderBy(n => n).ToList();
            // sortedNums.ForEach(num => Console.WriteLine(num));


            // // Aggregate Operations
            // // Output how many numbers are in this list
            // List<int> moreNumbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };
            // Console.WriteLine(moreNumbers.Count());

            // // How much money have we made?
            // List<double> purchases = new List<double>()
            // {
            //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            // };
            // Console.WriteLine(purchases.Sum());

            // // What is our most expensive product?
            // List<double> prices = new List<double>()
            // {
            //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            // };


            // Console.WriteLine(prices.Max());

            // // Partitioning Operations
            // List<int> wheresSquaredo = new List<int>()
            //     {
            //         66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            //     };

            // List<int> noSquaredo = wheresSquaredo.TakeWhile(num =>
            // {
            //     double sRootNum = Math.Sqrt(num);
            //     bool isSquare = sRootNum % 1 == 0;
            //     return !isSquare;
            // }).ToList();

            // noSquaredo.ForEach(num => Console.WriteLine(num));
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */


        }
    }
}