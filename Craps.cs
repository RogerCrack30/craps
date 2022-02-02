using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Craps
    {

        private int dado1;
        private int dado2;


        Craps ( int tirada1, int tirada2)
        {
            this.dado1 = tirada1;
            this.dado2 = tirada2;
        }

        public int tirada()
        {
            int tirada = dado1 + dado2;

            return tirada;
            
        }

        public int getTirada1()
        {
            return dado1;
        }
        public void setTirada1(int tirada1)
        {
            this.dado1 = tirada1;
        }
        public int getTirada2()
        {
            return dado2;
        }
        public void setTirada2(int tirada2)
        {
            this.dado2 = tirada2;
        }



    }
}
