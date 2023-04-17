using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ukol;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form = new Form1();
        ukol.Hrac hrac = new ukol.Hrac();


        //done__________________________________________________________________done// - herni postava
            
        [TestMethod]
        public void TestMethod1()
        {
            ukol.HerniPostava postava = new ukol.HerniPostava();
            string jmeno = postava.metoda1("Hrac1");
            int delka = jmeno.Length;
            Assert.IsTrue(delka < 10);
        } //test delky - očekáváme true

        [TestMethod]
        public void TestMethod2()
        {
            ukol.HerniPostava postava = new ukol.HerniPostava();
            string jmeno = postava.metoda1("Hrac1Hrac1Hrac1");
            int delka = jmeno.Length;
            Assert.IsTrue(delka < 10);
        } //test delky - očekáváme false

        [TestMethod]
        public void TestMethod21()
        {
            ukol.HerniPostava postava = new ukol.HerniPostava();
            int pozice = postava.pozice(1);
            Assert.AreEqual(0, pozice);

        } // pozice, testing, očekáváme - true (nula);
        [TestMethod]

        public void TestMethod22()
        {
            ukol.HerniPostava postava = new ukol.HerniPostava();
            int pozice2 = postava.pozice(0);
            Assert.AreEqual(0, pozice2);
        }// pozice, testing, očekáváme - false (nula);
        [TestMethod]

        public void TestMethod23()
        {
            ukol.HerniPostava postava = new ukol.HerniPostava();
            int pozice = postava.pozice2(1);
            Assert.AreEqual(0, pozice);

        } //pozice druha, testing, očekáváme - false;
        [TestMethod]

        public void TestMethod24()
        {
            ukol.HerniPostava postava = new ukol.HerniPostava();
            int pozice2 = postava.pozice2(0);
            Assert.AreEqual(0, pozice2);
        }//pozice druha, testing, očekáváme - true;

        [TestMethod]

        public void TestMethod25()
        {
            ukol.HerniPostava postava = new ukol.HerniPostava();
            int lvl = postava.lvl;
            Assert.IsTrue(lvl != 1);
        } //lvl testing - očekáváme false, testujeme jestli je lvl 1 nebo ne

        [TestMethod]
        public void TestMethod26()
        {
            ukol.HerniPostava postava = new ukol.HerniPostava();
            int lvl = postava.lvl;
            Assert.AreEqual(1, lvl);
        }//lvl testing - false, testujeme jestli je lvl 1 nebo ne

        //done end__________________________________________________________________done end// - herni postava
        //done__________________________________________________________________done - Hrac
        //testujeme tady, dalsi stuff z třídy Hrac, která byla vytvořená profesionálním týmem
        [TestMethod]
        public void TestMethod3()
        {
            string Specializace = hrac.metoda2("Cizák");
            string[] pole = { "Kouzelník", "Kouzelník", "Berserk", "Inženýr", "Cizák" };
            Assert.IsTrue(Specializace.Contains(pole[0])|| Specializace.Contains(pole[1]) || Specializace.Contains(pole[2]) || Specializace.Contains(pole[3]) || Specializace.Contains(pole[4]));
        } // testujeme jestli je specializace v poli, očekáváme true

        [TestMethod]
        public void TestMethod4()
        {
            string Specializace = hrac.metoda2("Hynek");
            string[] pole = { "Kouzelník", "Kouzelník", "Berserk", "Inženýr", "Cizák" };
            Assert.IsTrue(Specializace.Contains(pole[0]) || Specializace.Contains(pole[1]) || Specializace.Contains(pole[2]) || Specializace.Contains(pole[3]) || Specializace.Contains(pole[4]));
        }// testujeme jestli je specializace v poli, očekáváme false


        [TestMethod]
        public void TestMethod5()
        {
            string Specializace = hrac.ksicht("usoplesk");
            string[] pole = { "usoplesk", "velkynos", "makeup" };
            Assert.IsTrue(Specializace.Contains(pole[0]) || Specializace.Contains(pole[1]) || Specializace.Contains(pole[2]));
        }// testujeme jestli je obličej v poli, očekáváme true

        [TestMethod]
        public void TestMethod6()
        {
            string ksicht = hrac.ksicht("HynekPlesk");
            string[] pole = { "usoplesk", "velkynos", "makeup" };
            Assert.IsTrue(ksicht.Contains(pole[0]) || ksicht.Contains(pole[1]) || ksicht.Contains(pole[2]));
        }// testujeme jestli je obličej v poli, očekáváme false


        [TestMethod]
        public void TestMethod7()
        {
            string vlasy = hrac.Vlasy("drdol");
            string[] pole = { "drdol", "culik", "pleska" };
            Assert.IsTrue(vlasy.Contains(pole[0]) || vlasy.Contains(pole[1]) || vlasy.Contains(pole[2]));
        }// testujeme jestli jsou vlasy v poli, očekáváme true

        [TestMethod]
        public void TestMethod8()
        {
            string vlasy = hrac.Vlasy("Long Long pleš");
            string[] pole = { "drdol", "culik", "pleska" };
            Assert.IsTrue(vlasy.Contains(pole[0]) || vlasy.Contains(pole[1]) || vlasy.Contains(pole[2]));
        }// testujeme jestli jsou vlasy v poli, očekáváme false


        [TestMethod]
        public void TestMethod9()
        {
            string barva = hrac.barva_vlasy("blond");
            string[] pole = { "kastanova", "blond", "cervena" };
            Assert.IsTrue(barva.Contains(pole[0]) || barva.Contains(pole[1]) || barva.Contains(pole[2]));
        }// testujeme jestli je barva vlasů v poli, očekáváme true

        [TestMethod]
        public void TestMethod91()
        {
            string barva = hrac.barva_vlasy("Ružová");
            string[] pole = { "kastanova", "blond", "cervena" };
            Assert.IsTrue(barva.Contains(pole[0]) || barva.Contains(pole[1]) || barva.Contains(pole[2]));
        }// testujeme jestli je barva vlasů v poli, očekáváme false

        //done__________________________________________________________________done end// - Hrac
        //done__________________________________________________________________done// - NPC
        //testujeme tady, dalsi stuff z třídy NPC, která byla vytvořená profesionálním týmem


        [TestMethod]
        public void TestMethod10()
        {
            ukol.NPC NPC = new ukol.NPC();
            string work = NPC.Praca("obyvatel");
            string[] pole = { "obchodnik", "nepritel", "obyvatel"};
            Assert.IsTrue(work.Contains(pole[0]) || work.Contains(pole[1]) || work.Contains(pole[2]));
        }//testujeme jestli je specilaizace NPC v poli, očekáváme true

        [TestMethod]
        public void TestMethod11()
        {
            ukol.NPC NPC = new ukol.NPC();
            string work = NPC.Praca("perodlak");
            string[] pole = { "obchodnik", "nepritel", "obyvatel" };
            Assert.IsFalse(work.Contains(pole[0]) || work.Contains(pole[1]) || work.Contains(pole[2]));
        }
        //testujeme jestli je specilaizace NPC v poli, očekáváme false

        [TestMethod]
        public void TestMethod12()
        {
            ukol.NPC NPC = new ukol.NPC();
            bool boos = NPC.sila;
            Assert.IsFalse(boos);
        }
        //bool test jestli je to boss nebo ne, očekáváme true

        [TestMethod]
        public void TestMethod13()
        {
            ukol.NPC NPC = new ukol.NPC();
            bool boos = NPC.sila;
            Assert.IsTrue(boos);
        }
        //bool test jestli je to boss nebo ne, očekáváme false

    }
}
