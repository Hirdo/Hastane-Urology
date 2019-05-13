using HastaneUro.Depo;
using HastaneUro.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneUro.Bilgi
{

    public partial class HastaBilgi : Form
    {
        UrologyDataContext _db = new UrologyDataContext();
        UrologyDataContext _gb = new UrologyDataContext();

        Formlar _f = new Formlar();
        Numaralar _n = new Numaralar();
        Mesajlar _m = new Mesajlar();
        public int _hastaid = -1;

        bool edit = false;
        public HastaBilgi()
        {
            InitializeComponent();
        }
        void Combo()
        {
            if (txtKilo.Text != "" && txtBoy.Text != "")
            {
                txtBMI.Text =Math.Round((double.Parse(txtKilo.Text) / (double.Parse(txtBoy.Text) * double.Parse(txtBoy.Text) / 10000))).ToString();
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HastaBilgi_Load(object sender, EventArgs e)
        {
            Temizle();
            
        }
        void YeniKaydet()
        {
            try
            {
                Depo.HastaBilgi has = new Depo.HastaBilgi();
                has.HastaNo = int.Parse(txtHastaNo.Text);
                has.Ad = txtHastaAdi.Text;
                has.Soyad = txtHastaSoyad.Text;
                has.Protokol = txtProtNo.Text;
                has.OpTarih = DateTime.Parse(dtpOpTarih.Text);
                has.OpTuru = txtOpTuru.Text;
                has.Takip = txtTakipAyi.Text != "" ? int.Parse(txtTakipAyi.Text) : -1;
                has.Anah = txtAnah.Text != "" ? int.Parse(txtAnah.Text) : -1;
                _db.HastaBilgis.InsertOnSubmit(has);
                _db.SubmitChanges();



                DemografikOz dem = new DemografikOz();
                dem.HastaID = has.ID;
                dem.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : -1;
                dem.Boy = txtBoy.Text != "" ? int.Parse(txtBoy.Text) : -1;
                dem.Kilo = txtKilo.Text != "" ? decimal.Parse(txtKilo.Text) : -1;
                dem.BMI =txtBMI.Text!="" ? int.Parse(txtBMI.Text):-1;
                dem.Asa = cbAsa.Text != "" ? int.Parse(cbAsa.Text) : -1;
                dem.Dr = txtDr.Text;
                dem.Cins = cbCins.Text;
                dem.Taraf = cbTaraf.Text;
                dem.Lokalizasyon = txtLokal.Text;
                dem.Boyut = txtBoyut.Text!="" ? int.Parse(txtBoyut.Text):-1;
                dem.KoMorbidite = txtKoMor.Text;




                OperatifOz ope = new OperatifOz();
                ope.HastaID = has.ID;
                ope.PksAcıklama = cbPksAcik.Text;
                ope.Sik = cbSik.Text;
                ope.CoOperasyon = txtCoOp.Text;
                ope.Iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text) : -1;
                ope.PortSayisi = txtPortSayi.Text != "" ? int.Parse(txtPortSayi.Text) : -1;
                ope.YardımYnt = txtYardımY.Text;
                ope.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : -1;
                ope.Dren = txtDren.Text;
                ope.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text) : -1;
                ope.Piyes = txtPiyes.Text;



                PosOperatifOz poso = new PosOperatifOz();
                poso.HastaID = has.ID;
                poso.PeropVeErkenKomp = txtPropErKomp.Text;
                poso.Dren = txtDrenPosOp.Text;
                poso.PostopAnaliz = txtPostopA.Text;
                poso.Sonda = txtSonda.Text;
                poso.HospSuresi = cbHospSure.Text != "" ? int.Parse(cbHospSure.Text) : -1;
                poso.PreopKreatin = txtPreopKre.Text != "" ? decimal.Parse(txtPreopKre.Text) : -1;
                poso.PostopKreatin = txtPostopKre.Text != "" ? decimal.Parse(txtPostopKre.Text) : -1;
                poso.PreopHct = txtPreopHct.Text != "" ? decimal.Parse(txtPreopHct.Text) : -1;
                poso.PostopHct = txtPostopHct.Text != "" ? decimal.Parse(txtPostopHct.Text) : -1;
                poso.PreopHb = txtPreopHb.Text != "" ? decimal.Parse(txtPreopHb.Text) : -1;
                poso.PostopHb = txtPostopHb.Text != "" ? decimal.Parse(txtPostopHb.Text) : -1;
                poso.Takip = txtTakip.Text;
                poso.Tel = txtTel.Text;
                poso.PostopGecKomp = txtPostopGecKomp.Text;
                poso.KompClavien = txtKompKlavien.Text;



                PatolojikVeri pato = new PatolojikVeri();
                pato.HastaID = has.ID;
                pato.Patoloji = txtPato.Text;
                pato.AltGrup = txtAltGrup.Text;
                pato.FurhmanGrade = txtFurhman.Text;
                pato.PatolojikEvre = txtPatoEvre.Text;
                pato.CerrahiSinir = cbCerSinir.Text;



                TakipVerileri tak = new TakipVerileri();
                tak.HastaID = has.ID;
                tak.Portop3ayLokalNuks = txt3ayLokal.Text;
                tak.Portop3ayKreatin = txt3ayKreatin.Text != "" ? decimal.Parse(txt3ayKreatin.Text) : -1;
                tak.Portop6ayLokalNuks = txt6ayLokal.Text;
                tak.Portop6ayKreatin = txt6ayKreatin.Text != "" ? decimal.Parse(txt6ayKreatin.Text) : -1;
                tak.Portop12ayLokalNuks = txt12ayLokal.Text;
                tak.Portop12ayKreatin = txt12ayKreatin.Text != "" ? decimal.Parse(txt12ayKreatin.Text) : -1;

                
                _db.DemografikOzs.InsertOnSubmit(dem);
                _db.OperatifOzs.InsertOnSubmit(ope);
                _db.PosOperatifOzs.InsertOnSubmit(poso);
                _db.PatolojikVeris.InsertOnSubmit(pato);
                _db.TakipVerileris.InsertOnSubmit(tak);
                _db.SubmitChanges();
                
                _m.YeniKayit("Kayıt Başarılı.");
                Temizle();

            }
            catch (Exception e)
            {
                _m.Hata(e);
            }





        }
        void Temizle()
        {
            edit = false;
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                foreach (Control ct in tabControl1.TabPages[i].Controls)
                {
                    if (ct is TextBox /*|| ct is ComboBox*/)
                        ct.Text = "";

                }
                foreach (Control _ct in tabControl1.TabPages[i].Controls)
                {
                    if (_ct is ComboBox)
                        ((ComboBox)_ct).SelectedIndex = -1;
                }
            }
            txtHastaNo.Text = _n.HastaNo();
        }
        #region Button Tanimlari
        protected override void OnLoad(EventArgs e) {
            var btnop = new Button();
            btnop.Size = new Size(25, txtOpTuru.ClientSize.Height + 2);
            btnop.Location = new Point(txtOpTuru.ClientSize.Width - btnop.Width, -1);
            btnop.Cursor = Cursors.Default;
            txtOpTuru.Controls.Add(btnop);
            SendMessage(txtOpTuru.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnop.Width << 16));
            btnop.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btndr = new Button();
            btndr.Size = new Size(25, txtDr.ClientSize.Height + 2);
            btndr.Location = new Point(txtDr.ClientSize.Width - btndr.Width, -1);
            btndr.Cursor = Cursors.Default;
            txtDr.Controls.Add(btndr);
            SendMessage(txtDr.Handle, 0xd3, (IntPtr)2, (IntPtr)(btndr.Width << 16));
            btndr.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnhs = new Button();
            btnhs.Size = new Size(25, txtHastaNo.ClientSize.Height + 2);
            btnhs.Location = new Point(txtHastaNo.ClientSize.Width - btnhs.Width, -1);
            btnhs.Cursor = Cursors.Default;
            txtHastaNo.Controls.Add(btnhs);
            SendMessage(txtHastaNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnhs.Width << 16));
            btnhs.Anchor = (AnchorStyles.Top | AnchorStyles.Right);



            base.OnLoad(e);
            btnhs.Click += btnhs_Click;
            btnop.Click += btnop_Click;
            btndr.Click += btndr_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btnhs_Click(object sender, EventArgs e) {
            int id = _f.HastaList(true);
            if (id > 0) {
                Hastac(id);
            }
            AnaSayfa.Aktarma = -1;
        }
        private void btnop_Click(object sender, EventArgs e) {
            int id = _f.OpListe(true);
            if (AnaSayfa.OpAdi != "") {
                OpAc();
            }
            AnaSayfa.DoktorAdi = "";

        }
        private void btndr_Click(object sender, EventArgs e) {
            int id = _f.DrListe(true);
            if (AnaSayfa.DoktorAdi != "") {
                DoktorAc();
            }
            AnaSayfa.DoktorAdi = "";
        } 
        #endregion
        public void Hastac(int id)
        {
            try
            {
                edit = true;
                _hastaid = id;
                Depo.HastaBilgi has = _db.HastaBilgis.First(x => x.HastaNo == _hastaid);
                txtHastaNo.Text = has.HastaNo.ToString().PadLeft(7, '0');
                txtHastaAdi.Text = has.Ad;
                txtHastaSoyad.Text = has.Soyad;
                txtProtNo.Text = has.Protokol;
                dtpOpTarih.Text = has.OpTarih.ToString();
                txtOpTuru.Text = has.OpTuru;
                txtTakipAyi.Text = has.Takip.ToString();
                txtAnah.Text = has.Anah.ToString();
                DemografikOz dem = _db.DemografikOzs.First(x => x.HastaID == _hastaid);
                txtYas.Text = dem.Yas.ToString();
                txtBoy.Text = dem.Boy.ToString();
                txtKilo.Text = dem.Kilo.ToString();
                txtBMI.Text = dem.BMI.ToString();
                cbAsa.Text = dem.Asa.ToString();
                txtDr.Text = dem.Dr.ToString();
                cbCins.Text = dem.Cins;
                cbTaraf.Text = dem.Taraf;
                txtLokal.Text = dem.Lokalizasyon;
                txtBoyut.Text = dem.Boyut.ToString();
                txtKoMor.Text = dem.KoMorbidite;
                OperatifOz ope = _db.OperatifOzs.First(x => x.HastaID == _hastaid);
                cbPksAcik.Text = ope.PksAcıklama;
                cbSik.Text = ope.Sik;
                txtCoOp.Text = ope.CoOperasyon;
                txtIskemi.Text = ope.Iskemi.ToString();
                txtPortSayi.Text = ope.PortSayisi.ToString();
                txtYardımY.Text = ope.YardımYnt;
                txtSure.Text = ope.Sure.ToString();
                txtDren.Text = ope.Dren;
                txtKanama.Text = ope.Kanama.ToString();
                txtPiyes.Text = ope.Piyes;
                PosOperatifOz pope = _db.PosOperatifOzs.First(x => x.HastaID == _hastaid);
                txtPropErKomp.Text = pope.PeropVeErkenKomp;
                txtDrenPosOp.Text = pope.Dren;
                txtPostopA.Text = pope.PostopAnaliz;
                txtSonda.Text = pope.Sonda;
                cbHospSure.Text = pope.HospSuresi.ToString();
                txtPreopKre.Text = pope.PreopKreatin.ToString();
                txtPostopKre.Text = pope.PostopKreatin.ToString();
                txtPreopHct.Text = pope.PreopHct.ToString();
                txtPostopHct.Text = pope.PostopHct.ToString();
                txtPreopHb.Text = pope.PreopHb.ToString();
                txtPostopHb.Text = pope.PostopHb.ToString();
                txtTakip.Text = pope.Takip;
                txtTel.Text = pope.Tel;
                txtPostopGecKomp.Text = pope.PostopGecKomp;
                txtKompKlavien.Text = pope.KompClavien;
                PatolojikVeri pat = _db.PatolojikVeris.First(x => x.HastaID == _hastaid);
                txtPato.Text = pat.Patoloji;
                txtAltGrup.Text = pat.AltGrup;
                txtFurhman.Text = pat.FurhmanGrade;
                txtPatoEvre.Text = pat.PatolojikEvre;
                cbCerSinir.Text = pat.CerrahiSinir;
                TakipVerileri tak = _db.TakipVerileris.First(x => x.HastaID == _hastaid);
                txt3ayLokal.Text = tak.Portop3ayLokalNuks;
                txt3ayKreatin.Text = tak.Portop3ayKreatin.ToString();
                txt6ayLokal.Text = tak.Portop6ayLokalNuks;
                txt6ayKreatin.Text = tak.Portop6ayKreatin.ToString();
                txt12ayLokal.Text = tak.Portop12ayLokalNuks;
                txt12ayKreatin.Text = tak.Portop12ayKreatin.ToString();
            }
            catch (Exception e)
            {

                _m.Hata(e);
            }



        }
        public void DoktorAc()
        {
            txtDr.Text = AnaSayfa.DoktorAdi;
        }

        public void OpAc()
        {
            txtOpTuru.Text = AnaSayfa.OpAdi;
        }
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (edit && _hastaid > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!edit) YeniKaydet();
        }
        void Guncelle()
        {
            edit = true;

            Depo.HastaBilgi has = _db.HastaBilgis.First(x => x.ID == _hastaid);
            //has.HastaNo = int.Parse(txtHastaNo.Text);
            has.Ad = txtHastaAdi.Text;
            has.Soyad = txtHastaSoyad.Text;
            has.Protokol = txtProtNo.Text;
            has.OpTarih = DateTime.Parse(dtpOpTarih.Text);
            has.OpTuru = txtOpTuru.Text;
            has.Takip = int.Parse(txtTakipAyi.Text);
            has.Anah = int.Parse(txtAnah.Text);



            DemografikOz dem = _db.DemografikOzs.First(x => x.HastaID == _hastaid);
            //dem.HastaID = _db.HastaBilgis.First(x => x.ID == int.Parse(txtHastaNo.Text)).ID;
            dem.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : -1;
            dem.Boy = int.Parse(txtBoy.Text);
            dem.Kilo = decimal.Parse(txtBoy.Text);
            dem.BMI = int.Parse(txtBMI.Text);
            dem.Asa = int.Parse(cbAsa.Text);
            dem.Dr = txtDr.Text;
            dem.Cins = cbCins.Text;
            dem.Taraf = cbTaraf.Text;
            dem.Lokalizasyon = txtLokal.Text;
            dem.Boyut = int.Parse(txtBoyut.Text);
            dem.KoMorbidite = txtKoMor.Text;




            OperatifOz ope = _db.OperatifOzs.First(x => x.HastaID == _hastaid);
            //ope.HastaID = _db.HastaBilgis.First(x => x.ID == int.Parse(txtHastaNo.Text)).ID;
            ope.PksAcıklama = cbPksAcik.Text;
            ope.Sik = cbSik.Text;
            ope.CoOperasyon = txtCoOp.Text;
            ope.Iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text) : -1;
            ope.PortSayisi = txtPortSayi.Text != "" ? int.Parse(txtPortSayi.Text) : -1;
            ope.YardımYnt = txtYardımY.Text;
            ope.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : -1;
            ope.Dren = txtDren.Text;
            ope.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text) : -1;
            ope.Piyes = txtPiyes.Text;



            PosOperatifOz poso = _db.PosOperatifOzs.First(x => x.HastaID == _hastaid);
            //poso.HastaID = _db.HastaBilgis.First(x => x.ID == int.Parse(txtHastaNo.Text)).ID;
            poso.PeropVeErkenKomp = txtPropErKomp.Text;
            poso.Dren = txtDrenPosOp.Text;
            poso.PostopAnaliz = txtPostopA.Text;
            poso.Sonda = txtSonda.Text;
            poso.HospSuresi = int.Parse(cbHospSure.Text);
            poso.PreopKreatin = txtPreopKre.Text != "" ? decimal.Parse(txtPreopKre.Text) : -1;
            poso.PostopKreatin = txtPostopKre.Text != "" ? decimal.Parse(txtPostopKre.Text) : -1;
            poso.PreopHct = txtPreopHct.Text != "" ? decimal.Parse(txtPreopHct.Text) : -1;
            poso.PostopHct = txtPostopHct.Text != "" ? decimal.Parse(txtPostopHct.Text) : -1;
            poso.PreopHb = txtPreopHb.Text != "" ? decimal.Parse(txtPreopHb.Text) : -1;
            poso.PostopHb = txtPostopHb.Text != "" ? decimal.Parse(txtPostopHb.Text) : -1;
            poso.Takip = txtTakip.Text;
            poso.Tel = txtTel.Text;
            poso.PostopGecKomp = txtPostopGecKomp.Text;
            poso.KompClavien = txtKompKlavien.Text;

            PatolojikVeri pato = _db.PatolojikVeris.First(x => x.HastaID == _hastaid);
            //pato.HastaID = _db.HastaBilgis.First(x => x.ID == int.Parse(txtHastaNo.Text)).ID;
            pato.Patoloji = txtPato.Text;
            pato.AltGrup = txtAltGrup.Text;
            pato.FurhmanGrade = txtFurhman.Text;
            pato.PatolojikEvre = txtPatoEvre.Text;
            pato.CerrahiSinir = cbCerSinir.Text;



            TakipVerileri tak = _db.TakipVerileris.First(x => x.HastaID == _hastaid);
            //tak.HastaID = _db.HastaBilgis.First(x => x.ID == int.Parse(txtHastaNo.Text)).ID;
            tak.Portop3ayLokalNuks = txt3ayLokal.Text;
            tak.Portop3ayKreatin = txt3ayKreatin.Text != "" ? decimal.Parse(txt3ayKreatin.Text) : -1;
            tak.Portop6ayLokalNuks = txt6ayLokal.Text;
            tak.Portop6ayKreatin = txt6ayKreatin.Text != "" ? decimal.Parse(txt6ayKreatin.Text) : -1;
            tak.Portop12ayLokalNuks = txt12ayLokal.Text;
            tak.Portop12ayKreatin = txt12ayKreatin.Text != "" ? decimal.Parse(txt12ayKreatin.Text) : -1;

            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }

        private void txtBMI_Click(object sender, EventArgs e)
        {
            Combo();
        }

        #region Sadece Sayi Girme
        private void txtTakipAyi_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtAnah_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtYas_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoy_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKilo_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoyut_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIskemi_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPortSayi_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSure_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKanama_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPreopKre_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtPostopKre_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtPreopHct_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtPostopHct_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtPreopHb_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtPostopHb_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txt3ayKreatin_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txt6ayKreatin_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txt12ayKreatin_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        } 
        #endregion
    }
}
