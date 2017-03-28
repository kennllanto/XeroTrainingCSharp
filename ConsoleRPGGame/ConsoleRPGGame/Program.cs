using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPGBusinessLayer;

namespace ConsoleRPGGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Backpack myBackPack = new Backpack();

  

            Console.WriteLine("Welcome to your backpack.");
            Console.WriteLine("A - to add an item into your backpack");
            Console.WriteLine("D - to Display items in your backpack");
            // todo Console.WriteLine("R - to Remove an item in your backpack");
            // todo Console.WriteLine("E - to Empty and Remove all items in your backpack");
            Console.WriteLine("Q - to Empty and Remove all items in your backpack");
            ConsoleKeyInfo key = Console.ReadKey();
            do
            {
                if((key.Key == ConsoleKey.A) || (key.Key == ConsoleKey.D))
                {
                    BackPackAction(key, myBackPack);
                }

                Console.WriteLine();
                Console.WriteLine("A - to add an item into your backpack");
                Console.WriteLine("D - to Display items in your backpack");
                // todo Console.WriteLine("R - to Remove an item in your backpack");
                // todo Console.WriteLine("E - to Empty and Remove all items in your backpack");
                Console.WriteLine("Q - to Empty and Remove all items in your backpack");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Q);

            return;
        }

        private static Backpack BackPackAction(ConsoleKeyInfo key, Backpack backPack)
        {
            try
            {
                Console.WriteLine();
                if (key.Key == ConsoleKey.A)
                {
                    string name;
                    string weight;
                    string size;
                    int weightValue;
                    int sizeValue;
                    Console.WriteLine("To add an item, enter the following: \"item Name, item Weight, item Size \"");
                    Console.Write("Item Name: ");
                    name = Console.ReadLine();
                    Console.Write("Item Weight: ");
                    weight = Console.ReadLine();
                    bool isWeightNumeric = int.TryParse(weight, out weightValue);
                    Console.Write("Item Size: ");
                    size = Console.ReadLine();
                    bool isSizeNumeric = int.TryParse(size, out sizeValue);
                    if (isWeightNumeric && isSizeNumeric)
                    {
                        backPack.AddNewItem(name, weightValue, sizeValue);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, weight and size should be numeric");
                    }

                }
                else if (key.Key == ConsoleKey.D)
                {
                    Console.WriteLine("Your backpack contains the following:");
                    backPack.Display();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input entered: '{0}'", e);
            }
            return backPack;
        }
    }
}
