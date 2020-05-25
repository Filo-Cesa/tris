using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cesarini.Giorgetti._4H.Tris
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Partita celle = new Partita();

        int turno = 0;
        bool A = true;
        int VG1 = 0;
        int VG2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            Cella reset = new Cella();
            celle = new Partita();
            reset = new Cella();

            btn0.Content = " ";
            btn1.Content = " ";
            btn2.Content = " ";
            btn3.Content = " ";
            btn4.Content = " ";
            btn5.Content = " ";
            btn6.Content = " ";
            btn7.Content = " ";
            btn8.Content = " ";
        }

        public bool conta() 
        {
            bool C = true;
            turno++;
            if((turno % 2) == 0)
            {
                C = true;
                lbl.Content = "Tocca al giocatore X";
            }
            else
            {
                C = false;
                lbl.Content = "Tocca al giocatore O";
            }
            
            return C;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn0.Content = celle.Mossa(0, 0, A);
            
            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn1.Content = celle.Mossa(0, 1,A);

            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn2.Content = celle.Mossa(0, 2,A);

            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn3.Content = celle.Mossa(1, 0,A);

            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn4.Content = celle.Mossa(1, 1,A);

            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn5.Content = celle.Mossa(1, 2,A);

            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn6.Content = celle.Mossa(2, 0,A);

            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn7.Content = celle.Mossa(2, 1,A);

            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            A = conta();
            btn8.Content = celle.Mossa(2, 2,A);

            if (celle.Vittoria() == 1)
            {
                MessageBox.Show("Hai vinto giocatore X");
                Reset();
                VG1++;
                g1.Content = "G X: " + VG1;
            }
            else if (celle.Vittoria() == 2)
            {
                MessageBox.Show("Hai vinto giocatore O");
                Reset();
                VG2++;
                g2.Content = "G O: " + VG2;
            }
        }

        private void resetta_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
    }
}
