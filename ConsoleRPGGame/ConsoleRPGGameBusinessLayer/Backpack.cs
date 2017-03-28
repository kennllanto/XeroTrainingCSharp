using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGBusinessLayer
{
    public class Backpack
    {
        private List<Item> contents = new List<Item>();
        private const int backpackweightLimit = 20;
        private const int backpackCapacityLimit = 20;
        private int backpackCurrentWeight;
        private int backpackCurrentCapacity;

        public Backpack()
        {
            var contents = new List<string>();
            backpackCurrentWeight = 0;
            backpackCurrentCapacity = 0;
        }

        public Boolean AddNewItem(string itemName, int itemWeight, int itemSize)
        {
            int newWeight = backpackCurrentWeight + itemWeight;
            int newSize = backpackCurrentCapacity + itemSize;
            if (newWeight > backpackweightLimit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You cannot add the " + itemName + ", backpack will be overweight. Current weight = " + backpackCurrentWeight.ToString());
                Console.WriteLine("Weight Limit = " + backpackweightLimit.ToString() + " Your bag will be overweight by " + (newWeight - backpackweightLimit));
                Console.ForegroundColor = ConsoleColor.Black;
                return false;
            }
            if (newSize > backpackCapacityLimit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You cannot add the" +  itemName + ", item will not fit. Current Contents = " + backpackCurrentCapacity.ToString());
                Console.WriteLine("Capacity Limit = " + backpackCapacityLimit.ToString() + " Your bag will be over by " + (newSize - backpackCapacityLimit));
                Console.ForegroundColor = ConsoleColor.Black;
                return false;
            }
            Item newItem = new Item(itemName, itemWeight, itemSize);
            Console.WriteLine(itemName + " successfully added.");
            backpackCurrentWeight += itemWeight;
            backpackCurrentCapacity += itemSize;

            contents.Add(newItem);
            return true;
        }

        public void RemoveItem(string itemName)
        {
            // todo
        }

        public void Display()
        {
            foreach (Item item in contents)
            {
                Console.Write(item.ItemName);
                Console.Write(", ");
                Console.Write(item.ItemWeight.ToString());
                Console.Write("kg, ");
                Console.Write(item.ItemSize.ToString());
                Console.WriteLine("spaces");
            }
            int availableWeight = backpackweightLimit - backpackCurrentWeight;
            int availableSpace = backpackCapacityLimit - backpackCurrentCapacity;
            Console.WriteLine("Current Weight = " + backpackCurrentWeight.ToString() + ", you still have " + availableWeight + "kg remaining");
            Console.WriteLine("Current Size Capacity = " + backpackCurrentCapacity.ToString() + ", you still have " + availableSpace + " units remaining");
        }
    }
}
