using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOProjLAB05
{
    public partial class MainForm : Form
    {

        private bool novaIgra = true;
        private int ukupnoVreme;

        FormIzmeniMapu formIzmeniMapu = new FormIzmeniMapu();
        public static MainForm instanca;
        public int n;
        public int bombe;
        public MainForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            ukupnoVreme = 0;
            StampajMapu(n, bombe);

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            instanca = this;
        }
        public void StampajMapu(int n, int bombe)
        {
            Mapa mapa = new Mapa(n, n, bombe);

            int velicinaCelije = 30;
            panelMapa.Controls.Clear();

            for (int i = 0; i < mapa.x; i++)
            {
                for (int j = 0; j < mapa.y; j++)
                {
                    PictureBox element = new PictureBox();
                    element.BackColor = Color.White;
                    element.Width = velicinaCelije;
                    element.Height = velicinaCelije;
                    element.Left = i * velicinaCelije;
                    element.Top = j * velicinaCelije;
                    element.BorderStyle = BorderStyle.FixedSingle;
                    element.Image = imageList.Images[1];
                    element.SizeMode = PictureBoxSizeMode.StretchImage;



                    element.Click += new EventHandler(Element_Click);

                    if (mapa.mapa[i, j].JelBomba)
                    {
                        

                        element.Tag = "Bomba";
                    }
                        
                    else
                    {
                        element.Text = mapa.mapa[i, j].brojSusednihBombi.ToString();
                        if (element.Text == "0")
                            element.Tag = "0";
                        else if (element.Text == "1")
                            element.Tag = "1";
                        else if (element.Text == "2")
                            element.Tag = "2";
                        else if (element.Text == "3")
                            element.Tag = "3";
                        else if (element.Text == "4")
                            element.Tag = "4";
                        else
                            element.Tag = element.Text;

                    }
                    
                    panelMapa.Controls.Add(element);
                }
            }

            this.Width = mapa.x * 35;
            this.Height = mapa.y * 45 + lbTimer.Height + 10;
            lbTimer.Left = (this.ClientSize.Width - lbTimer.Width) / 2;
        }

        private void Element_Click(object sender, EventArgs e)
        {
            if(novaIgra == false)
            {
                PictureBox klik = (PictureBox)sender;
                if (klik.Tag.ToString() == "Bomba")
                {
                    timer.Stop();
                    klik.Image = imageList.Images[0];
                    novaIgra = true;
                    MessageBox.Show("GAME OVER!");

                    foreach (Control control in panelMapa.Controls)
                        if (control is PictureBox pictureBox && pictureBox.Tag.ToString() == "Bomba")
                            pictureBox.Image = imageList.Images[0];
                }
                else
                {
                    if (klik.Text == "0")
                        klik.Image = null;
                    else if (klik.Text == "1")
                        klik.Image = imageList.Images[3];
                    else if (klik.Text == "2")
                        klik.Image = imageList.Images[5];
                    else if (klik.Text == "3")
                        klik.Image = imageList.Images[4];
                    else if (klik.Text == "4")
                        klik.Image = imageList.Images[2];
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

            public Mapa()
            { }
            public Mapa(int x, int y, int brojMina)
            {
                this.x = Math.Max(x, 9);
                this.y = Math.Max(y, 9);
                this.brojBombi = Math.Max(brojMina, 10);
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
                while (postavljeneBombe < brojBombi)
                {
                    int row = r.Next(x);
                    int column = r.Next(y);
                    if (!mapa[row, column].JelBomba)
                    {
                        mapa[row, column].JelBomba = true;
                        postavljeneBombe++;
                    }
                }
            }
            private void IzracunajSusedneMine()
            {
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                        if (!mapa[i, j].JelBomba)
                        {
                            int susedneBombe = IzbrojSusedneMine(i, j);
                            mapa[i, j].brojSusednihBombi = susedneBombe;
                        }
            }
            private int IzbrojSusedneMine(int row, int column)
            {
                int count = 0;
                for (int i = -1; i <= 1; i++)
                    for (int j = -1; j <= 1; j++)
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(ukupnoVreme);
            lbTimer.Text = timeSpan.ToString("hh\\:mm\\:ss");
            ukupnoVreme++;
        }


        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (novaIgra)
            {
                StampajMapu(n, bombe);
                timer.Start();

                novaIgra = false;
            }
        }

        private void zavrsiIgruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novaIgra = true;
            int savedVreme = ukupnoVreme;
            ukupnoVreme = 0;
            timer.Stop();
            lbTimer.Text = "00:00:00";

        }

        private void izmeniMapuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lbTimer.Text = "00:00:00";
            if (formIzmeniMapu.IsDisposed)
            {
                formIzmeniMapu = new FormIzmeniMapu();
            }
            formIzmeniMapu.Show();
        }
        public class Konfiguracija
        {
            public Mapa Mapa { get; set; }
            public int N { get; set; }
            public int Bombe { get; set; }
        }

    }
}