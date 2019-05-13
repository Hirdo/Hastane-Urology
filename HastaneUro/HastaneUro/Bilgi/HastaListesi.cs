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

    public partial class HastaListesi : Form
    {
        UrologyDataContext _db = new UrologyDataContext();
        public bool Secim = false;
        public int HastaId = -1;
        public HastaListesi()
        {
            InitializeComponent();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.HastaBilgis
                       where s.Ad.Contains(txtHastaAdi.Text)
                       where s.Protokol.Contains(txtProNo.Text)
                       select s);
                       //select new
                       //{
                       //    p = s.HastaNo,
                       //    n = s.Ad,
                       //    m = s.Soyad,
                       //    r = s.Protokol,
                       //    d = s.OpTarih
                       //}).Distinct().OrderByDescending(x => x.d).OrderBy(y => y.n);
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.Protokol;
                Liste.Rows[i].Cells[2].Value = k.Ad+" "+ k.Soyad;
                Liste.Rows[i].Cells[3].Value = k.OpTarih;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HastaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Sec()
        {
            try
            {
                HastaId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                HastaId = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && HastaId > 0)
            {
                AnaSayfa.Aktarma = HastaId;
                Close();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
