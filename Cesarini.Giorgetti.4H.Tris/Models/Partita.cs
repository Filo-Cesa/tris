using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesarini.Giorgetti._4H.Tris
{
    class Partita
    {
        private Cella[,] campo = new Cella[3, 3];
        
        private string G;

        Cella libera = new Cella();

        public Partita()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    campo[i, j] = new Cella(i, j);
                }
            }
            G = "";
        }
        
        public int Vittoria()
        {
            int somma = 0;
            int vincitore = 0;

            //righe
            somma = 0;
            for(int i = 0; i < 3; i++)
            {
                somma = 0;
                for(int j=0; j < 3; j++)
                {
                    somma += campo[i, j].Occupa();
                }
                if (somma == 3)
                {
                    vincitore = 1;
                }
                else if (somma == 30)
                {
                    vincitore = 2;
                }
            }
            //colonne
            somma = 0;
            for (int i = 0; i < 3; i++)
            {
                somma = 0;
                for (int j = 0; j < 3; j++)
                {
                    somma += campo[j, i].Occupa();
                }
                if (somma == 3)
                {
                    vincitore = 1;
                }
                else if (somma == 30)
                {
                    vincitore = 2;
                }
            }
            //diagonale 1
            somma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        somma += campo[i, j].Occupa();
                    }
                }
                if (somma == 3)
                {
                    vincitore = 1;
                }
                else if (somma == 30)
                {
                    vincitore = 2;
                }
            }
            //diagonale 2
            somma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i==j+2 || i+2==j)
                    {
                        somma += campo[i, j].Occupa();
                    }
                    if(i==1 && j == 1)
                    {
                        somma += campo[i, j].Occupa();
                    }
                }
                if (somma == 3)
                {
                    vincitore = 1;
                }
                else if (somma == 30)
                {
                    vincitore = 2;
                }
            }


            return vincitore;
        }

        public string Mossa(int riga,int colonna,bool conta)
        {
            
                
                if (campo[riga, colonna].Occupa() == 0)
                {

                    if (conta)
                    {
                        G = "O";
                        campo[riga, colonna].Casella(G);
                    }
                    else
                    {
                        G = "X";
                        campo[riga, colonna].Casella(G);
                    }

                }
            
            
            return G;
        }
        
    }
}
