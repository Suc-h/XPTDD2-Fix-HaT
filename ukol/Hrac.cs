using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol
{
    public class Hrac : HerniPostava
    {
        public int xp;
        string specializace;
        int oblicej;
        int vlasy;
        int barvavlasu;

        public string Specializace { get => specializace; set => specializace = value; }
        enum Oblicej
        {
            velkynos, usoplesk, makeup
        }
        enum Vlasyy
        {
            drdol, culik, pleska
        }
        enum BarvaVlasu
        {
            kastanova, blond, červena
        }
        public Hrac(string jmeno, string specializace, int oblicej, int vlasy, int barvavlasu) : base(jmeno)
        {
            this.specializace = Specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvavlasu = barvavlasu;
        }

        public Hrac() 
        {   
            
        }

        public string metoda2(string specializace)
        {
            Specializace = specializace;
            return Specializace;
        }

        public string ksicht(string ksich)
        {
            Oblicej face = new Oblicej();          
            switch (ksich)
            {
                case "velkynos": face = Oblicej.velkynos; break;
                case "usoplesk": face = Oblicej.usoplesk; break;
                case "makeup": face = Oblicej.makeup; break;
            }
            
            if (face.ToString() == ksich || face.ToString() == ksich|| face.ToString() == ksich)
            {
                return ksich;
                
            }
            return "kopanecdohlavy";
        }

        public string Vlasy(string vlasy)
        {
            Vlasyy hair = new Vlasyy();
          
            switch (vlasy)
            {
                case "drdol": hair = Vlasyy.drdol; break;
                case "culik": hair = Vlasyy.culik; break;
                case "pleska": hair = Vlasyy.pleska; break;
            }

            if (hair.ToString() == vlasy || hair.ToString() == vlasy || hair.ToString() == vlasy)
            {
                return vlasy;
            }

            return "vaginotlak";
        }

        public string barva_vlasy(string barva)
        {
            BarvaVlasu dye = new BarvaVlasu();
            
            switch (barva)
            {
                case "kastanova": dye = BarvaVlasu.kastanova; break;
                case "blond": dye = BarvaVlasu.blond; break;
                case "cervena": dye = BarvaVlasu.červena; break;
            }

            if (dye.ToString() == barva || dye.ToString() == barva || dye.ToString() == barva)
            {
                return barva;

            }

            return "pochcana";
        }

        public void PridejXP(int x)
        {
            xp += x;
            if (xp >= 100 * lvl)
            {
                lvl++;
                xp = 0;
            }
        }
        public override string ToString()
        {
            return String.Format("Jmeno: {0}\nLevel: {1}\nX: {2}\nY: {3}\n", jmeno, lvl, PoziceX, PoziceY);
        }
    }
}
