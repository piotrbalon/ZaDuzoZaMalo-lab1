using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Gra g;

        private void labelod_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(textBoxMin.Text, out a))
            {
                textBoxMin.BackColor = Color.Red;
                return;
            }
            else
            {
                textBoxMin.BackColor = Color.LightGreen;
            }

            int b;
            if (!int.TryParse(textBoxMax.Text, out b))
            {
                textBoxMax.BackColor = Color.Red;
                return;
            }
            else
            {
                textBoxMax.BackColor = Color.LightGreen;
            }

            g = new Gra(a, b);
            textBoxMin.Enabled = false;
            textBoxMax.Enabled = false;
            textBoxMin.BackColor = Color.LightGreen;
            textBoxMax.BackColor = Color.LightGreen;
            buttonLosowanie.Visible = false;
            groupboxSprawdz.Visible = true;
            messageboxPoddanie.Visible = true;
            LiczbaRuchow.Visible = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NowaGra_Click(object sender, EventArgs e)
        {
            groupboxLosuj.Visible = true;
            nowaGra.Enabled = false;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            LiczbaRuchow.Text = Convert.ToString(g.LicznikRuchow);
            Liczba.Visible = true;

            int x;
            if (!int.TryParse(textBoxliczba.Text, out x))
            {
                textBoxliczba.BackColor = Color.Red;
                return;
            }
            else
            {
                textBoxliczba.BackColor = Color.LightGreen;
            if (Convert.ToString(g.Ocena(x)) == "ZaDuzo")
                    Liczba.Text = "Podana liczba jest zbyt duża";
                else if (Convert.ToString(g.Ocena(x)) == "ZaMalo")
                    Liczba.Text = "Podana liczba jest zbyt mała";
                else
                {
                    string title = ("Koniec gry");
                    string body = ("Gratulacje!");


                    MessageBoxButtons YesOrNo = MessageBoxButtons.YesNo;
                    DialogResult Wynik = MessageBox.Show(body, title, YesOrNo);

                    if (Wynik == DialogResult.No)
                    {
                        Close();
                    }
                    if (Wynik == DialogResult.Cancel)
                    {
                        Close();
                    }
                    else
                    {
                        nowaGra.Enabled = true;
                        textBoxMin.Clear();
                        textBoxMax.Clear();
                        textBoxliczba.Clear();
                        textBoxMin.Enabled = true;
                        textBoxMax.Enabled = true;
                        groupboxLosuj.Visible = false;
                        buttonLosowanie.Visible = true;
                        groupboxSprawdz.Visible = false;
                    }
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupboxLosuj_Enter(object sender, EventArgs e)
        {

        }

        private void Liczba_Click(object sender, EventArgs e)
        {

        }

        private void LabelRuch_Click(object sender, EventArgs e)
        {

        }

        private void LiczbaRuchow_Click(object sender, EventArgs e)
        {

        }

        private void PoddanieGry_Click(object sender, EventArgs e)
        {
            string title = "Poddanie";
            string body = "Czy chcesz się poddać?";

            MessageBoxButtons YesNoCancel = MessageBoxButtons.YesNoCancel;
            DialogResult Wynik = MessageBox.Show(body, title, YesNoCancel);

            if (Wynik == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                nowaGra.Enabled = true;
                textBoxMin.Clear();
                textBoxMax.Clear();
                textBoxliczba.Clear();
                textBoxMin.Enabled = true;
                textBoxMax.Enabled = true;
                groupboxLosuj.Visible = false;
                buttonLosowanie.Visible = true;
                groupboxSprawdz.Visible = false;
            }

        }
    }
}
