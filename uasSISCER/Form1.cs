using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uasSISCER
{
    public partial class Form1 : Form
    {
        double miuPR, miuPT, miuSR, miuST;
        double z1, z2, z3, z4, aOne, aTwo, aThree, aFour;

        double pT, pR, pN;
        double sT, sR, sN;

        private void btClear_Click(object sender, EventArgs e)
        {
            boxHasil.Text = null;
            boxJual.Text = null;
            boxSedia.Text = null;
        }

        public Form1()
        {
            InitializeComponent();
            pT = 20;
            pR = 5;
            sT = 48;
            sR = 5;

            boxHasil.Enabled = false;
            dPT.Text = pT.ToString();
            dPR.Text = pR.ToString();
            dST.Text = sT.ToString();
            dSR.Text = sR.ToString();
        }

        private void btHitung_Click(object sender, EventArgs e)
        {
            if (boxJual.Text == "" && boxSedia.Text == "")
            {
                MessageBox.Show("Harap Isi Semua Data!", "Peringatan");
            }
            else
            {
                fuzzyfikasi();
                inferensi();
                defuzzyfikasi();
            }
        }

        public void fuzzyfikasi()
        {

            //Penjualan
            pN = Convert.ToDouble(boxJual.Text);

            miuPR = (pT - pN) / (pT - pR);

            miuPT = (pN - pR) / (pT - pR);

            //Persediaan
            sN = Convert.ToDouble(boxSedia.Text);

            miuSR = (sT - sN) / (sT - sR);

            miuST = (sN - sR) / (sT - sR);
        }

        public void inferensi()
        {
            double prT = 120;
            double prR = 12;
            //R1
            double[] r1 = { miuPR, miuSR };
            aOne = r1.Min();
            z1 = prT - (aOne * (prT - prR));

            //R2
            double[] r2 = { miuPR, miuST };
            aTwo = r2.Min();
            z2 = prT - (aTwo * (prT - prR));

            //R3
            double[] r3 = { miuPT, miuSR };
            aThree = r3.Min();
            z3 = prR + (aThree * (prT - prR));

            //R4
            double[] r4 = { miuPT, miuST };
            aFour = r4.Min();
            z4 = prR + (aFour * (prT - prR));

        }

        public void defuzzyfikasi()
        {
            double zFinal = ((aOne * z1) + (aTwo * z2) + (aThree * z3) + (aFour * z4)) / (aOne + aTwo + aThree + aFour);
            int hslPre = (int)zFinal;
            boxHasil.Text = hslPre.ToString();
        }
    }
}
