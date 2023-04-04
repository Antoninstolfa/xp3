using NUnit.Framework;
using _27._03._2023;

namespace NUnitTestProject1
{
    public class Tests
    {
        Herni_postava herniPostava = new Herni_postava();
        Hrac player = new Hrac();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1POS()
        {
            string name = herniPostava.jmeno;    //jmeno krat�� ne� 10;
            Assert.IsTrue(name.Length <= 10); 
        }

        [Test]
        public void Test1NEG()
        {
            string name = herniPostava.jmeno ;   //jmeno del�� ne� 10;                          Nefunguje
            Assert.IsTrue(name.Length > 10);
        }

        [Test]
        public void Test2POS()
        {
            int level = herniPostava.level;      //zji�t�n� spr�vne inicializace
            int x = herniPostava.pozice_X, y = herniPostava.pozice_Y;
            Assert.IsTrue(level == 1 && x == 0 && y == 0);
        }

        [Test]
        public void Test2NEG()
        {
            int level = herniPostava.level;      //zji�t�n� nespr�vne inicializace
            int x = herniPostava.pozice_X, y = herniPostava.pozice_Y;
            Assert.IsTrue(level != 1 && x != 0 && y != 0);
        }

        [Test]
        public void Test3POS()
        {
            int poz_x = herniPostava.pozice_X; //testov�n� zm�ny pozice
            int poz_y = herniPostava.pozice_Y;

            int poz_mysiX = herniPostava.mys_pozX;
            int poz_mysiY = herniPostava.mys_pozY;
            //volan� funkce, zm�na pozice
            herniPostava.zmena_pozice();

            Assert.AreEqual(poz_x + poz_y, poz_mysiX + poz_mysiY);                                              //Nefunguje
        }

        [Test]
        public void Test3NEG()
        {
            int poz_x = herniPostava.pozice_X; //testov�n� zm�ny pozice
            int poz_y = herniPostava.pozice_Y;

            int poz_mysiX = herniPostava.mys_pozX;
            int poz_mysiY = herniPostava.mys_pozY;
            //volan� funkce, zm�na pozice
            herniPostava.zmena_pozice();

            Assert.AreEqual(poz_x - poz_y, poz_mysiX - poz_mysiY);
        }

        [Test]
        public void Test4POS()
        {
            string specizalizace = player.specializace; //testov�n� nespravn�ho n�zvu specializace
            Assert.IsTrue(specizalizace == "Kouzeln�k" || specizalizace == "Berserker" || specizalizace == "In�en�r" || specizalizace == "Ciz�k");
        }

        [Test]
        public void Test4NEG()
        {
            string specizalizace = player.specializace; //testov�n� nespravn�ho n�zvu specializace
            Assert.IsTrue(specizalizace != "Kouzeln�k" && specizalizace != "Berserker" && specizalizace != "In�en�r" && specizalizace != "Ciz�k");
        }

        [Test]
        public void Test5POS()
        {
            int XP = player.XP; //testov�n�  spravn� inicializace XP
            Assert.AreEqual(XP, 0);
        }

        [Test]
        public void Test5NEG()
        {
            int XP = player.XP; //testov�n� nespravn� inicializace XP
            Assert.AreNotEqual(XP, 0);
        }

        [Test]
        public void Test6POS()
        {
            Assert.IsTrue(Hrac.vlasy.drdol == 0); //test pozice v enumu
        }

        [Test]
        public void Test6NEG()
        {
            Assert.IsFalse(Hrac.vlasy.drdol == 0); //test pozice v enumu
        }

        [Test]
        public void Test7POS()
        {
            int ADD_XP = 1; //testov�n� p�idej XP funkce 
            int XP = player.XP;
            player.pridej_xp(ADD_XP);
            Assert.AreNotEqual(player.XP, XP + ADD_XP);
        }

        [Test]
        public void Test7NEG()
        {
            int ADD_XP = 1; //testov�n� p�idej XP funkce 
            int XP = player.XP;
            player.pridej_xp(ADD_XP);
            Assert.AreEqual(player.XP, XP + ADD_XP);
        }

        [Test]
        public void Test8POS()
        {
            int lvl = herniPostava.level; //testov�n� p�idej XP funkce 
            player.pridej_xp(100 * lvl + 1);
            Assert.AreNotEqual(herniPostava.level, lvl + 1);
        }

        [Test]
        public void Test8NEG()
        {
            int lvl = herniPostava.level; //testov�n� p�idej XP funkce 
            player.pridej_xp(100 * lvl + 1);
            Assert.AreEqual(herniPostava.level, lvl + 1);
        }

        [Test]
        public void Test9POS()
        {
            int poz_x = herniPostava.pozice_X; //testov�n� rovnosti dan�ch pozic
            int poz_y = herniPostava.pozice_Y;

            int poz_mysiX = herniPostava.mys_pozX;
            int poz_mysiY = herniPostava.mys_pozY;
            //volan� funkce, zm�na pozice
            herniPostava.zmena_pozice();

            Assert.IsTrue(poz_x == poz_mysiX && poz_y == poz_mysiY);
        }

        [Test]
        public void Test9NEG()
        {
            int poz_x = herniPostava.pozice_X; //testov�n� rovnosti dan�ch pozic
            int poz_y = herniPostava.pozice_Y;

            int poz_mysiX = herniPostava.mys_pozX;
            int poz_mysiY = herniPostava.mys_pozY;
            //volan� funkce, zm�na pozice
            herniPostava.zmena_pozice();

            Assert.IsTrue(poz_x != poz_mysiX && poz_y != poz_mysiY);
        }

        [Test]
        public void Test10POS()
        {
            Assert.IsTrue(Hrac.oblicej.velky_nos == 0); //test pozice v enumu
        }

        [Test]
        public void Test10NEG()
        {
            Assert.IsFalse(Hrac.oblicej.velky_nos == 0); //test pozice v enumu
        }
    }
} 