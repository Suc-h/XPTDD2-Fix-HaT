using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ukol
{
    public class HerniPostava
    {
        protected string jmeno;
        public int lvl = 1;
        protected int poziceX = 0;
        protected int poziceY = 0;

        public string Jmeno
        {
            get => jmeno;

            set
            {
                if (value.Length > 10)
                {
                    MessageBox.Show("„Příliš dlouhé jméno!“", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else jmeno = value;
            }
        }

       


        public HerniPostava(string jmeno)
        {
            this.Jmeno = jmeno;
        }

        public HerniPostava()
        {
            
        }

        
        public string metoda1(string jmeno)
        {
            Jmeno = jmeno;
            return Jmeno;
        }

        public int pozice(int spotG)
        {
            poziceY = spotG;
            return PoziceY;
        }

        public int pozice2(int spotA)
        {
            poziceX = spotA;
            return PoziceX;
        }

        public int PoziceX { get => poziceX; }
        public int PoziceY { get => poziceY; }

        

        public virtual void ZmenaPozice()
        {
            poziceX += 4;
            poziceY += 7;
        }

        public override string ToString()
        {
            return String.Format("Jmeno: {0}\nLevel: {1}\nX: {2}\nY: {3}\n", jmeno, lvl, PoziceX, PoziceY);
        }
    }
}

