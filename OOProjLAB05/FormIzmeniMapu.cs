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
    public partial class FormIzmeniMapu : Form
    {
        public static FormIzmeniMapu instanca;
        public FormIzmeniMapu()
        {
            InitializeComponent();
            instanca = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN.Text);
            int bombe = int.Parse(textBoxBombe.Text);
            MainForm.instanca.n = int.Parse(textBoxN.Text);
            MainForm.instanca.bombe = int.Parse(textBoxBombe.Text);
            MainForm.instanca.StampajMapu(n, bombe);
            this.Close();
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

            string tekst = textBoxN.Text;
            if (tekst.Length == 0) return;

            char lastChar = tekst[tekst.Length - 1];

            if (!char.IsDigit(lastChar))
            {
                tekst = tekst.Substring(0, tekst.Length - 1);
                textBoxN.Text = tekst;
                textBoxN.SelectionStart = tekst.Length;

            }
  
        }

        private void textBoxBombe_TextChanged(object sender, EventArgs e)
        {
            string tekst = textBoxBombe.Text;
            if (tekst.Length == 0) return;

            char lastChar = tekst[tekst.Length - 1];

            if (!char.IsDigit(lastChar))
            {
                tekst = tekst.Substring(0, tekst.Length - 1);
                textBoxBombe.Text = tekst;
                textBoxBombe.SelectionStart = tekst.Length;

            }
        }
    }
}
