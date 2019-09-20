using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenrechnerBenjamin
{
    public partial class Form1 : Form
    {
        string rechenoperator;
        public Form1()
        {
            InitializeComponent();
        }

        private void TbxZahl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            rechenoperator = "+";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            rechenoperator = "-";
        }

        private void BtnGleich_Click(object sender, EventArgs e)
        {
            if (rechenoperator == "+")
            {
                int ergebnis = Convert.ToInt32(tbxZahl1.Text) + Convert.ToInt32(tbxZahl2.Text);
                tbxErgebnis.Text = ergebnis.ToString();

            }
            else if(rechenoperator=="-")
            {
                int ergebnis = Convert.ToInt32(tbxZahl1.Text) - Convert.ToInt32(tbxZahl2.Text);
                tbxErgebnis.Text = ergebnis.ToString();
            }
            else if(rechenoperator=="*")
            {
                int ergebnis = Convert.ToInt32(tbxZahl1.Text) * Convert.ToInt32(tbxZahl2.Text);
                tbxErgebnis.Text = ergebnis.ToString();
            }
            else if (rechenoperator=="/")
            {
                int ergebnis = Convert.ToInt32(tbxZahl1.Text) / Convert.ToInt32(tbxZahl2.Text);
                tbxErgebnis.Text = ergebnis.ToString();
            }
            else
            {
                int ergebnis = Convert.ToInt32(tbxZahl1.Text) * Convert.ToInt32(tbxZahl1.Text);
                tbxErgebnis.Text = ergebnis.ToString();
                tbxZahl2.Text="---";
                tbxZahl2.TextAlign = HorizontalAlignment.Center;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
    }

        private void BtnMultiplikation_Click(object sender, EventArgs e)
        {
            rechenoperator = "*";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            rechenoperator = "/";
        }

        private void BtnQuadrat_Click(object sender, EventArgs e)
        {
            rechenoperator = "x²";
        }
    }
    }

