using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneUro.Depo;

namespace HastaneUro.Bilgi
{
    public partial class DoktorListe : Form
    {
        UrologyDataContext _db = new UrologyDataContext();
        Mesajlar _m = new Mesajlar();
        public bool Secim = false;
        int _secimId = -1;
        public DoktorListe()
        {
            InitializeComponent();
        }

        private void DoktorListe_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in _db.DrListesis select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.DrAdi;
                i++;
            }
        }
        void Sec()
        {
            try
            {
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                _secimId = -1;
            }
        }
        public string Doktorlar;
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            try
            {
                
                if (txtDoktor1.Text == "" && _secimId > 0)
                {
                    txtDoktor1.Text = _db.DrListesis.First(x => x.ID == _secimId).DrAdi;
                    Doktorlar = txtDoktor1.Text.Substring(0,2);
                }

                else if (txtDoktor2.Text == "" && _secimId > 0)
                {
                    txtDoktor2.Text = _db.DrListesis.First(x => x.ID == _secimId).DrAdi;
                    Doktorlar = txtDoktor1.Text + "-" + txtDoktor2.Text;
                }
                else if (txtDoktor3.Text == "" && _secimId > 0)
                {
                    txtDoktor3.Text = _db.DrListesis.First(x => x.ID == _secimId).DrAdi;
                    Doktorlar = txtDoktor1.Text + "-" + txtDoktor2.Text + "-" + txtDoktor3.Text;
                }
                else if (txtDoktor4.Text == "" && _secimId > 0)
                {
                    txtDoktor4.Text = _db.DrListesis.First(x => x.ID == _secimId).DrAdi;
                    Doktorlar = txtDoktor1.Text + "-" + txtDoktor2.Text + "-" + txtDoktor3.Text + "-" + txtDoktor4.Text;
                }
                else if (txtDoktor5.Text == "" && _secimId > 0)
                {
                    txtDoktor5.Text = _db.DrListesis.First(x => x.ID == _secimId).DrAdi;
                    Doktorlar = txtDoktor1.Text + "-" + txtDoktor2.Text + "-" + txtDoktor3.Text + "-" + txtDoktor4.Text + "-" + txtDoktor5.Text;
                }
                else if (txtDoktor6.Text == "" && _secimId > 0)
                {
                    txtDoktor6.Text = _db.DrListesis.First(x => x.ID == _secimId).DrAdi;
                    Doktorlar = txtDoktor1.Text + "-" + txtDoktor2.Text + "-" + txtDoktor3.Text + "-" + txtDoktor4.Text + "-" + txtDoktor5.Text + "-" + txtDoktor6.Text;
                }
            }
            catch (Exception er)
            {

                _m.Hata(er);
            }
        }
        void Aktar()
        {
            
            AnaSayfa.DoktorAdi = Doktorlar;
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
