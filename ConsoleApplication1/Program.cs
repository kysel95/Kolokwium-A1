using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public enum Kolor
    {
        Biel,
        Czerwony,
        Zielony,
        Czarny
    }
    public class Dom:ProjektDomu
    {
        private string drzwi;
        private Kolor kolorElewacji;
        private string okno;

        public Dom()
        {

        }
        public Dom(string drzwi,Kolor kolor, string okno)
        {
            this.drzwi = drzwi;
            this.kolorElewacji = kolor;
            this.okno = okno;

        }
        public override void WstawOkna(string okno)
        {
            this.okno = okno;
        }
        public override void ZamontujDrzwi(string drzwi)
        {
            this.drzwi = drzwi;
        }
        public override void PomalujElewacje(Kolor kolor)
        {
            this.kolorElewacji = kolor;
        }
        public override string ToString()
        {
            return base.ToString() + " Okna: " + okno.ToString() + " Drzwi: " + drzwi.ToString() + " Kolor: " + kolorElewacji.ToString();
        }

    }
    public abstract class ProjektDomu
    {
        protected Dom dom;

        public void NowyDom(Dom dom)
        {
            this.dom = dom;
        }
        public virtual void WstawOkna(string rodzajOkien)
        {
        
        }
        public virtual void ZamontujDrzwi(string rodzajDrzwi)
        {

        }
        public virtual void PomalujElewacje(Kolor kolor)
        {
            
        }
    }
    public class Biurowiec:ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
 	        throw new NotImplementedException();        
        }
        public override void ZamontujDrzwi(string rodzajDrzwi)
        {
            base.ZamontujDrzwi("szklane");
        }
        public override string ToString()
        {
            return "Biurowiec:" + base.ToString();
        }
    }
    public class DomJednorodzinny:ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            Console.WriteLine(Kolor.Czerwony);
        }
        public override string ToString()
        {
            return "Dom jednorodzinny:" + base.ToString();
        }
    }
    public class SzefBudowy
    {
        private ProjektDomu projektDomu;

        public void WybierzProjekt(ProjektDomu projekt)
        {
            this.projektDomu = projekt;
        }
        public void Buduj(string rodzajOkien,string rodzajDrzwi,Kolor kolor)
        {
            Console.WriteLine(rodzajOkien, rodzajDrzwi, kolor);
        }
        public string ToString(ProjektDomu projektDomu)
        {
            return base.ToString();
        }

    }
}
