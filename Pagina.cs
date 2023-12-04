using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tegon.elettra._4i.stampante.models
{
    public class Pagina
    {


        //4 serbatoi di colore: CMYB 
        //private int _c;
        public int C;
        public int M;
        public int Y;
        public int B;

        //un costruttore che accetta colori specifici al massimo di valore 3
        public Pagina(int val, string color)
        {
            switch (color.ToLower())
            {
                case "cyano":
                    if (val > 3)
                        C = 3;
                    else
                    {
                        C = val;
                        break;
                    }
                    break;
                case "yellow":
                    if (val > 3)
                        Y = 3;
                    else
                    {
                        Y = val;
                        break;
                    }
                    break;
                case "magenta":
                    if (val > 3)
                        M = 3;
                    else
                    {
                        M = val;
                        break;
                    }
                    break;
                case "black":
                    if (val > 3)
                        B = 3;
                    else
                    {
                        B = val;
                        break;
                    }
                    break;
            }

        }

        //un costruttore che crea una Pagina con colori random
        public Pagina()
        {
            Random rnd = new Random();
            int x = rnd.Next(100);
            C = rnd.Next(100);
            M = rnd.Next(100);
            Y = rnd.Next(100);
            B = rnd.Next(100);
        }
    }

}
