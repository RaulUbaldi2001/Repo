using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatematicaLibrary;

namespace MatematicaLibrary.Test
{
    /// <summary>
    /// Descrizione del riepilogo per CalcolatriceTest
    /// </summary>
    [TestClass]
    public class CalcolatriceTest
    {
        public CalcolatriceTest()
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Ottiene o imposta il contesto del test che fornisce
        ///le informazioni e le funzionalità per l'esecuzione del test corrente.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributi di test aggiuntivi
        //
        // È possibile utilizzare i seguenti attributi aggiuntivi per la scrittura dei test:
        //
        // Utilizzare ClassInitialize per eseguire il codice prima di eseguire il primo test della classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilizzare ClassCleanup per eseguire il codice dopo l'esecuzione di tutti i test della classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilizzare TestInitialize per eseguire il codice prima di eseguire ciascun test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilizzare TestCleanup per eseguire il codice dopo l'esecuzione di ciascun test
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

            [TestMethod]
        public void Somma()
        {
            double num1 = 4;
            double num2 = 2;
            double risultato = 6;

            double somma = Calcolatrice.Somma(num1, num2);
            Assert.AreEqual(risultato, somma);
        }
        [TestMethod]
        public void TestSomma1()
        {
            double num1 = 0;
            double num2 = 1;
            double risultato = 1;

            double somma = Calcolatrice.Somma(num1, num2);
            Assert.AreEqual(risultato, somma);
        }
        [TestMethod]
        public void TestSomma2()
        {
            double num1 = 0;
            double num2 = 0;
            double risultato = 0;

            double somma = Calcolatrice.Somma(num1, num2);
            Assert.AreEqual(risultato, somma);
        }
        [TestMethod]
        public void TestSomma3()
        {
            double num1 = 7;
            double num2 = 0;
            double risultato = 7;

            double somma = Calcolatrice.Somma(num1, num2);
            Assert.AreEqual(risultato, somma);
        }
        [TestMethod]
        public void TestDivisione()
        {
            double num1 = 7;
            double num2 = 2;
            double risultato = 3.5;

            double divisione = Calcolatrice.Divisione(num1, num2);
            Assert.AreEqual(risultato, divisione);
        }
        [TestMethod]
        public void TestDivisione1()
        {
            double num1 = 0;
            double num2 = 0;
            double risultato = double.NaN;

            double divisione = Calcolatrice.Divisione(num1, num2);
            Assert.AreEqual(risultato, divisione);
        }
        [TestMethod]
        public void TestDivisione2()
        {
            double num1 = 1;
            double num2 = 0;
            double risultato = double.NaN;

            double divisione = Calcolatrice.Divisione(num1, num2);
            Assert.AreEqual(risultato, divisione);
        }
        [TestMethod]
        public void TestDivisione3()
        {
            double num1 = 0;
            double num2 = 1;
            double risultato = 0;

            double divisione = Calcolatrice.Divisione(num1, num2);
            Assert.AreEqual(risultato, divisione);
        }
        [TestMethod]
        public void TestMassimo()
        {
            double num1 = 9;
            double num2 = 2;
            double risultato = 9;

            double massimo = Calcolatrice.Massimo(num1, num2);
            Assert.AreEqual(risultato, massimo);
        }
        [TestMethod]
        public void TestMassimo1()
        {
            double num1 = 8;
            double num2 = 4;
            double risultato = 8;

            double massimo = Calcolatrice.Massimo(num1, num2);
            Assert.AreEqual(risultato, massimo);
        }
        [TestMethod]
        public void TestMassimo2()
        {
            double num1 = 4;
            double num2 = 4;
            double risultato = 4;

            double massimo = Calcolatrice.Massimo(num1, num2);
            Assert.AreEqual(risultato, massimo);
        }
        [TestMethod]
        public void TestMinimo()
        {
            double num1 = 3;
            double num2 = 2;
            double risultato = 2;

            double minimo = Calcolatrice.Minimo(num1, num2);
            Assert.AreEqual(risultato, minimo);
        }
        [TestMethod]
        public void TestMinimo1()
        {
            double num1 = 3;
            double num2 = 12;
            double risultato = 3;

            double minimo = Calcolatrice.Minimo(num1, num2);
            Assert.AreEqual(risultato, minimo);
        }
        [TestMethod]
        public void TestMinimo2()
        {
            double num1 = 7;
            double num2 = 7;
            double risultato = 7;

            double minimo = Calcolatrice.Minimo(num1, num2);
            Assert.AreEqual(risultato, minimo);
        }







        [TestMethod]
        public void TestMedia()
        {
            double num1 = 5;
            double num2 = 2;
            double risultato = 3.5;

            double media = Calcolatrice.Media(num1, num2);
            Assert.AreEqual(risultato, media);
        }
        [TestMethod]
        public void TestMedia1()
        {
            double num1 = 4;
            double num2 = 3;
            double risultato = 3.5;

            double media = Calcolatrice.Media(num1, num2);
            Assert.AreEqual(risultato, media);
        }
        [TestMethod]
        public void TestMedia2()
        {
            double num1 = 7;
            double num2 = 7;
            double risultato = 7;

            double media = Calcolatrice.Media(num1, num2);
            Assert.AreEqual(risultato, media);
        }









        [TestMethod]
        public void TestMediaTreNumeri()
        {
            double num1 = 7;
            double num2 = 7;
            double num3 = 7;
            double risultato = 7;

            double mediatre = Calcolatrice.Mediatre(num1, num2, num3);
            Assert.AreEqual(risultato, mediatre);
        }
        [TestMethod]
        public void TestMediaTreNumeri1()
        {
            double num1 = 4;
            double num2 = 3;
            double num3 = 5;
            double risultato = 4;

            double mediatre = Calcolatrice.Mediatre(num1, num2, num3);
            Assert.AreEqual(risultato, mediatre);
        }
        [TestMethod]
        public void TestMediaTreNumeri2()
        {
            double num1 = 6;
            double num2 = 7;
            double num3 = 5;
            double risultato = 6;

            double mediatre = Calcolatrice.Mediatre(num1, num2, num3);
            Assert.AreEqual(risultato, mediatre);
        }








        [TestMethod]
        public void TestMinimotre()
        {
            double num1 = 7;
            double num2 = 7;
            double num3 = 7;
            double risultato = 7;

            double minimotre = Calcolatrice.Minimotre(num1, num2, num3);
            Assert.AreEqual(risultato, minimotre);
        }
        [TestMethod]
        public void TestMinimotre1()
        {
            double num1 = 4;
            double num2 = 3;
            double num3 = 5;
            double risultato = 3;

            double minimotre = Calcolatrice.Minimotre(num1, num2, num3);
            Assert.AreEqual(risultato, minimotre);
        }
        [TestMethod]
        public void TestMinimotre2()
        {
            double num1 = 6;
            double num2 = 7;
            double num3 = 5;
            double risultato = 5;

            double minimotre = Calcolatrice.Minimotre(num1, num2, num3);
            Assert.AreEqual(risultato, minimotre);
        }
        [TestMethod]
        public void TestMassimotre()
        {
            double num1 = 7;
            double num2 = 7;
            double num3 = 7;
            double risultato = 7;

            double massimotre = Calcolatrice.Massimotre(num1, num2, num3);
            Assert.AreEqual(risultato, massimotre);
        }
        [TestMethod]
        public void TestMassimotre1()
        {
            double num1 = 4;
            double num2 = 3;
            double num3 = 5;
            double risultato = 5;

            double massimotre = Calcolatrice.Massimotre(num1, num2, num3);
            Assert.AreEqual(risultato, massimotre);
        }
        [TestMethod]
        public void TestMassimotre2()
        {
            double num1 = 6;
            double num2 = 7;
            double num3 = 5;
            double risultato = 7;

            double massimotre = Calcolatrice.Massimotre(num1, num2, num3);
            Assert.AreEqual(risultato, massimotre);
        }
    }
}



