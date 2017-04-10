using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleRPGBusinessLayer;

namespace ConsoleRPGBusinessLayerTest
{
    [TestClass]
    public class BackPack_Test
    {
        Backpack testBackPack = new Backpack();
        
        [TestMethod]
        public void AddNewItemTest()
        {
            testBackPack.AddNewItem("dog", 4, 3);

        }
    }
}
