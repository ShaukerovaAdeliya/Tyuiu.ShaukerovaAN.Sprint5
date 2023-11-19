using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ShaukerovaAN.Sprint5.Task3.V19.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint5.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\shauk\source\repos\Tyuiu.ShaukerovaAN.Sprint5\Tyuiu.ShaukerovaAN.Sprint5.Task3.V19\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
