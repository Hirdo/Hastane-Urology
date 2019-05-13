using HastaneUro.Depo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneUro.Bilgi
{
    public partial class OperasyonTurleri : Form
    {
        UrologyDataContext _db = new UrologyDataContext();
        Mesajlar _m = new Mesajlar();
        public bool Secim = false;
        int _opsecim = -1;
        public OperasyonTurleri()
        {
            InitializeComponent();
        }

        private void OperasyonTurleri_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in _db.OperasyonTurus select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.OpTuru;
                i++;
            }
        }
        void Sec()
        {
            try
            {
                _opsecim = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                _opsecim = -1;
            }
        }
        public string Operasyon;
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();


            if (txtOp1.Text == "" && _opsecim > 0)
            {
                txtOp1.Text = _db.OperasyonTurus.First(x => x.ID == _opsecim).OpTuru;
                Operasyon = txtOp1.Text;
            }
            else if (txtOp2.Text == "" && _opsecim > 0)
            {
                txtOp2.Text = _db.OperasyonTurus.First(x => x.ID == _opsecim).OpTuru;
                Operasyon = txtOp1.Text + "+" + txtOp2.Text;
            }
            else if (txtOp3.Text == "" && _opsecim > 0)
            {
                txtOp3.Text = _db.OperasyonTurus.First(x => x.ID == _opsecim).OpTuru;
                Operasyon = txtOp1.Text + "+" + txtOp2.Text + "+" + txtOp3.Text;
            }
            else if (txtOp4.Text == "" && _opsecim > 0)
            {
                txtOp4.Text = _db.OperasyonTurus.First(x => x.ID == _opsecim).OpTuru;
                Operasyon = txtOp1.Text + "+" + txtOp2.Text + "+" + txtOp3.Text + "+" + txtOp4.Text;
            }

           
        }
        void Aktar()
        {

            AnaSayfa.OpAdi = Operasyon;
            Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAktarma_Click(object sender, EventArgs e)
        {
            Aktar();
        }
    }
}
