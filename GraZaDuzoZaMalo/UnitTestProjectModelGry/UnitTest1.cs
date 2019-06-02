using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelGry;

namespace UnitTestProjectModelGry
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 10)]
        [DataRow(1, 1)]
        [DataRow(10, 1)]
        public void Losuj_OK(int x, int y)
        {
            //Arrange-Act-Assert = AAA

            //Arrange

            //Act
            int wylos = Gra.Losuj(x, y);

            //Assert
            Assert.IsTrue(wylos >= Math.Min(x, y)
                       && wylos <= Math.Max(x, y));
        }
    }
}
