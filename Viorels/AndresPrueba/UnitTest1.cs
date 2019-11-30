using System;
using Andres;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AndresPrueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaSave()
        {
            //Organizar
            Person account = new Person("Arrazola Juanpa", 5000);
            double valoresperado = 2000;


            //Actuar
            account.Save(3000);
            double valorobtenido = account.SaveMoney;

            // Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);

        }
        [TestMethod]


        public void PruebaSpend()
        {
            //Organizar
            Person account = new Person("Arrazola Juanpa", 1000);
            double valoresperado = 5000;


            //Actuar
            account.Spend(4000);
            double valorobtenido = account.SaveMoney;

            // Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);

        }
        [TestMethod]

        public void PruebaChangeName()
        {
            //Organizar
            Person account = new Person("David Gutierrez",0);
            string valoresperado = "David Gutierrez";


            //Actuar
            account.ChangeName("Julio Mercado");
            string valorobtenido = account.Name;

            // Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);

        }
    }
}
