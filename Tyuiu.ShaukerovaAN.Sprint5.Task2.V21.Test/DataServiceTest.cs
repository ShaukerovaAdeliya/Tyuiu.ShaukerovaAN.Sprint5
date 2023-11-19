using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ShaukerovaAN.Sprint5.Task2.V21.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint5.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveFile()
        {
            string path = @"C:\Users\shauk\source\repos\Tyuiu.ShaukerovaAN.Sprint5\Tyuiu.ShaukerovaAN.Sprint5.Task2.V21\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
