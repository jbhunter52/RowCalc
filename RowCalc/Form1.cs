using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalc_calhr_Click(object sender, EventArgs e)
        {

        }

        private double GetSecFromCalHr(double calhr)
        {
            return -2.4424e-8 * Math.Pow(calhr, 3) + 1.3114e-4* Math.Pow(calhr, 2) - 2.5303e-1 * calhr + 266.14;
        }
        public double GetCalHrFromSec(double sec)
        {
            return -4.49e-3 * Math.Pow(sec, 3) + 1.96 * Math.Pow(sec, 2) - 2.94e2 * sec + 15800;
        }

        private void ButtonCalc_500m_Click(object sender, EventArgs e)
        {
            double totsec = int.Parse(TextBox500mmin.Text) * 60 + double.Parse(TextBox500msec.Text);
            double calhr = GetCalHrFromSec(totsec);
            TextBoxCalhr.Text = calhr.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBoxCalhr.Focused)
                {
                    if (TextBoxCalhr.Text != "")
                    {
                        double calhr = double.Parse(TextBoxCalhr.Text);
                        double totsec = GetSecFromCalHr(calhr);
                        int min = (int)Math.Floor(totsec / 60);
                        double sec = totsec - min * 60;
                        TextBoxCalMin.Text = (calhr / 60).ToString("0.#");
                        TextBox500mmin.Text = min.ToString();
                        TextBox500msec.Text = sec.ToString("0.#");
                    }
                }

                if (TextBoxCalMin.Focused)
                {
                    if (TextBoxCalMin.Text != "")
                    {
                        double calmin = double.Parse(TextBoxCalMin.Text);
                        double totsec = GetSecFromCalHr(calmin*60);
                        int min = (int)Math.Floor(totsec / 60);
                        double sec = totsec - min * 60;
                        TextBoxCalhr.Text = (calmin * 60).ToString("0.#");
                        TextBox500mmin.Text = min.ToString();
                        TextBox500msec.Text = sec.ToString("0.#");
                    }
                }
            }
        }

    }
}
