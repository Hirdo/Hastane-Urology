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
    public partial class Sorgulama : Form
    {
        UrologyDataContext _db = new UrologyDataContext();
        public int kanama;
        public int boyut;
        public Sorgulama()
        {
            InitializeComponent();
        }

        private void Sorgulama_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Listele()
        
        {
            if(txtKanama.Text!="")
            {
                kanama = int.Parse(txtKanama.Text);
            }
            else
            {
                kanama = -1;
            }
            if (txtTumor.Text != "")
            {
                boyut = int.Parse(txtTumor.Text);
            }
            else
            {
                boyut = -1;
            }
            
                Liste.Rows.Clear();
                int i = 0;
                var srg = (from s in _db.HastaBilgis where s.OperatifOzs.First().Kanama >= kanama
                           where s.DemografikOzs.First().Boyut >= boyut
                           where s.PatolojikVeris.First().Patoloji.Contains(txtPato.Text)
                           where s.OperatifOzs.First().PksAcıklama.Contains(txtPks.Text)
                           select s);
                foreach (var k in srg)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.HastaNo;
                    Liste.Rows[i].Cells[1].Value = k.Ad + " " + k.Soyad;
                    Liste.Rows[i].Cells[2].Value = k.DemografikOzs.First(x => x.HastaID == k.ID).Boyut;
                    Liste.Rows[i].Cells[3].Value = k.OperatifOzs.First(x => x.HastaID == k.ID).Kanama;
                    Liste.Rows[i].Cells[4].Value = k.OpTarih;
                    Liste.Rows[i].Cells[5].Value = k.PatolojikVeris.First(x => x.HastaID == k.ID).Patoloji;
                    Liste.Rows[i].Cells[6].Value = k.OperatifOzs.First(x => x.HastaID == k.ID).PksAcıklama;
                    i++;
                }
                

            #region Uzun Sorgu
            //else if(txtKanama.Text!="")
            //{
            //    Liste.Rows.Clear();
            //    int i = 0; 
            //    var srg = (from s in _db.HastaBilgis where s.OperatifOzs.First().Kanama>=int.Parse(txtKanama.Text)   select s);
            //    foreach (var k in srg)
            //    {
            //        Liste.Rows.Add();
            //        Liste.Rows[i].Cells[0].Value = k.HastaNo;
            //        Liste.Rows[i].Cells[1].Value = k.Ad + " " + k.Soyad;
            //        Liste.Rows[i].Cells[2].Value = k.DemografikOzs.First(x => x.HastaID == k.ID).Boyut;
            //        Liste.Rows[i].Cells[3].Value = k.OperatifOzs.First(x => x.HastaID == k.ID).Kanama;
            //        Liste.Rows[i].Cells[4].Value = k.OpTarih;
            //        Liste.Rows[i].Cells[5].Value = k.PatolojikVeris.First(x => x.HastaID == k.ID).Patoloji;
            //        Liste.Rows[i].Cells[6].Value = k.OperatifOzs.First(x => x.HastaID == k.ID).PksAcıklama;
            //        i++;
            //    }
            //}
            //else if (txtTumor.Text != "")
            //{
            //    Liste.Rows.Clear();
            //    int i = 0;
            //    var srg = (from s in _db.HastaBilgis where s.DemografikOzs.First().Boyut >= int.Parse(txtTumor.Text) select s);
            //    foreach (var k in srg)
            //    {
            //        Liste.Rows.Add();
            //        Liste.Rows[i].Cells[0].Value = k.HastaNo;
            //        Liste.Rows[i].Cells[1].Value = k.Ad + " " + k.Soyad;
            //        Liste.Rows[i].Cells[2].Value = k.DemografikOzs.First(x => x.HastaID == k.ID).Boyut;
            //        Liste.Rows[i].Cells[3].Value = k.OperatifOzs.First(x => x.HastaID == k.ID).Kanama;
            //        Liste.Rows[i].Cells[4].Value = k.OpTarih;
            //        Liste.Rows[i].Cells[5].Value = k.PatolojikVeris.First(x => x.HastaID == k.ID).Patoloji;
            //        Liste.Rows[i].Cells[6].Value = k.OperatifOzs.First(x => x.HastaID == k.ID).PksAcıklama;
            //        i++;
            //    }
            //}
            //else if(txtTumor.Text!="" && txtKanama.Text != "")
            //{
            //    Liste.Rows.Clear();
            //    int i = 0;
            //    var srg = (from s in _db.HastaBilgis where s.DemografikOzs.First().Boyut >= int.Parse(txtTumor.Text) where s.OperatifOzs.First().Kanama >=int.Parse(txtKanama.Text) select s);
            //    foreach (var k in srg)
            //    {
            //        Liste.Rows.Add();
            //        Liste.Rows[i].Cells[0].Value = k.HastaNo;
            //        Liste.Rows[i].Cells[1].Value = k.Ad + " " + k.Soyad;
            //        Liste.Rows[i].Cells[2].Value = k.DemografikOzs.First(x => x.HastaID == k.ID).Boyut;
            //        Liste.Rows[i].Cells[3].Value = k.OperatifOzs.First(x => x.HastaID == k.ID).Kanama;
            //        Liste.Rows[i].Cells[4].Value = k.OpTarih;
            //        Liste.Rows[i].Cells[5].Value = k.PatolojikVeris.First(x => x.HastaID == k.ID).Patoloji;
            //        Liste.Rows[i].Cells[6].Value = k.OperatifOzs.First(x => x.HastaID == k.ID).PksAcıklama;
            //        i++;
            //    }
            //} 
            #endregion
        }
       
      

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtKanama_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtTumor_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtPato_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtPks_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
