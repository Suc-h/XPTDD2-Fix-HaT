using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol
{
    public class NPC: HerniPostava
    {
        public string praca;
        public bool sila = false;

        public NPC(string jmeno, string praca, bool sila) : base(jmeno)
        {
            this.praca = praca;
            this.sila = sila;
        }

        public NPC() 
        {
           
        }


        enum Prace
        {
            obchodnik, nepritel, obyvatel
        }
        public string Praca(string praca)
        {
            Prace work = new Prace();
            switch (praca)
            {
                case "velkynos": work = Prace.obchodnik; break;
                case "usoplesk": work = Prace.nepritel; break;
                case "makeup": work = Prace.obyvatel; break;
            }

            if (work.ToString() == praca || work.ToString() == praca || work.ToString() == praca)
            {
                return praca;

            }
            return "kopanecdohlavy";
        }


        public override sealed void ZmenaPozice()
        {
            poziceX = 50;
            poziceY = 50;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\nPrace: {0}\nBoss: {1}\n", praca, sila == true ? "Ano" : "Ne");
        }
    }
}
