using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesarini.Giorgetti._4H.Tris
{
    class Cella
    {
        private int Libera;
        private int Riga;
        private int Colonna;

        public Cella()
        {
            Libera = 0;
        }

        public Cella(int riga,int colonna)
        {
            Riga = riga;
            Colonna = colonna;
            Libera = 0;
        }

        public int Occupa()
        {
            return Libera;
        }

        public void Casella(string G)
        {
            if (G == "X")
            {
                Libera = 1;
            }
            else if(G=="O")
            {
                Libera = 10;
            }
            
            
        }

        
    }
}
