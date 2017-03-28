using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGBusinessLayer
{
    class Item
    {
        private string itemName;
        private int itemWeight;
        private int itemSize;

        public string ItemName { get { return itemName; }}
        public int ItemWeight { get { return itemWeight; }}
        public int ItemSize { get { return itemSize; } }
        public Item (string Name, int Weight, int Size)
        {
            this.itemName = Name;
            this.itemWeight = Weight;
            this.itemSize = Size;
        }
    }
}
