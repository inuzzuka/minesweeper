using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOProjLAB05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StampajMapu();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void StampajMapu()
        {
            Mapa mapa = new Mapa(9, 9, 10);
            int velicinaCelije = 30;
            panelMapa.Controls.Clear();

            for (int i = 0; i < mapa.x; i++)
            {
                for (int j = 0; j < mapa.y; j++)
                {
                    Control element = new Button();
                    element.Width = velicinaCelije;
                    element.Height = velicinaCelije;
                    element.Left = i * velicinaCelije;
                    element.Top = j * velicinaCelije;

                    if (mapa.mapa[i, j].JelBomba)
                        element.BackColor = Color.Red;
                    else
                    {
                        element.BackColor = Color.Gray;
                        element.Text = mapa.mapa[i, j].brojSusednihBombi.ToString();
                    }

                    panelMapa.Controls.Add(element);
                }
            }
        }
        public class Polja
        {
            public bool JelBomba { get; set; }
            public bool jelOtvoreno { get; set; }
            public int brojSusednihBombi { get; set; }

            public Polja()
            {
                JelBomba = false;
                jelOtvoreno = false;
                brojSusednihBombi = 0;
            }
        }
        public class Mapa
        {
            public Polja[,] mapa;
            public int x { get; private set; }
            public int y { get; private set; }
            private int brojBombi;

            public Mapa(int x, int y, int brojMina)
            {
                this.x = Math.Max(x, 9);
                this.y = Math.Max(y, 9);
                this.brojBombi = Math.Max(10, (this.x * this.y)/10);
                mapa = new Polja[this.x, this.y];

                for (int i = 0; i < this.x; i++)
                    for (int j = 0; j < this.y; j++)
                        mapa[i, j] = new Polja();
                PostaviMine();
                IzracunajSusedneMine();

            }
            private void PostaviMine()
            {
                Random r = new Random();
                int postavljeneBombe = 0;
                while(postavljeneBombe < brojBombi)
                {
                    int row = r.Next(x);
                    int column = r.Next(y);
                    if(!mapa[row, column].JelBomba)
                    {
                        mapa[row, column].JelBomba = true;
                        postavljeneBombe++;
                    }
                }
            }
            private void IzracunajSusedneMine()
            {
                for(int i = 0; i < x; i++)
                    for(int j = 0; j < y; j++)
                        if(!mapa[i, j].JelBomba)
                        {
                            int susedneBombe = IzbrojSusedneMine(i, j);
                            mapa[i, j].brojSusednihBombi = susedneBombe;
                        }
            }
            private int IzbrojSusedneMine(int row, int column)
            {
                int count = 0;
                for(int i = -1; i<= 1; i++)
                    for(int j = -1; j<= 1; j++)
                    {
                        int susedanRow = row + i;
                        int susedanColumn = column + j;
                        if (susedanRow >= 0 && susedanRow < x && susedanColumn >= 0 && susedanColumn < y)
                            if (mapa[susedanRow, susedanColumn].JelBomba)
                                count++;
                    }
                return count;
            }
        }
        

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
