using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGS_Hesaplama
{
    public partial class FrmYGS : Form
    {
        public FrmYGS()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            Double turkce, sosyal, matematik, fen;
            Double ygs1, ygs2, ygs3, ygs4, ygs5, ygs6;
            if (TxtTurkce.Text != "")
                turkce = Convert.ToDouble(TxtTurkce.Text);
            else
                turkce = 0.0;
            if (TxtSosyal.Text != "")
                sosyal = Convert.ToDouble(TxtSosyal.Text);
            else
                sosyal = 0.0;
            if (TxtMatematik.Text != "")
                matematik = Convert.ToDouble(TxtMatematik.Text);
            else
                matematik = 0.0;
            if (TxtFen.Text != "")
                fen = Convert.ToDouble(TxtFen.Text);
            else
                fen = 0.0;
            if (turkce > 40 | matematik > 40 | sosyal > 40 | fen > 40)
                MessageBox.Show("Lütfen 40' ın üzerinde net sayısı girmeyiniz");
            else
            {
                ygs1 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 3.998) + (fen * 2.999);
                LblYgs1.Text = ygs1.ToString();
                ygs2 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 2.999) + (fen * 3.998);
                LblYgs2.Text = ygs2.ToString();
                ygs3 = 100.160 + (turkce * 3.998) + (sosyal * 2.999) + (matematik * 1.999) + (fen * 1);
                LblYgs3.Text = ygs3.ToString();
                ygs4 = 100.160 + (turkce * 2.999) + (sosyal * 3.998) + (matematik * 1.999) + (fen * 1);
                LblYgs4.Text = ygs4.ToString();
                ygs5 = 100.120 + (turkce * 3.699) + (sosyal * 1.999) + (matematik * 3.299) + (fen * 1);
                LblYgs5.Text = ygs5.ToString();
                ygs6 = 100.120 + (turkce * 3.299) + (sosyal * 1) + (matematik * 3.699) + (fen * 1.999);
                LblYgs6.Text = ygs6.ToString();
            }
        }

        private void FrmYGS_Load(object sender, EventArgs e)
        {

        }
    }
}
