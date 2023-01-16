using Frazioni;
namespace TestLibreria
{
    public class UnitTest1
    {
        [Fact]
        
        public void Test1()
        {
            Frazioni.Fractions frazione = new Fractions(-314, 2);
            
            frazione.Semplifica();
            Assert.True(frazione.Numeratore == -157);
            Assert.True(frazione.Denominatore == 1);
        }
        [Fact]
        public void Test2()
        {
            Frazioni.Fractions frazione = new Fractions(-314, 2);
            Frazioni.Fractions frazione2 = new Fractions(1,1);
            frazione2=frazione.Somma(frazione2);
            Assert.True(frazione2.Numeratore == -312);
            
        }
        [Fact]
        public void Test3()
        {
            Frazioni.Fractions frazione = new Fractions(-314, 2);
            Frazioni.Fractions frazione2 = new Fractions(2, 1);
            frazione2 = frazione.Dividi(frazione2);
            Assert.True(frazione2.Denominatore == 4);

        }
        
        [Fact]
        public void Test5()
        {
            Frazioni.Fractions frazione = new Fractions(-314, 2);
            Frazioni.Fractions frazione2 = new Fractions(1, 1);
            frazione2 = frazione.Sottrai(frazione2);
            Assert.True(frazione2.Numeratore == -316);

        }
        
        [Fact]
        public void Test6()
        {
            Frazioni.Fractions frazione = new Fractions(0, 2);
            Frazioni.Fractions frazione2 = new Fractions(1, 0);
            Assert.Throws<Exception>(() => frazione2 = frazione.Dividi(frazione2));

        }
        [Fact]
        public void Test7()
        {
            Frazioni.Fractions frazione = new Fractions(0, 2);
            Frazioni.Fractions frazione2 = new Fractions(0,1);
            Assert.Throws<Exception>(() => frazione2 = frazione.Dividi(frazione2));

        }
        /*
        [Fact]
        
        public void Test8()
        {
            Frazioni.Fractions frazione = new Fractions(-1, 2);
            Frazioni.Fractions frazione2 = new Fractions(-1, 2);
            Assert.True(frazione2.Equals(frazione));

        }
        */
        [Fact]
        public void Test9()
        {
            Frazioni.Fractions frazione = new Fractions(-1, 2);
            Frazioni.Fractions frazione2 = new Fractions(-1, 2);
            frazione2 = frazione.Moltiplica(frazione2);
            Assert.True(frazione2.Numeratore==1);
        }
        [Fact]
        public void Test10()
        {
            Frazioni.Fractions frazione = new Fractions(-590, 214);
            frazione.Semplifica();
            Assert.True(frazione.Numeratore==-295);
        }
        [Fact]
        public void Test11()
        {
            Frazioni.Fractions frazione = new Fractions(0, 2);
            Frazioni.Fractions frazione2 = new Fractions(2, 0);
            Assert.Throws<Exception>(() => frazione2 = frazione.Dividi(frazione2));
        }

    }
}