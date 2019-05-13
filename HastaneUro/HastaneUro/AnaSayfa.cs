using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneUro
{
    public partial class AnaSayfa : Form
    {
        public static int Aktarma;
        public static string DoktorAdi;
        public static string OpAdi;
        Depo.Formlar _f = new Depo.Formlar();
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            grpLeft.BackColor = Color.Teal;
            grpLeft.ForeColor = Color.White;
            grpLeft.Text = "Hasta Bilgi İşlemleri";
            pnlLeft1.Visible = true;
        }



        private void btnBolum2_Click_1(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            pnlLeft2.Visible = true;
            grpLeft.Text = "Bilgi Giriş İşlemleri";
            grpLeft.BackColor = Color.Olive;
            grpLeft.ForeColor = Color.White;
        }

        private void btnBolum1_Click_1(object sender, EventArgs e)
        {
            pnlLeft1.Visible = true;
            pnlLeft2.Visible = false;
            grpLeft.Text = "Hasta Bilgi İşlemleri";
            grpLeft.BackColor = Color.Teal;
            grpLeft.ForeColor = Color.White;

        }

        private void btnHastaBilgi_Click(object sender, EventArgs e)
        {
            _f.Hasta();
        }

        private void btnDrListe_Click(object sender, EventArgs e)
        {
            _f.DrListe();
        }

        private void btnHastaListe_Click(object sender, EventArgs e)
        {
            _f.HastaList();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            _f.Sorgu();
        }
    }
}
